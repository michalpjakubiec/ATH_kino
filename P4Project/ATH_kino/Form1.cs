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
        public Form1()
        {
            InitializeComponent();

        }

        private void comboBoxFilmsList_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (var ctx = new ATH_kinoEntities())
            {
                string selected = comboBoxFilmsList.SelectedItem.ToString();
                labelName.Text = selected;
               // labelDirector.Text =
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
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
    }
}

