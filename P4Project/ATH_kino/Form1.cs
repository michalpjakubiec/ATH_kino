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
    public partial class Form1 : Form
    {

        Form2 f2 = new Form2();

        public Form1()
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
                //var q = from Film in ATH_kino
                //        where Film.Nazwa == currentItem
                //        select Film.Rezyser;
                MessageBox.Show("Not implemented yet.");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            f2.ShowDialog(this);
        }


    }
}


