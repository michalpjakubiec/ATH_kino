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
    public partial class ClientPanel : Form
    {

        Form2 f2 = new Form2();

        public ClientPanel()
        {
            InitializeComponent();

            using (var ctx = new ATH_kinoEntities())
            {
                var data = ctx.Film;
                comboBoxFilmsList.Items.Add("(brak)");
                foreach (var item in data)
                {
                    comboBoxFilmsList.Items.Add($"{item.Nazwa}");
                }
            }
        }

        private void comboBoxFilmsList_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            using (var ctx = new ATH_kinoEntities())
            {
                string currentItem = comboBoxFilmsList.SelectedItem.ToString();

                var q = (from Film in ctx.Film
                         where Film.Nazwa == currentItem
                         select Film.Rezyser).ToArray();

                foreach (var item in q)
                {
                    richTextBox1.Text = item.ToString();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            f2.ShowDialog(this);
        }
    }
}


