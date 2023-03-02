using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace SQL_LABS_WF
{
    public partial class Lab1 : Form
    {
        NpgsqlConnection connect;

        public Lab1()
        {
            InitializeComponent();
        }

        private LabsHub MainLabsHubFrom = null;
        public Lab1(Form CallingForm)
        {
            MainLabsHubFrom = CallingForm as LabsHub;
            InitializeComponent();
        }

        private void BackButton_MouseLeave(object sender, EventArgs e)
        {
            BackButton.BackColor = Color.FromArgb(36, 36, 36);
            BackButton.ForeColor = Color.DarkOrchid;
        }

        private void BackButton_MouseEnter(object sender, EventArgs e)
        {
            BackButton.BackColor = Color.DarkOrchid;
            BackButton.ForeColor = Color.FromArgb(36, 36, 36);
        }

        private void BackButton_MouseDown(object sender, MouseEventArgs e)
        {
            BackButton.BackColor = Color.Indigo;
        }

        private void BackButton_MouseUp(object sender, MouseEventArgs e)
        {
            BackButton.BackColor = Color.DarkOrchid;
        }

        private void Initialize_MouseLeave(object sender, EventArgs e)
        {
            Initialize.BackColor = Color.FromArgb(36, 36, 36);
            Initialize.ForeColor = Color.DeepSkyBlue;
        }

        private void Initialize_MouseEnter(object sender, EventArgs e)
        {
            Initialize.BackColor = Color.DeepSkyBlue;
            Initialize.ForeColor = Color.FromArgb(36, 36, 36);
        }

        private void Initialize_MouseDown(object sender, MouseEventArgs e)
        {
            Initialize.BackColor = Color.DodgerBlue;
        }

        private void Initialize_MouseUp(object sender, MouseEventArgs e)
        {
            Initialize.BackColor = Color.DeepSkyBlue;
        }

        private void OpenConnection_MouseLeave(object sender, EventArgs e)
        {
            OpenConnectionButton.BackColor = Color.FromArgb(36, 36, 36);
            OpenConnectionButton.ForeColor = Color.FromArgb(27, 235, 158);
        }

        private void OpenConnection_MouseEnter(object sender, EventArgs e)
        {
            OpenConnectionButton.BackColor = Color.FromArgb(27, 235, 158);
            OpenConnectionButton.ForeColor = Color.FromArgb(36, 36, 36);
        }

        private void OpenConnection_MouseDown(object sender, MouseEventArgs e)
        {
            OpenConnectionButton.BackColor = Color.FromArgb(29, 143, 101);
        }

        private void OpenConnection_MouseUp(object sender, MouseEventArgs e)
        {
            OpenConnectionButton.BackColor = Color.FromArgb(27, 235, 158);
        }

        private void CloseConnection_MouseLeave(object sender, EventArgs e)
        {
            CloseConnectionButton.BackColor = Color.FromArgb(36, 36, 36);
            CloseConnectionButton.ForeColor = Color.Salmon;
        }

        private void CloseConnection_MouseEnter(object sender, EventArgs e)
        {
            CloseConnectionButton.BackColor = Color.Salmon;
            CloseConnectionButton.ForeColor = Color.FromArgb(36, 36, 36);
        }

        private void CloseConnection_MouseDown(object sender, MouseEventArgs e)
        {
            CloseConnectionButton.BackColor = Color.Coral;
        }

        private void CloseConnection_MouseUp(object sender, MouseEventArgs e)
        {
            CloseConnectionButton.BackColor = Color.Salmon;
        }

        private void CommandButton_MouseLeave(object sender, EventArgs e)
        {
            CommandButton.BackColor = Color.FromArgb(26, 26, 26);
            CommandButton.ForeColor = Color.Gold;
        }

        private void CommandButton_MouseEnter(object sender, EventArgs e)
        {
            CommandButton.BackColor = Color.Gold;
            CommandButton.ForeColor = Color.FromArgb(26, 26, 26);
        }

        private void CommandButton_MouseDown(object sender, MouseEventArgs e)
        {
            CommandButton.BackColor = Color.Goldenrod;
        }

        private void CommandButton_MouseUp(object sender, MouseEventArgs e)
        {
            CommandButton.BackColor = Color.Gold;
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            if (connect != null) connect.Close();
            this.Hide();
            MainLabsHubFrom.Show();
        }

        private void Lab1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void Initialize_Click(object sender, EventArgs e)
        {
            if (connect != null)
            {
                Task.Run(() => { MessageBox.Show("The initialization has already been done!"); });
            }
            else
            {
                string ConnectionString =
                    string.Format("Host={0};Port={1};Username={2};Password={3};Database={4};Pooling=false",
                    Program.host, Program.port, Program.user, Program.pass, Program.dbname);
                connect = new NpgsqlConnection(ConnectionString);

                OpenConnectionButton.Visible = true;
                CloseConnectionButton.Visible = true;
                StatusLabel.Visible = true;
            }
        }

        private void OpenConnectionButton_Click(object sender, EventArgs e)
        {
            try
            {
                connect.Open();
                if (connect.State == ConnectionState.Open)
                {
                    StatusLabel.Text = "{Connection is open}";
                    StatusLabel.TextAlign = ContentAlignment.TopCenter;
                    StatusLabel.ForeColor = Color.FromArgb(27, 235, 158);
                    CommandButton.Visible = true;
                }
            }
            catch (Exception ex)
            {
                Task.Run(() => { MessageBox.Show(ex.Message); });
            }
        }

        private void CloseConnectionButton_Click(object sender, EventArgs e)
        {
            try
            {
                connect.Close();
                if (connect.State == ConnectionState.Closed)
                {
                    StatusLabel.Text = "{Connection is closed}";
                    StatusLabel.TextAlign = ContentAlignment.TopCenter;
                    StatusLabel.ForeColor = Color.Salmon;
                    CommandButton.Visible = false;
                }
            }
            catch(Exception ex)
            {
                Task.Run(() => { MessageBox.Show(ex.Message); });
            }
        }

        private void CommandButton_Click(object sender, EventArgs e)
        {
            try
            {
                Random random = new Random();
                const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
                string RndStr = new string(Enumerable.Repeat(chars, 5)
                    .Select(s => s[random.Next(s.Length)]).ToArray());

                NpgsqlCommand command = new NpgsqlCommand("INSERT INTO data (string) VALUES ($1)", connect)
                {
                    Parameters =
                    {
                        new() { Value = RndStr}
                    }
                };
                command.ExecuteNonQuery();
                Task.Run(() => { MessageBox.Show("Insert is ok"); });
            }
            catch (Exception ex)
            {
                Task.Run(() => { MessageBox.Show(ex.Message); });
            }
        }
    }
}
