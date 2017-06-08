using System;
using System.Windows.Forms;

namespace ATH_kino
{
    public partial class TicketTypeSelectWindow : Form
    {
        public int ChoosedSeatType { get; set; }

        public TicketTypeSelectWindow()
        {
            InitializeComponent();
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            if (radioButtonNormal.Checked)
                ChoosedSeatType = 1;
            if (radioButtonSchool.Checked)
                ChoosedSeatType = 2;
            if (radioButtonStudent.Checked)
                ChoosedSeatType = 3;
            if (radioButtonSenior.Checked)
                ChoosedSeatType = 4;

            this.Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
