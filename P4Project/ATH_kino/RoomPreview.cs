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
        public List<Button> seatList { get; set; } = new List<Button>();
        public RoomPreview(string filmName, DateTime showtimeDate, TimeSpan showtimeTime)
        {
            InitializeComponent();

            using (var ctx = new ATH_kinoEntities())
            {
                var roomInfo = (from f in ctx.Film
                                join s in ctx.Seans on f.ID_Film equals s.ID_Film
                                join r in ctx.Sala on s.ID_Sala equals r.ID_Sala
                                where (s.Data == showtimeDate &&
                                       s.Godzina == showtimeTime)
                                select new
                                {
                                    roomNumber = s.ID_Sala
                                });

                labelDate.Text = showtimeDate.ToString("dd.MM.yyyy");
                labelTime.Text = showtimeTime.ToString("HH:mm");
                labelRoomNumber.Text = roomInfo.ToString();

                    var seatsInfo = (from f in ctx.Film
                                     join s in ctx.Seans on f.ID_Film equals s.ID_Film
                                     join re in ctx.Rezerwacja on s.ID_Seans equals re.ID_Seans
                                     where (f.Nazwa == filmName && s.Data == showtimeDate && s.Godzina == showtimeTime)
                                     select new
                                     {
                                         SeatNumber = re.Miejsce
                                     }).ToList();

                var rowCount = 5;
                var columnCount = 10;

                tableLayoutPanelRoomPreview.ColumnCount = columnCount;
                tableLayoutPanelRoomPreview.RowCount = rowCount;

                tableLayoutPanelRoomPreview.ColumnStyles.Clear();
                tableLayoutPanelRoomPreview.RowStyles.Clear();

                for (int i = 0; i < columnCount; i++)
                {
                    tableLayoutPanelRoomPreview.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50));
                }

                for (int i = 0; i < rowCount; i++)
                {
                    tableLayoutPanelRoomPreview.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50));
                }

                for (int i = 0; i < rowCount * columnCount; i++)
                {
                    var seat = new Button();
                    seat.Text = (i + 1).ToString();
                    seat.Tag = "1";
                    seat.Name = string.Format("b_{0}", i + 1);
                    seat.Click += b_Click;
                    seat.Size = new System.Drawing.Size(50, 50);
                    tableLayoutPanelRoomPreview.Controls.Add(seat);
                    seatList.Add(seat);
                }
                foreach (var seat in seatList)
                {
                    if (seat.Tag == "1")
                    {
                        seat.BackColor = Color.Red;
                    }
                }
            }
        }

        void b_Click(object sender, EventArgs e)
        {
            var b = sender as Button;
            if (b != null)
                MessageBox.Show(string.Format("{0} Clicked", b.Text));
        }
    }
}