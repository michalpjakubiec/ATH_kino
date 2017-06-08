using System;
using System.Windows.Forms;

namespace ATH_kino
{
    public partial class ClientPanel : Form
    {
        public AthQuery Q { get; set; } = new AthQuery();

        private void ClearClientPanel()
        {
            labelFilmName.Text = string.Empty;
            labelGenre.Text = string.Empty;
            labelDirector.Text = string.Empty;
            labelWriter.Text = string.Empty;
            labelCountry.Text = string.Empty;
            labelPremiere.Text = string.Empty;
            labelActor.Text = string.Empty;
            pictureBoxCover.Image = null;

            comboBoxDateSelection.Items.Clear();
            comboBoxDateSelection.Enabled = false;

            comboBoxTimeSelection.Items.Clear();
            comboBoxTimeSelection.Enabled = false;

            buttonRoomPreview.Enabled = false;
        }

        public ClientPanel()
        {
            InitializeComponent();
        }

        private void ClientPanel_Load(object sender, EventArgs e)
        {
            Q.GetFilmsTitles();

            foreach (var title in Q.FilmTitlesList)
                comboBoxFilmsList.Items.Add($"{title}");
        }

        private void comboBoxFilmsList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxFilmsList.SelectedItem.ToString() == "")
                ClearClientPanel();
            else
            {
                Q.CurrentFilmTitle = comboBoxFilmsList.SelectedItem.ToString();
                Q.GetCurrentFilmDetails();

                labelFilmName.Text = Q.CurrentFilmTitle;
                labelDirector.Text = Q.Director;
                labelWriter.Text = Q.Writer;
                labelCountry.Text = Q.Country;
                labelPremiere.Text = Q.Premiere.ToString("dd MMMM yyyy");

                labelGenre.Text = string.Empty;
                labelGenre.Text = Q.Genre;

                labelActor.Text = string.Empty;
                labelActor.Text = Q.Actor;

                pictureBoxCover.Image = Q.Cover;

                comboBoxDateSelection.Items.Clear();
                comboBoxDateSelection.Enabled = true;

                Q.GetCurrentFilmDate();
                comboBoxDateSelection.Items.Clear();

                foreach (var date in Q.CurrentFilmDateList)
                    comboBoxDateSelection.Items.Add(date);

                comboBoxTimeSelection.Items.Clear();
                comboBoxTimeSelection.Enabled = false;

                buttonRoomPreview.Enabled = false;
            }
        }

        private void comboBoxDateSelection_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxTimeSelection.Items.Clear();
            comboBoxTimeSelection.Enabled = true;
            buttonRoomPreview.Enabled = false;

            Q.CurrentFilmCurrentDate = DateTime.Parse(comboBoxDateSelection.SelectedItem.ToString());

            Q.GetCurrentFilmTime();
            comboBoxTimeSelection.Items.Clear();

            foreach (var time in Q.CurrentFilmTimeList)
                comboBoxTimeSelection.Items.Add(time.ToString(@"hh\:mm"));
        }

        private void comboBoxTimeSelection_SelectedIndexChanged(object sender, EventArgs e)
        {
            Q.CurrentFilmCurrentDate = DateTime.Parse(comboBoxDateSelection.SelectedItem.ToString());

            Q.GetCurrentFilmTime();

            foreach (var time in Q.CurrentFilmTimeList)
                comboBoxTimeSelection.Items.Add(time.ToString(@"hh\:mm"));

            if (comboBoxTimeSelection.Text != "")
                buttonRoomPreview.Enabled = true;
        }

        private void buttonRoomPreview_Click(object sender, EventArgs e)
        {
            Q.CurrentFilmCurrentTime = TimeSpan.Parse(comboBoxTimeSelection.SelectedItem.ToString());

            var formRoomPreview = new RoomPreview(Q);
            formRoomPreview.ShowDialog();
        }
    }
}