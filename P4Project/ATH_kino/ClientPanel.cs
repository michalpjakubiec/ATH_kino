using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity.Infrastructure;

namespace ATH_kino
{
    // statystyki
    // wykresy
    public partial class clientPanel : Form
    {
        Form2 f2 = new Form2();

        public clientPanel()
        {
            InitializeComponent();

            using (var ctx = new ATH_kinoEntities())
            {
                var data = ctx.Film;
                comboBoxFilmsList.Items.Add("");
                foreach (var item in data)
                {
                    comboBoxFilmsList.Items.Add($"{item.Nazwa}");
                }
            }
        }

        private void comboBoxFilmsList_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (var ctx = new ATH_kinoEntities())
            {
                var dataFilm = ctx.Film;
                var dataDirector = ctx.Rezyser;
                var dataWriter = ctx.Scenarzysta;

                string currentItem = comboBoxFilmsList.SelectedItem.ToString();

                var qFilm = (from f in dataFilm
                             join d in dataDirector on f.ID_Rezyser equals d.ID_Rezyser

                             where f.Nazwa == currentItem
                             select new
                             {
                                 f.Nazwa,
                                 d.Imie,
                                 d.Nazwisko
                             }).FirstOrDefault();

                labelFilmName.Text = qFilm.Nazwa;
                labelFilmName.Text = q.Rezyser;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            f2.ShowDialog(this);
        }
    }
}




