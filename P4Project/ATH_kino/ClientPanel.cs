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
using System.IO;

namespace ATH_kino
{
    public partial class ClientPanel : Form
    {
        private void ClearClientPanel()
        {
            labelFilmName.Text = null;
            labelGenre.Text = null;
            labelDirector.Text = null;
            labelWriter.Text = null;
            labelCountry.Text = null;
            labelPremiere.Text = null;
            labelActor.Text = null;
            pictureBoxCover.Image = null;

            comboBoxDateSelection.Items.Clear();
            comboBoxDateSelection.Enabled = false;

            comboBoxTimeSelection.Items.Clear();
            comboBoxTimeSelection.Enabled = false;

            buttonRoomPreview.Enabled = false;
        }
        private void ClientPanel_Load(object sender, EventArgs e)
        {
            using (var ctx = new ATH_kinoEntities())
            {
                foreach (var name in ctx.Film)
                {
                    comboBoxFilmsList.Items.Add($"{name.Nazwa}");
                }
            }
        }

        public ClientPanel()
        {
            InitializeComponent();
        }

        private void comboBoxFilmsList_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (var ctx = new ATH_kinoEntities())
            {
                string selectedFilm = comboBoxFilmsList.SelectedItem.ToString();

                var filmInfo = (from f in ctx.Film
                                join d in ctx.Rezyser on f.ID_Rezyser equals d.ID_Rezyser
                                join w in ctx.Scenarzysta on f.ID_Scenarzysta equals w.ID_Scenarzysta
                                join c in ctx.Okladka on f.ID_Film equals c.ID_Film
                                where f.Nazwa == selectedFilm
                                select new
                                {
                                    FilmName = f.Nazwa,
                                    Director = d.Imie + " " + d.Nazwisko,
                                    Writer = w.Imie + " " + w.Nazwisko,
                                    Country = f.Produkcja,
                                    Premiere = f.DataPremierySwiat.ToString(),
                                    Cover = c.Obraz
                                }).FirstOrDefault();

                var actorInfo = (from f in ctx.Film
                                 join r in ctx.Rola on f.ID_Film equals r.ID_Film
                                 join a in ctx.Aktor on r.ID_Aktor equals a.ID_Aktor
                                 where f.Nazwa == selectedFilm
                                 select new
                                 {
                                     ActorName = a.Imie + " " + a.Nazwisko,
                                     ActorRole = r.Nazwa
                                 }).ToList();

                var genreInfo = (from f in ctx.Film
                                 join gd in ctx.GatunekSzczegoly on f.ID_Film equals gd.ID_Film
                                 join g in ctx.Gatunek on gd.ID_Gatunek equals g.ID_Gatunek
                                 where f.Nazwa == selectedFilm
                                 select new
                                 {
                                     GenreName = g.Nazwa
                                 }).ToArray();

                if (selectedFilm == "")
                {
                    ClearClientPanel();
                }
                else
                {
                    labelFilmName.Text = filmInfo.FilmName;
                    labelDirector.Text = filmInfo.Director;
                    labelWriter.Text = filmInfo.Writer;
                    labelCountry.Text = filmInfo.Country;
                    labelPremiere.Text = filmInfo.Premiere;

                    labelGenre.Text = null;
                    foreach (var name in genreInfo)
                    {
                        labelGenre.Text += $"{name.GenreName}" + ", ";
                    }
                    labelGenre.Text = labelGenre.Text.TrimEnd().TrimEnd(',');

                    labelActor.Text = null;
                    foreach (var name in actorInfo)
                    {
                        labelActor.Text += $"{name.ActorName}" + "\n";
                    }

                    using (MemoryStream stream = new MemoryStream(filmInfo.Cover))
                    {
                        Bitmap image = new Bitmap(stream);
                        pictureBoxCover.Image = image;
                    }

                    comboBoxDateSelection.Items.Clear();
                    comboBoxDateSelection.Enabled = true;
                }

                var dateInfo = (from f in ctx.Film
                                join s in ctx.Seans on f.ID_Film equals s.ID_Film
                                where f.Nazwa == selectedFilm
                                select s.Data);

                foreach (var date in dateInfo)
                {
                    if (!comboBoxDateSelection.Items.Contains(date))
                    {
                        comboBoxDateSelection.Items.Add(date);
                    }
                }

                comboBoxTimeSelection.Items.Clear();
                comboBoxTimeSelection.Enabled = false;

                buttonRoomPreview.Enabled = false;
            }
        }

        private void comboBoxDateSelection_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxTimeSelection.Items.Clear();
            comboBoxTimeSelection.Enabled = true;

            string selectedFilm = comboBoxFilmsList.SelectedItem.ToString();
            DateTime selectedDate = DateTime.Parse(comboBoxDateSelection.SelectedItem.ToString());
            using (var ctx = new ATH_kinoEntities())
            {
                var timeInfo = (from f in ctx.Film
                                join s in ctx.Seans on f.ID_Film equals s.ID_Film
                                where (s.Data == selectedDate &&
                                       f.Nazwa == selectedFilm)
                                select s.Godzina);

                foreach (var time in timeInfo)
                {
                    DateTime timeParsed = DateTime.Parse(time.ToString());
                    comboBoxTimeSelection.Items.Add(timeParsed);
                }
            }
        }

        private void comboBoxTimeSelection_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxTimeSelection.Text != "")
                buttonRoomPreview.Enabled = true;
        }

        private void buttonRoomPreview_Click(object sender, EventArgs e)
        {
            var formRoomPreview = new RoomPreview();

            formRoomPreview.ShowDialog();
        }
    }
}
