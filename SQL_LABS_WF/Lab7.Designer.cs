
namespace SQL_LABS_WF
{
    partial class Lab7
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Lab7));
            this.panel1 = new System.Windows.Forms.Panel();
            this.RestoreDB = new System.Windows.Forms.Button();
            this.BackupDB = new System.Windows.Forms.Button();
            this.TreeViewButton = new System.Windows.Forms.Button();
            this.FunctionsButton = new System.Windows.Forms.Button();
            this.BackButton = new System.Windows.Forms.Button();
            this.CloseConnectionButton = new System.Windows.Forms.Button();
            this.Initialize = new System.Windows.Forms.Button();
            this.OpenConnectionButton = new System.Windows.Forms.Button();
            this.StatusLabel = new System.Windows.Forms.Label();
            this.InsertButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.ShowButton = new System.Windows.Forms.Button();
            this.OutputField = new System.Windows.Forms.RichTextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.FieldLabel = new System.Windows.Forms.Label();
            this.UpdateButton = new System.Windows.Forms.Button();
            this.dataGridLabel = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.deleteRowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.panel1.Controls.Add(this.RestoreDB);
            this.panel1.Controls.Add(this.BackupDB);
            this.panel1.Controls.Add(this.TreeViewButton);
            this.panel1.Controls.Add(this.FunctionsButton);
            this.panel1.Controls.Add(this.BackButton);
            this.panel1.Controls.Add(this.CloseConnectionButton);
            this.panel1.Controls.Add(this.Initialize);
            this.panel1.Controls.Add(this.OpenConnectionButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(290, 456);
            this.panel1.TabIndex = 0;
            // 
            // RestoreDB
            // 
            this.RestoreDB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.RestoreDB.FlatAppearance.BorderSize = 0;
            this.RestoreDB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RestoreDB.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RestoreDB.ForeColor = System.Drawing.Color.GreenYellow;
            this.RestoreDB.Location = new System.Drawing.Point(24, 336);
            this.RestoreDB.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.RestoreDB.Name = "RestoreDB";
            this.RestoreDB.Size = new System.Drawing.Size(234, 47);
            this.RestoreDB.TabIndex = 11;
            this.RestoreDB.Text = "[Restore]";
            this.RestoreDB.UseVisualStyleBackColor = false;
            this.RestoreDB.Visible = false;
            this.RestoreDB.Click += new System.EventHandler(this.RestoreDB_Click);
            this.RestoreDB.MouseDown += new System.Windows.Forms.MouseEventHandler(this.RestoreDB_MouseDown);
            this.RestoreDB.MouseEnter += new System.EventHandler(this.RestoreDB_MouseEnter);
            this.RestoreDB.MouseLeave += new System.EventHandler(this.RestoreDB_MouseLeave);
            this.RestoreDB.MouseUp += new System.Windows.Forms.MouseEventHandler(this.RestoreDB_MouseUp);
            // 
            // BackupDB
            // 
            this.BackupDB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.BackupDB.FlatAppearance.BorderSize = 0;
            this.BackupDB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BackupDB.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BackupDB.ForeColor = System.Drawing.Color.DodgerBlue;
            this.BackupDB.Location = new System.Drawing.Point(42, 283);
            this.BackupDB.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.BackupDB.Name = "BackupDB";
            this.BackupDB.Size = new System.Drawing.Size(198, 47);
            this.BackupDB.TabIndex = 10;
            this.BackupDB.Text = "[Backup]";
            this.BackupDB.UseVisualStyleBackColor = false;
            this.BackupDB.Visible = false;
            this.BackupDB.Click += new System.EventHandler(this.BackupDB_Click);
            this.BackupDB.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BackupDB_MouseDown);
            this.BackupDB.MouseEnter += new System.EventHandler(this.BackupDB_MouseEnter);
            this.BackupDB.MouseLeave += new System.EventHandler(this.BackupDB_MouseLeave);
            this.BackupDB.MouseUp += new System.Windows.Forms.MouseEventHandler(this.BackupDB_MouseUp);
            // 
            // TreeViewButton
            // 
            this.TreeViewButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.TreeViewButton.FlatAppearance.BorderSize = 0;
            this.TreeViewButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TreeViewButton.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TreeViewButton.ForeColor = System.Drawing.Color.DeepPink;
            this.TreeViewButton.Location = new System.Drawing.Point(68, 230);
            this.TreeViewButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TreeViewButton.Name = "TreeViewButton";
            this.TreeViewButton.Size = new System.Drawing.Size(150, 47);
            this.TreeViewButton.TabIndex = 9;
            this.TreeViewButton.Text = "[TreeView]";
            this.TreeViewButton.UseVisualStyleBackColor = false;
            this.TreeViewButton.Visible = false;
            this.TreeViewButton.Click += new System.EventHandler(this.TreeViewButton_Click);
            this.TreeViewButton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TreeViewButton_MouseDown);
            this.TreeViewButton.MouseEnter += new System.EventHandler(this.TreeViewButton_MouseEnter);
            this.TreeViewButton.MouseLeave += new System.EventHandler(this.TreeViewButton_MouseLeave);
            this.TreeViewButton.MouseUp += new System.Windows.Forms.MouseEventHandler(this.TreeViewButton_MouseUp);
            // 
            // FunctionsButton
            // 
            this.FunctionsButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.FunctionsButton.FlatAppearance.BorderSize = 0;
            this.FunctionsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FunctionsButton.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FunctionsButton.ForeColor = System.Drawing.Color.DarkOrange;
            this.FunctionsButton.Location = new System.Drawing.Point(68, 175);
            this.FunctionsButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.FunctionsButton.Name = "FunctionsButton";
            this.FunctionsButton.Size = new System.Drawing.Size(150, 47);
            this.FunctionsButton.TabIndex = 8;
            this.FunctionsButton.Text = "[Functions]";
            this.FunctionsButton.UseVisualStyleBackColor = false;
            this.FunctionsButton.Visible = false;
            this.FunctionsButton.Click += new System.EventHandler(this.FunctionsButton_Click);
            this.FunctionsButton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FunctionsButton_MouseDown);
            this.FunctionsButton.MouseEnter += new System.EventHandler(this.FunctionsButton_MouseEnter);
            this.FunctionsButton.MouseLeave += new System.EventHandler(this.FunctionsButton_MouseLeave);
            this.FunctionsButton.MouseUp += new System.Windows.Forms.MouseEventHandler(this.FunctionsButton_MouseUp);
            // 
            // BackButton
            // 
            this.BackButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.BackButton.FlatAppearance.BorderSize = 0;
            this.BackButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BackButton.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BackButton.ForeColor = System.Drawing.Color.DarkOrchid;
            this.BackButton.Location = new System.Drawing.Point(88, 397);
            this.BackButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(105, 47);
            this.BackButton.TabIndex = 1;
            this.BackButton.Text = "[Back]";
            this.BackButton.UseVisualStyleBackColor = false;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            this.BackButton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BackButton_MouseDown);
            this.BackButton.MouseEnter += new System.EventHandler(this.BackButton_MouseEnter);
            this.BackButton.MouseLeave += new System.EventHandler(this.BackButton_MouseLeave);
            this.BackButton.MouseUp += new System.Windows.Forms.MouseEventHandler(this.BackButton_MouseUp);
            // 
            // CloseConnectionButton
            // 
            this.CloseConnectionButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.CloseConnectionButton.FlatAppearance.BorderSize = 0;
            this.CloseConnectionButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseConnectionButton.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CloseConnectionButton.ForeColor = System.Drawing.Color.Salmon;
            this.CloseConnectionButton.Location = new System.Drawing.Point(8, 122);
            this.CloseConnectionButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.CloseConnectionButton.Name = "CloseConnectionButton";
            this.CloseConnectionButton.Size = new System.Drawing.Size(273, 47);
            this.CloseConnectionButton.TabIndex = 4;
            this.CloseConnectionButton.Text = "[Close connection]";
            this.CloseConnectionButton.UseVisualStyleBackColor = false;
            this.CloseConnectionButton.Visible = false;
            this.CloseConnectionButton.Click += new System.EventHandler(this.CloseConnectionButton_Click);
            this.CloseConnectionButton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.CloseConnection_MouseDown);
            this.CloseConnectionButton.MouseEnter += new System.EventHandler(this.CloseConnection_MouseEnter);
            this.CloseConnectionButton.MouseLeave += new System.EventHandler(this.CloseConnection_MouseLeave);
            this.CloseConnectionButton.MouseUp += new System.Windows.Forms.MouseEventHandler(this.CloseConnection_MouseUp);
            // 
            // Initialize
            // 
            this.Initialize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.Initialize.FlatAppearance.BorderSize = 0;
            this.Initialize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Initialize.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Initialize.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.Initialize.Location = new System.Drawing.Point(51, 14);
            this.Initialize.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Initialize.Name = "Initialize";
            this.Initialize.Size = new System.Drawing.Size(189, 47);
            this.Initialize.TabIndex = 3;
            this.Initialize.Text = "[Initialize]";
            this.Initialize.UseVisualStyleBackColor = false;
            this.Initialize.Click += new System.EventHandler(this.Initialize_Click);
            this.Initialize.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Initialize_MouseDown);
            this.Initialize.MouseEnter += new System.EventHandler(this.Initialize_MouseEnter);
            this.Initialize.MouseLeave += new System.EventHandler(this.Initialize_MouseLeave);
            this.Initialize.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Initialize_MouseUp);
            // 
            // OpenConnectionButton
            // 
            this.OpenConnectionButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.OpenConnectionButton.FlatAppearance.BorderSize = 0;
            this.OpenConnectionButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OpenConnectionButton.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.OpenConnectionButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(235)))), ((int)(((byte)(158)))));
            this.OpenConnectionButton.Location = new System.Drawing.Point(8, 68);
            this.OpenConnectionButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.OpenConnectionButton.Name = "OpenConnectionButton";
            this.OpenConnectionButton.Size = new System.Drawing.Size(273, 47);
            this.OpenConnectionButton.TabIndex = 2;
            this.OpenConnectionButton.Text = "[Open connection]";
            this.OpenConnectionButton.UseVisualStyleBackColor = false;
            this.OpenConnectionButton.Visible = false;
            this.OpenConnectionButton.Click += new System.EventHandler(this.OpenConnectionButton_Click);
            this.OpenConnectionButton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.OpenConnection_MouseDown);
            this.OpenConnectionButton.MouseEnter += new System.EventHandler(this.OpenConnection_MouseEnter);
            this.OpenConnectionButton.MouseLeave += new System.EventHandler(this.OpenConnection_MouseLeave);
            this.OpenConnectionButton.MouseUp += new System.Windows.Forms.MouseEventHandler(this.OpenConnection_MouseUp);
            // 
            // StatusLabel
            // 
            this.StatusLabel.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.StatusLabel.ForeColor = System.Drawing.Color.DimGray;
            this.StatusLabel.Location = new System.Drawing.Point(463, 32);
            this.StatusLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(241, 29);
            this.StatusLabel.TabIndex = 3;
            this.StatusLabel.Text = "{Status}";
            this.StatusLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.StatusLabel.Visible = false;
            // 
            // InsertButton
            // 
            this.InsertButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.InsertButton.FlatAppearance.BorderSize = 0;
            this.InsertButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.InsertButton.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.InsertButton.ForeColor = System.Drawing.Color.Gold;
            this.InsertButton.Location = new System.Drawing.Point(308, 72);
            this.InsertButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.InsertButton.Name = "InsertButton";
            this.InsertButton.Size = new System.Drawing.Size(127, 47);
            this.InsertButton.TabIndex = 4;
            this.InsertButton.Text = "[Insert]";
            this.InsertButton.UseVisualStyleBackColor = false;
            this.InsertButton.Visible = false;
            this.InsertButton.Click += new System.EventHandler(this.InsertButton_Click);
            this.InsertButton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.CommandButton_MouseDown);
            this.InsertButton.MouseEnter += new System.EventHandler(this.CommandButton_MouseEnter);
            this.InsertButton.MouseLeave += new System.EventHandler(this.CommandButton_MouseLeave);
            this.InsertButton.MouseUp += new System.Windows.Forms.MouseEventHandler(this.CommandButton_MouseUp);
            // 
            // DeleteButton
            // 
            this.DeleteButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.DeleteButton.FlatAppearance.BorderSize = 0;
            this.DeleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteButton.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DeleteButton.ForeColor = System.Drawing.Color.Gold;
            this.DeleteButton.Location = new System.Drawing.Point(578, 72);
            this.DeleteButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(127, 47);
            this.DeleteButton.TabIndex = 5;
            this.DeleteButton.Text = "[Delete]";
            this.DeleteButton.UseVisualStyleBackColor = false;
            this.DeleteButton.Visible = false;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            this.DeleteButton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.CommandButton_MouseDown);
            this.DeleteButton.MouseEnter += new System.EventHandler(this.CommandButton_MouseEnter);
            this.DeleteButton.MouseLeave += new System.EventHandler(this.CommandButton_MouseLeave);
            this.DeleteButton.MouseUp += new System.Windows.Forms.MouseEventHandler(this.CommandButton_MouseUp);
            // 
            // ShowButton
            // 
            this.ShowButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.ShowButton.FlatAppearance.BorderSize = 0;
            this.ShowButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ShowButton.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ShowButton.ForeColor = System.Drawing.Color.Gold;
            this.ShowButton.Location = new System.Drawing.Point(443, 72);
            this.ShowButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ShowButton.Name = "ShowButton";
            this.ShowButton.Size = new System.Drawing.Size(127, 47);
            this.ShowButton.TabIndex = 6;
            this.ShowButton.Text = "[Show]";
            this.ShowButton.UseVisualStyleBackColor = false;
            this.ShowButton.Visible = false;
            this.ShowButton.Click += new System.EventHandler(this.ShowButton_Click);
            this.ShowButton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.CommandButton_MouseDown);
            this.ShowButton.MouseEnter += new System.EventHandler(this.CommandButton_MouseEnter);
            this.ShowButton.MouseLeave += new System.EventHandler(this.CommandButton_MouseLeave);
            this.ShowButton.MouseUp += new System.Windows.Forms.MouseEventHandler(this.CommandButton_MouseUp);
            // 
            // OutputField
            // 
            this.OutputField.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.OutputField.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.OutputField.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.OutputField.ForeColor = System.Drawing.Color.Gold;
            this.OutputField.Location = new System.Drawing.Point(383, 158);
            this.OutputField.Name = "OutputField";
            this.OutputField.Size = new System.Drawing.Size(397, 56);
            this.OutputField.TabIndex = 7;
            this.OutputField.Text = "";
            this.OutputField.Visible = false;
            this.OutputField.Click += new System.EventHandler(this.OutputField_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.dataGridView1.Location = new System.Drawing.Point(383, 261);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(397, 168);
            this.dataGridView1.TabIndex = 8;
            this.dataGridView1.Visible = false;
            this.dataGridView1.CellMouseUp += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseUp);
            this.dataGridView1.Paint += new System.Windows.Forms.PaintEventHandler(this.dataGridView1_Paint);
            // 
            // FieldLabel
            // 
            this.FieldLabel.AutoSize = true;
            this.FieldLabel.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FieldLabel.ForeColor = System.Drawing.Color.White;
            this.FieldLabel.Location = new System.Drawing.Point(383, 129);
            this.FieldLabel.Name = "FieldLabel";
            this.FieldLabel.Size = new System.Drawing.Size(351, 19);
            this.FieldLabel.TabIndex = 9;
            this.FieldLabel.Text = "Enter string to insert or id to delete";
            this.FieldLabel.Visible = false;
            // 
            // UpdateButton
            // 
            this.UpdateButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.UpdateButton.FlatAppearance.BorderSize = 0;
            this.UpdateButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UpdateButton.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.UpdateButton.ForeColor = System.Drawing.Color.Gold;
            this.UpdateButton.Location = new System.Drawing.Point(713, 72);
            this.UpdateButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(127, 47);
            this.UpdateButton.TabIndex = 10;
            this.UpdateButton.Text = "[Update]";
            this.UpdateButton.UseVisualStyleBackColor = false;
            this.UpdateButton.Visible = false;
            this.UpdateButton.Click += new System.EventHandler(this.UpdateButton_Click);
            this.UpdateButton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.CommandButton_MouseDown);
            this.UpdateButton.MouseEnter += new System.EventHandler(this.CommandButton_MouseEnter);
            this.UpdateButton.MouseLeave += new System.EventHandler(this.CommandButton_MouseLeave);
            this.UpdateButton.MouseUp += new System.Windows.Forms.MouseEventHandler(this.CommandButton_MouseUp);
            // 
            // dataGridLabel
            // 
            this.dataGridLabel.AutoSize = true;
            this.dataGridLabel.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dataGridLabel.ForeColor = System.Drawing.Color.White;
            this.dataGridLabel.Location = new System.Drawing.Point(383, 230);
            this.dataGridLabel.Name = "dataGridLabel";
            this.dataGridLabel.Size = new System.Drawing.Size(81, 19);
            this.dataGridLabel.TabIndex = 11;
            this.dataGridLabel.Text = "DataGrid";
            this.dataGridLabel.Visible = false;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleteRowToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(131, 26);
            // 
            // deleteRowToolStripMenuItem
            // 
            this.deleteRowToolStripMenuItem.Name = "deleteRowToolStripMenuItem";
            this.deleteRowToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.deleteRowToolStripMenuItem.Text = "Delete row";
            this.deleteRowToolStripMenuItem.Click += new System.EventHandler(this.deleteRowToolStripMenuItem_Click);
            // 
            // treeView1
            // 
            this.treeView1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.treeView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.treeView1.Dock = System.Windows.Forms.DockStyle.Right;
            this.treeView1.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.treeView1.ForeColor = System.Drawing.Color.White;
            this.treeView1.LineColor = System.Drawing.Color.DeepPink;
            this.treeView1.Location = new System.Drawing.Point(859, 0);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(201, 456);
            this.treeView1.TabIndex = 12;
            this.treeView1.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeView1_NodeMouseDoubleClick);
            // 
            // Lab7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.ClientSize = new System.Drawing.Size(1060, 456);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.dataGridLabel);
            this.Controls.Add(this.UpdateButton);
            this.Controls.Add(this.FieldLabel);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.OutputField);
            this.Controls.Add(this.ShowButton);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.InsertButton);
            this.Controls.Add(this.StatusLabel);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Lab7";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lab7";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Lab3_FormClosing);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Button CloseConnectionButton;
        private System.Windows.Forms.Button Initialize;
        private System.Windows.Forms.Button OpenConnectionButton;
        private System.Windows.Forms.Label StatusLabel;
        private System.Windows.Forms.Button InsertButton;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button ShowButton;
        private System.Windows.Forms.RichTextBox OutputField;
        private System.Windows.Forms.Button FunctionsButton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label FieldLabel;
        private System.Windows.Forms.Button UpdateButton;
        private System.Windows.Forms.Label dataGridLabel;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem deleteRowToolStripMenuItem;
        private System.Windows.Forms.Button TreeViewButton;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Button RestoreDB;
        private System.Windows.Forms.Button BackupDB;
    }
}