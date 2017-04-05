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
    public partial class LoginPanel : Form
    {
        ClientPanel clientPanel = new ClientPanel();

        public LoginPanel()
        {
            InitializeComponent();            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string login = "a";
            string password = "b";

            if (textBoxLogin.Text == login && textBoxPass.Text == password)
            {
                Hide();
                clientPanel.Show();
            }
        }
    }
}
