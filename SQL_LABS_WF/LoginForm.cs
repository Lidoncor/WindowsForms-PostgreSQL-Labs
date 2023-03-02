using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SQL_LABS_WF
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void NextButton_MouseLeave(object sender, EventArgs e)
        {
            NextButton.BackColor = Color.FromArgb(26, 26, 26);
            NextButton.ForeColor = Color.DarkOrchid;
        }

        private void NextButton_MouseEnter(object sender, EventArgs e)
        {
            NextButton.BackColor = Color.DarkOrchid;
            NextButton.ForeColor = Color.FromArgb(26, 26, 26);
        }

        private void NextButton_MouseDown(object sender, MouseEventArgs e)
        {
            NextButton.BackColor = Color.Indigo;
        }

        private void NextButton_MouseUp(object sender, MouseEventArgs e)
        {
            NextButton.BackColor = Color.DarkOrchid;
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            Program.host = Host_box.Text;
            Program.port = Port_box.Text;
            Program.dbname = dbname_box.Text;
            Program.user = Username_box.Text;
            Program.pass = Password_box.Text;

            this.Hide();
            LabsHub LabsHubForm = new LabsHub(this);
            LabsHubForm.Show();
        }
    }
}
