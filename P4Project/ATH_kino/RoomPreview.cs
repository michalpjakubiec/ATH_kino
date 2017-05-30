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
        public int Counter { get; set; }
        public int ReturnedChoice { get; set; }
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
            var column = 10;
            var row = 5;

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

                for (int i = 0; i < column * row; i++)
                {
                    var seat = new Button();
                    seat.Text = (i + 1).ToString();
                    seat.Name = $"{i + 1}";
                    seat.Size = new Size(50, 50);
                    seat.FlatStyle = FlatStyle.Flat;
                    seat.BackColor = Color.LightGray;
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
        }

        void seat_Click(object sender, EventArgs e)
        {
            Button seat = (Button)sender;

            if (seat.BackColor == Color.Orange)
            {
                seat.BackColor = Color.LightGray;
                Counter -= 1;
            }
            else
            {
                var formTicketTypeSelector = new TicketTypeSelector();
                formTicketTypeSelector.ShowDialog();

                if (formTicketTypeSelector.returnChoice >= 1 && formTicketTypeSelector.returnChoice <= 4)
                {
                    seat.BackColor = Color.Orange;
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
            var messageBoxConfirmation = MessageBox.Show("Czy potwierdzasz rezerwację?", "Potwierdzenie",
                                 MessageBoxButtons.YesNo,
                                 MessageBoxIcon.Question);
            if (messageBoxConfirmation == DialogResult.Yes)
            {
                MessageBox.Show("Rezerwacja zakończona pomyślnie.");
                this.Close();
            }
        }
    }
}