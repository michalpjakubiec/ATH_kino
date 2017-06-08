using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ATH_kino
{
    public partial class RoomPreview : Form
    {
        public AthQuery Q { get; set; }
        public List<Button> SeatList { get; set; } = new List<Button>();
        public int Counter { get; set; }
        public int ReturnedChoice { get; set; }
        public TicketTypeSelectWindow FormTicketTypeSelectWindow { get; set; } = new TicketTypeSelectWindow();

        public RoomPreview(AthQuery q)
        {
            InitializeComponent();
            Q = q;
            Q.GetCurrentShowtimeDetails();
            FillLabels();
            CreateDynamicRoomPreview();
            labelScreen.Left = this.Height / 2 - labelScreen.Height;
        }

        private void FillLabels()
        {
            labelFilmName.Text = Q.CurrentFilmTitle;
            labelDate.Text = Q.CurrentFilmCurrentDate.ToString("dd.MM.yyyy");
            labelTime.Text = Q.CurrentFilmCurrentTime.ToString(@"hh\:mm");
            labelRoomNumber.Text = Q.RoomNumber.ToString();
        }

        private void CreateDynamicRoomPreview()
        {
            const int column = 10;
            const int row = 5;

            tableLayoutPanelRoomPreview.ColumnCount = column;
            tableLayoutPanelRoomPreview.RowCount = row;

            tableLayoutPanelRoomPreview.ColumnStyles.Clear();
            tableLayoutPanelRoomPreview.RowStyles.Clear();

            for (int i = 0; i < column; i++)
                tableLayoutPanelRoomPreview.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 50));
            for (int i = 0; i < row; i++)
                tableLayoutPanelRoomPreview.RowStyles.Add(new RowStyle(SizeType.Absolute, 50));

            using (var ctx = new ATH_kinoEntities())
            {
                for (int i = 0; i < column * row; i++)
                {
                    var seat = new Button();
                    seat.Text = (i + 1).ToString();
                    seat.Name = $"{i + 1}";
                    seat.Size = new Size(50, 50);
                    seat.FlatStyle = FlatStyle.Flat;
                    seat.FlatAppearance.BorderSize = 0;
                    seat.BackColor = Color.LightGray;
                    seat.Tag = "0";
                    seat.Click += seat_Click;
                    tableLayoutPanelRoomPreview.Controls.Add(seat);
                    SeatList.Add(seat);

                    foreach (var item in Q.ShowtimeSeatList)
                    {
                        if (seat.Name == item.ToString())
                        {
                            seat.Enabled = false;
                            seat.BackColor = Color.DarkRed;
                            seat.ForeColor = Color.White;
                        }
                    }
                }
            }
        }

        void seat_Click(object sender, EventArgs e)
        {
            Button seat = (Button)sender;

            if (seat.BackColor == Color.Orange)
            {
                seat.BackColor = Color.LightGray;
                seat.Tag = 0;
                Counter -= 1;
            }
            else
            {
                FormTicketTypeSelectWindow.ShowDialog();

                if (FormTicketTypeSelectWindow.ChoosedSeatType >= 1 && FormTicketTypeSelectWindow.ChoosedSeatType <= 4)
                {
                    seat.BackColor = Color.Orange;

                    switch (FormTicketTypeSelectWindow.ChoosedSeatType)
                    {
                        case 1:
                            seat.Tag = "normalny";
                            break;
                        case 2:
                            seat.Tag = "studencki";
                            break;
                        case 3:
                            seat.Tag = "szkolny";
                            break;
                        case 4:
                            seat.Tag = "seniorski";
                            break;
                        default:
                            seat.Tag = 0;
                            break;
                    }

                    Counter += 1;
                }
            }

            if (Counter == 0)
                buttonOK.Enabled = false;
            else
                buttonOK.Enabled = true;
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            StringBuilder messageBoxSb = new StringBuilder();

            messageBoxSb.AppendLine("Wybrane miejsca:");
            messageBoxSb.AppendLine("");
            foreach (var seat in SeatList)
            {
                if (seat.BackColor == Color.Orange)
                {
                    messageBoxSb.AppendLine($"{seat.Text} - {seat.Tag}");
                }
            }
            messageBoxSb.AppendLine("");
            messageBoxSb.AppendLine("Czy potwierdzasz rezerwację?");

            var messageBoxConfirmation = MessageBox.Show($"{messageBoxSb}", "Potwierdzenie rezerwacji",
                                                         MessageBoxButtons.YesNo,
                                                         MessageBoxIcon.Question);
            if (messageBoxConfirmation == DialogResult.Yes)
            {
                foreach (var seat in SeatList)
                {
                    if (seat.BackColor == Color.Orange)
                    {
                        Rezerwacja newReservation = new Rezerwacja()
                        {
                            ID_Klient = 1,
                            ID_Seans = Q.ShowtimeId,
                            Miejsce = int.Parse(seat.Text),
                            DataRezerwacji = DateTime.Now,
                            //CenaBiletu = 0,
                            //ZnizkaProcent = 0,
                            //ZnizkaOpis = string.Empty,
                            //ZnizkaNrDokumentu = string.Empty
                        };
                        Q.Ctx.Rezerwacja.Add(newReservation);
                        Q.Ctx.SaveChanges();
                    }
                }

                MessageBox.Show("Rezerwacja zakończona pomyślnie.", "",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Asterisk);
                this.Close();
            }
        }
    }
}