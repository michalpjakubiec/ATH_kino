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
    public partial class TicketTypeSelector : Form
    {
        public int returnChoice { get; set; }

        public TicketTypeSelector()
        {
            InitializeComponent();
        }
        private void buttonOK_Click(object sender, EventArgs e)
        {
            if (radioButtonNormal.Checked == true)
                returnChoice = 1;
            if (radioButtonSchool.Checked == true)
                returnChoice = 2;
            if (radioButtonStudent.Checked == true)
                returnChoice = 3;
            if (radioButtonSenior.Checked == true)
                returnChoice = 4;

            this.Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
