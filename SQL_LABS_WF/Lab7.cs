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
using Npgsql;
using System.Diagnostics;
using System.IO;

namespace SQL_LABS_WF
{
    public partial class Lab7 : Form
    {
        private NpgsqlConnection connect;
        private string inputStr;
        
        private DataSet dataSet = new DataSet();
        private DataTable dataTable = new DataTable();
        private NpgsqlDataAdapter adapter;
        
        private DataSet TreeDataSet;
        private NpgsqlDataAdapter TreeAdapter;
        
        private int rowIndex = 0;

        public Lab7()
        {
            InitializeComponent();
        }

        private LabsHub MainLabsHubFrom = null;
        public Lab7(Form CallingForm)
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

        private void BackupDB_MouseUp(object sender, MouseEventArgs e)
        {
            BackupDB.BackColor = Color.DodgerBlue;
        }

        private void BackupDB_MouseLeave(object sender, EventArgs e)
        {
            BackupDB.BackColor = Color.FromArgb(36, 36, 36);
            BackupDB.ForeColor = Color.DodgerBlue;
        }

        private void BackupDB_MouseEnter(object sender, EventArgs e)
        {
            BackupDB.BackColor = Color.DodgerBlue;
            BackupDB.ForeColor = Color.FromArgb(36, 36, 36);
        }

        private void BackupDB_MouseDown(object sender, MouseEventArgs e)
        {
            BackupDB.BackColor = Color.SteelBlue;
        }

        private void RestoreDB_MouseUp(object sender, MouseEventArgs e)
        {
            RestoreDB.BackColor = Color.GreenYellow;
        }

        private void RestoreDB_MouseLeave(object sender, EventArgs e)
        {
            RestoreDB.BackColor = Color.FromArgb(36, 36, 36);
            RestoreDB.ForeColor = Color.GreenYellow;
        }

        private void RestoreDB_MouseEnter(object sender, EventArgs e)
        {
            RestoreDB.BackColor = Color.GreenYellow;
            RestoreDB.ForeColor = Color.FromArgb(36, 36, 36);
        }

        private void RestoreDB_MouseDown(object sender, MouseEventArgs e)
        {
            RestoreDB.BackColor = Color.YellowGreen;
        }

        private void CloseConnection_MouseUp(object sender, MouseEventArgs e)
        {
            CloseConnectionButton.BackColor = Color.Salmon;
        }

        private void CommandButton_MouseLeave(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (btn != null)
            {
                btn.BackColor = Color.FromArgb(26, 26, 26);
                btn.ForeColor = Color.Gold;
            }
        }

        private void CommandButton_MouseEnter(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (btn != null)
            {
                btn.BackColor = Color.Gold;
                btn.ForeColor = Color.FromArgb(26, 26, 26);
            }
        }

        private void CommandButton_MouseDown(object sender, MouseEventArgs e)
        {
            Button btn = sender as Button;
            if (btn != null)
            {
                btn.BackColor = Color.Goldenrod;
            }
        }

        private void CommandButton_MouseUp(object sender, MouseEventArgs e)
        {
            Button btn = sender as Button;
            if (btn != null)
            {
                btn.BackColor = Color.Gold;
            }
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            if (connect != null) connect.Close();
            this.Hide();
            MainLabsHubFrom.Show();
        }

        private void Lab3_FormClosing(object sender, FormClosingEventArgs e)
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
                    InsertButton.Visible = true;
                    DeleteButton.Visible = true;
                    ShowButton.Visible = true;
                    OutputField.Visible = true;
                    FieldLabel.Visible = true;
                    dataGridView1.Visible = true;
                    FunctionsButton.Visible = true;
                    UpdateButton.Visible = true;
                    dataGridLabel.Visible = true;
                    TreeViewButton.Visible = true;
                    BackupDB.Visible = true;
                    RestoreDB.Visible = true;
                    dataGridLabel.ForeColor = Color.White;
                    dataGridLabel.Text = "DataGrid";
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
                    InsertButton.Visible = false;
                    DeleteButton.Visible = false;
                    ShowButton.Visible = false;
                    OutputField.Visible = false;
                    FieldLabel.Visible = false;
                    dataGridView1.Visible = false;
                    FunctionsButton.Visible = false;
                    UpdateButton.Visible = false;
                    dataGridLabel.Visible = false;
                    dataGridView1.DataSource = null;
                    TreeViewButton.Visible = false;
                    BackupDB.Visible = false;
                    RestoreDB.Visible = false;
                    dataGridView1.Rows.Clear();
                    dataGridView1.Columns.Clear();
                    dataGridView1.Refresh();
                    dataSet.Reset();
                    OutputField.Text = "";
                    treeView1.Nodes.Clear();
                }
            }
            catch (Exception ex)
            {
                Task.Run(() => { MessageBox.Show(ex.Message); });
            }
        }

        private void InsertButton_Click(object sender, EventArgs e)
        {
            if (OutputField.Text == "")
            {
                FieldLabel.ForeColor = Color.Salmon;
                FieldLabel.Text = "The input field is empty.";
                return;
            }

            inputStr = OutputField.Text;
            OutputField.Text = "";
            try
            {
                NpgsqlCommand command = new NpgsqlCommand("select wf_insert($1)", connect)
                {
                    Parameters =
                    {
                        new() { Value = inputStr}
                    }
                };
                command.ExecuteNonQuery();
                FieldLabel.ForeColor = Color.FromArgb(27, 235, 158);
                FieldLabel.Text = "Insert is ok.";
            }
            catch (Exception)
            {
                FieldLabel.ForeColor = Color.Salmon;
                FieldLabel.Text = "Insert is not completed.";
            }
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (OutputField.Text == "")
            {
                FieldLabel.ForeColor = Color.Salmon;
                FieldLabel.Text = "The input field is empty.";
                return;
            }

            inputStr = OutputField.Text;
            OutputField.Text = "";

            object result = 0;
            try
            {
                NpgsqlCommand command = new NpgsqlCommand("select wf_delete($1)", connect)
                {
                    Parameters =
                {
                    new() { Value = Int32.Parse(inputStr)}
                }
                };
                result = command.ExecuteScalar();
            }
            catch (Exception ex)
            {
                FieldLabel.ForeColor = Color.Salmon;
                FieldLabel.Text = ex.Message;
                return;
            }

            if ((int)result != 0)
            {
                FieldLabel.ForeColor = Color.FromArgb(27, 235, 158);
                FieldLabel.Text = "Delete is ok.";
            }
            else
            {
                FieldLabel.ForeColor = Color.Salmon;
                FieldLabel.Text = "Delete is not completed.";
            }
        }

        private void ShowButton_Click(object sender, EventArgs e)
        {
            dataGridView1.ReadOnly = false;
            string sqlQuery = "SELECT * FROM data";
            adapter = new NpgsqlDataAdapter(sqlQuery, connect);

            dataGridLabel.ForeColor = Color.White;
            dataGridLabel.Text = "Select or change cells to update.";

            dataGridView1.DataSource = null;
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();
            dataGridView1.Refresh();
            dataSet.Reset();

            adapter.Fill(dataSet);
            dataTable = dataSet.Tables[0];
            if (dataTable.Rows.Count != 0)
            {
                dataGridView1.DataSource = dataTable;
                dataGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
        }

        private void OutputField_Click(object sender, EventArgs e)
        {
            FieldLabel.ForeColor = Color.White;
            FieldLabel.Text = "Enter string to insert or id to delete";
        }

        private void FunctionsButton_MouseLeave(object sender, EventArgs e)
        {
            FunctionsButton.BackColor = Color.FromArgb(36, 36, 36);
            FunctionsButton.ForeColor = Color.DarkOrange;
        }

        private void FunctionsButton_MouseEnter(object sender, EventArgs e)
        {
            FunctionsButton.BackColor = Color.DarkOrange;
            FunctionsButton.ForeColor = Color.FromArgb(36, 36, 36);
        }

        private void FunctionsButton_MouseDown(object sender, MouseEventArgs e)
        {
            FunctionsButton.BackColor = Color.FromArgb(196, 65, 0);
        }

        private void FunctionsButton_MouseUp(object sender, MouseEventArgs e)
        {
            FunctionsButton.BackColor = Color.DarkOrange;
        }

        private void TreeViewButton_MouseLeave(object sender, EventArgs e)
        {
            TreeViewButton.BackColor = Color.FromArgb(36, 36, 36);
            TreeViewButton.ForeColor = Color.DeepPink;
        }

        private void TreeViewButton_MouseEnter(object sender, EventArgs e)
        {
            TreeViewButton.BackColor = Color.DeepPink;
            TreeViewButton.ForeColor = Color.FromArgb(36, 36, 36);
        }

        private void TreeViewButton_MouseDown(object sender, MouseEventArgs e)
        {
            TreeViewButton.BackColor = Color.MediumVioletRed;
        }

        private void TreeViewButton_MouseUp(object sender, MouseEventArgs e)
        {
            TreeViewButton.BackColor = Color.DeepPink;
        }

        private void FunctionsButton_Click(object sender, EventArgs e)
        {
            string sqlQuery = @"SELECT routine_name 
                                FROM information_schema.routines 
                                WHERE routine_type = 'FUNCTION' 
                                AND routine_schema = 'public'";

            adapter = new NpgsqlDataAdapter(sqlQuery, connect);

            dataGridLabel.ForeColor = Color.DarkOrange;
            dataGridLabel.Text = "Functions ReadOnly mode.";

            dataGridView1.ReadOnly = true;
            dataGridView1.DataSource = null;
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();
            dataGridView1.Refresh();
            
            dataSet.Reset();

            adapter.Fill(dataSet);
            dataTable = dataSet.Tables[0];
            if (dataTable.Rows.Count != 0)
            {
                dataGridView1.DataSource = dataTable;
                dataGridView1.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
        }

        private void dataGridView1_Paint(object sender, PaintEventArgs e)
        {
            if (dataGridView1.Rows.Count == 0)
                TextRenderer.DrawText(e.Graphics, "No data.",
                    dataGridView1.Font, dataGridView1.ClientRectangle,
                    Color.White, dataGridView1.BackgroundColor,
                    TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter);
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            if (dataTable.Rows.Count != 0)
            {
                try
                {
                    DataTable changes = new DataTable();
                    DataTable DelChanges = new DataTable();
                    changes = dataTable.GetChanges(DataRowState.Modified);
                    DelChanges = dataTable.GetChanges(DataRowState.Deleted);

                    adapter.UpdateCommand = new NpgsqlCommandBuilder(adapter).GetUpdateCommand();
                    adapter.Update(dataTable);

                    if (changes != null)
                    {
                        dataGridLabel.Text = "Update is ok. Changed rows:";
                        dataGridLabel.ForeColor = Color.FromArgb(27, 235, 158);
                        dataGridView1.DataSource = changes;
                        dataGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    }
                    else if (DelChanges != null)
                    {
                        dataGridLabel.Text = "Update is ok.";
                        dataGridLabel.ForeColor = Color.FromArgb(27, 235, 158);
                    }
                    else
                    {
                        dataGridLabel.ForeColor = Color.White;
                        dataGridLabel.Text = "Select or change cells to update.";
                    }
                }
                catch (Exception ex)
                {
                    dataGridLabel.Text = "Update error.";
                    dataGridLabel.ForeColor = Color.Salmon;
                }
            }
            else
            {
                dataGridLabel.Text = "DataGrid has no data to update.";
                dataGridLabel.ForeColor = Color.Salmon;
            }
        }

        private void dataGridView1_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right && dataGridView1.ReadOnly == false)
            {
                dataGridView1.Rows[e.RowIndex].Selected = true;
                rowIndex = e.RowIndex;
                dataGridView1.CurrentCell = dataGridView1.Rows[e.RowIndex].Cells[1];
                contextMenuStrip1.Show(this.dataGridView1, e.Location);
                contextMenuStrip1.Show(Cursor.Position);
            }
        }

        private void deleteRowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!dataGridView1.Rows[this.rowIndex].IsNewRow)
            {
                dataGridView1.Rows.RemoveAt(this.rowIndex);
            }
        }

        private void TreeViewButton_Click(object sender, EventArgs e)
        {
            string sqlQuery = "SELECT datname FROM pg_database WHERE datistemplate=false";
            TreeAdapter = new NpgsqlDataAdapter(sqlQuery, connect);

            TreeDataSet = new DataSet();

            treeView1.Nodes.Clear();
            TreeAdapter.Fill(TreeDataSet);

            if (TreeDataSet.Tables.Count > 0)
            {
                foreach (DataRow row in TreeDataSet.Tables[0].Rows)
                {
                    TreeNode NewNode = new TreeNode(row[0].ToString());
                    treeView1.Nodes.Add(NewNode);
                }
            }
        }

        private void treeView1_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {           
            if (e.Node.Parent == null)
            {
                connect.ChangeDatabase(e.Node.Text);
                DataTable dbTables = connect.GetSchema("Tables");

                if (dbTables.Rows.Count > 0)
                {
                    foreach (DataRow row in dbTables.Rows)
                    {
                        TreeNode NewNode = new TreeNode(row["table_name"].ToString());
                        treeView1.Nodes[e.Node.Index].Nodes.Add(NewNode);
                    }
                }
            }
            else
            {
                connect.ChangeDatabase(e.Node.Parent.Text);
                string sqlQuery = "SELECT * FROM " + e.Node.Text;
                NpgsqlCommand command = new NpgsqlCommand(sqlQuery, connect);

                TreeAdapter = new NpgsqlDataAdapter(command);

                dataGridLabel.ForeColor = Color.DeepPink;
                dataGridLabel.Text = "TreeView ReadOnly mode.";

                dataGridView1.ReadOnly = true;
                dataGridView1.DataSource = null;
                dataGridView1.Rows.Clear();
                dataGridView1.Columns.Clear();
                dataGridView1.Refresh();
                TreeDataSet.Reset();

                TreeAdapter.Fill(TreeDataSet);
                DataTable TreeDataTable = new DataTable();
                TreeDataTable = TreeDataSet.Tables[0];
                if (TreeDataTable.Rows.Count != 0)
                {
                    dataGridView1.DataSource = TreeDataTable;
                    dataGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                }
            }
            connect.ChangeDatabase("WFlabs");
        }

        private void BackupDB_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "SQL (*.sql)|*.sql";
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    string path = Path.GetFullPath(sfd.FileName);
                    System.Diagnostics.Process process = new System.Diagnostics.Process();
                    process.StartInfo.FileName = "cmd.exe";
                    process.StartInfo.UseShellExecute = true;
                    process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                    process.StartInfo.Arguments = "/c pg_dump -U postgres -h localhost -Fc -C -d WFlabs > " + path;
                    process.Start();
                    process.WaitForExit();
                    MessageBox.Show("Backup is complete");
                } 
            }
            catch (Exception ex)
            {
                Task.Run(() => { MessageBox.Show(ex.Message); });
            }
        }

        private void RestoreDB_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog ofd = new OpenFileDialog();
                ofd.Filter = "SQL (*.sql)|*.sql";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    string filePath = ofd.FileName;
                    System.Diagnostics.Process process = new System.Diagnostics.Process();
                    process.StartInfo.FileName = "cmd.exe";
                    process.StartInfo.UseShellExecute = true;
                    process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                    process.StartInfo.Arguments = "/c pg_restore -U postgres -h localhost -c -d WFlabs < " + filePath;
                    process.Start();
                    process.WaitForExit();
                    MessageBox.Show("Restore is complete");
                }
            }
            catch (Exception ex)
            {
                Task.Run(() => { MessageBox.Show(ex.Message); });
            }
        }
    }
}
