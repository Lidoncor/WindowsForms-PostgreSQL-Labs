
namespace SQL_LABS_WF
{
    partial class Lab1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Lab1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.BackButton = new System.Windows.Forms.Button();
            this.CloseConnectionButton = new System.Windows.Forms.Button();
            this.Initialize = new System.Windows.Forms.Button();
            this.OpenConnectionButton = new System.Windows.Forms.Button();
            this.StatusLabel = new System.Windows.Forms.Label();
            this.CommandButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
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
            // BackButton
            // 
            this.BackButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.BackButton.FlatAppearance.BorderSize = 0;
            this.BackButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BackButton.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BackButton.ForeColor = System.Drawing.Color.DarkOrchid;
            this.BackButton.Location = new System.Drawing.Point(90, 369);
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
            this.StatusLabel.Location = new System.Drawing.Point(485, 32);
            this.StatusLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(241, 29);
            this.StatusLabel.TabIndex = 3;
            this.StatusLabel.Text = "{Status}";
            this.StatusLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.StatusLabel.Visible = false;
            // 
            // CommandButton
            // 
            this.CommandButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.CommandButton.FlatAppearance.BorderSize = 0;
            this.CommandButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CommandButton.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CommandButton.ForeColor = System.Drawing.Color.Gold;
            this.CommandButton.Location = new System.Drawing.Point(539, 203);
            this.CommandButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.CommandButton.Name = "CommandButton";
            this.CommandButton.Size = new System.Drawing.Size(127, 47);
            this.CommandButton.TabIndex = 4;
            this.CommandButton.Text = "[Command]";
            this.CommandButton.UseVisualStyleBackColor = false;
            this.CommandButton.Visible = false;
            this.CommandButton.Click += new System.EventHandler(this.CommandButton_Click);
            this.CommandButton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.CommandButton_MouseDown);
            this.CommandButton.MouseEnter += new System.EventHandler(this.CommandButton_MouseEnter);
            this.CommandButton.MouseLeave += new System.EventHandler(this.CommandButton_MouseLeave);
            this.CommandButton.MouseUp += new System.Windows.Forms.MouseEventHandler(this.CommandButton_MouseUp);
            // 
            // Lab1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.ClientSize = new System.Drawing.Size(886, 456);
            this.Controls.Add(this.CommandButton);
            this.Controls.Add(this.StatusLabel);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Lab1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lab1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Lab1_FormClosing);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Button CloseConnectionButton;
        private System.Windows.Forms.Button Initialize;
        private System.Windows.Forms.Button OpenConnectionButton;
        private System.Windows.Forms.Label StatusLabel;
        private System.Windows.Forms.Button CommandButton;
    }
}