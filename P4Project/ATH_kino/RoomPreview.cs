using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATH_kino
{
    public partial class RoomPreview : Form
    {
        public List<Button> SeatList { get; set; } = new List<Button>();
        public int ShowtimeId { get; set; }
        public int Counter { get; set; }
        public int ReturnedChoice { get; set; }
        public TicketTypeSelectWindow FormTicketTypeSelectWindow { get; set; } = new TicketTypeSelectWindow();
        private void FillLabels(string filmName, DateTime showtimeDate, TimeSpan showtimeTime)
        {
            using (var ctx = new ATH_kinoEntities())
            {
                var roomInfo = (from f in ctx.Film
                                join s in ctx.Seans on f.ID_Film equals s.ID_Film
                                join r in ctx.Sala on s.ID_Sala equals r.ID_Sala
                                where (f.Nazwa == filmName &&
                                       s.Data == showtimeDate &&
                                       s.Godzina == showtimeTime)
                                select new
                                {
                                    roomNumber = s.ID_Sala
                                }).FirstOrDefault();

                labelFilmName.Text = filmName;
                labelDate.Text = showtimeDate.ToString("dd.MM.yyyy");
                labelTime.Text = showtimeTime.ToString(@"hh\:mm");
                labelRoomNumber.Text = roomInfo.roomNumber.ToString();
            }
        }

        private void CreateDynamicRoomPreview(string filmName, DateTime showtimeDate, TimeSpan showtimeTime)
        {
            const int column = 10;
            const int row = 5;

            tableLayoutPanelRoomPreview.ColumnCount = 10;
            tableLayoutPanelRoomPreview.RowCount = 5;

            tableLayoutPanelRoomPreview.ColumnStyles.Clear();
            tableLayoutPanelRoomPreview.RowStyles.Clear();

            for (int i = 0; i < column; i++)
                tableLayoutPanelRoomPreview.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 50));
            for (int i = 0; i < row; i++)
                tableLayoutPanelRoomPreview.RowStyles.Add(new RowStyle(SizeType.Absolute, 50));

            using (var ctx = new ATH_kinoEntities())
            {
                var seatInfo = (from f in ctx.Film
                                join s in ctx.Seans on f.ID_Film equals s.ID_Film
                                join re in ctx.Rezerwacja on s.ID_Seans equals re.ID_Seans
                                where (f.Nazwa == filmName &&
                                       s.Data == showtimeDate &&
                                       s.Godzina == showtimeTime)
                                select re.Miejsce);

                var showtimeInfo = (from f in ctx.Film
                                    join s in ctx.Seans on f.ID_Film equals s.ID_Film
                                    join re in ctx.Rezerwacja on s.ID_Seans equals re.ID_Seans
                                    where (f.Nazwa == filmName &&
                                           s.Data == showtimeDate &&
                                           s.Godzina == showtimeTime)
                                    select s.ID_Seans);

                foreach (var id in showtimeInfo)
                {
                    ShowtimeId = id;
                }

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

                    foreach (var item in seatInfo)
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
        public RoomPreview(string filmName, DateTime showtimeDate, TimeSpan showtimeTime)
        {
            InitializeComponent();
            FillLabels(filmName, showtimeDate, showtimeTime);
            CreateDynamicRoomPreview(filmName, showtimeDate, showtimeTime);
            labelScreen.Left = this.Height / 2 - labelScreen.Height;
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
            messageBoxSb.ToString();

            var messageBoxConfirmation = MessageBox.Show($"{messageBoxSb}", "Potwierdzenie rezerwacji",
                                                         MessageBoxButtons.YesNo,
                                                         MessageBoxIcon.Question);
            if (messageBoxConfirmation == DialogResult.Yes)
            {
                foreach (var seat in SeatList)
                {
                    if (seat.BackColor == Color.Orange)
                    {
                        using (var ctx = new ATH_kinoEntities())
                        {
                            Rezerwacja newReservation = new Rezerwacja()
                            {
                                //ID_Rezerwacja = 501,
                                ID_Klient = 1,
                                ID_Seans = ShowtimeId,
                                Miejsce = int.Parse(seat.Text),
                                DataRezerwacji = DateTime.Now,
                                //CenaBiletu = 0,
                                //ZnizkaProcent = 0,
                                //ZnizkaOpis = string.Empty,
                                //ZnizkaNrDokumentu = string.Empty
                            };

                            ctx.Rezerwacja.Add(newReservation);
                            ctx.SaveChanges();
                        }
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