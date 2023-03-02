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
    public partial class LabsHub : Form
    {
        public LabsHub()
        {
            InitializeComponent();
        }

        private LoginForm MainLoginFrom = null;
        public LabsHub(Form CallingForm)
        {
            MainLoginFrom = CallingForm as LoginForm;
            InitializeComponent();
        }

        private void LabsHubBtn_MouseLeave(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (btn != null)
            {
                btn.BackColor = Color.FromArgb(26, 26, 26);
                btn.ForeColor = Color.Orange;
            }
        }

        private void LabsHubBtn_MouseEnter(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (btn != null)
            {
                btn.BackColor = Color.Orange;
                btn.ForeColor = Color.FromArgb(26, 26, 26);
            }
        }

        private void LabsHubBtn_MouseDown(object sender, MouseEventArgs e)
        {
            Button btn = sender as Button;
            if (btn != null)
            {
                btn.BackColor = Color.DarkOrange;
            }
        }

        private void LabsHubBtn_MouseUp(object sender, MouseEventArgs e)
        {
            Button btn = sender as Button;
            if (btn != null)
            {
                btn.BackColor = Color.Orange;
            }
        }

        private void LabsHub_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void BackButton_MouseLeave(object sender, EventArgs e)
        {
            BackButton.BackColor = Color.FromArgb(26, 26, 26);
            BackButton.ForeColor = Color.DarkOrchid;
        }

        private void BackButton_MouseEnter(object sender, EventArgs e)
        {
            BackButton.BackColor = Color.DarkOrchid;
            BackButton.ForeColor = Color.FromArgb(26, 26, 26);
        }

        private void BackButton_MouseDown(object sender, MouseEventArgs e)
        {
            BackButton.BackColor = Color.Indigo;
        }

        private void BackButton_MouseUp(object sender, MouseEventArgs e)
        {
            BackButton.BackColor = Color.DarkOrchid;
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainLoginFrom.Show();
        }

        private void Lab1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Lab1 Lab1Form = new Lab1(this);
            Lab1Form.Show();
        }

        private void Lab2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Lab2 Lab2Form = new Lab2(this);
            Lab2Form.Show();
        }

        private void Lab3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Lab3 Lab3Form = new Lab3(this);
            Lab3Form.Show();
        }

        private void Lab4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Lab4 Lab4Form = new Lab4(this);
            Lab4Form.Show();
        }

        private void Lab5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Lab5 Lab5Form = new Lab5(this);
            Lab5Form.Show();
        }

        private void Lab6_Click(object sender, EventArgs e)
        {
            this.Hide();
            Lab6 Lab6Form = new Lab6(this);
            Lab6Form.Show();
        }

        private void Lab7_Click(object sender, EventArgs e)
        {
            this.Hide();
            Lab7 Lab7Form = new Lab7(this);
            Lab7Form.Show();
        }
    }
}
