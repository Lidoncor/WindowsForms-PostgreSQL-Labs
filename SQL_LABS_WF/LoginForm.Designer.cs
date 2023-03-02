
namespace SQL_LABS_WF
{
    partial class LoginForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.NextButton = new System.Windows.Forms.Button();
            this.Host_box = new System.Windows.Forms.TextBox();
            this.Port_box = new System.Windows.Forms.TextBox();
            this.dbname_box = new System.Windows.Forms.TextBox();
            this.Username_box = new System.Windows.Forms.TextBox();
            this.Password_box = new System.Windows.Forms.TextBox();
            this.Host_label = new System.Windows.Forms.Label();
            this.Port_label = new System.Windows.Forms.Label();
            this.dbname_label = new System.Windows.Forms.Label();
            this.Username_label = new System.Windows.Forms.Label();
            this.Password_label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // NextButton
            // 
            this.NextButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.NextButton.FlatAppearance.BorderSize = 0;
            this.NextButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NextButton.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.NextButton.ForeColor = System.Drawing.Color.DarkOrchid;
            this.NextButton.Location = new System.Drawing.Point(177, 372);
            this.NextButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.NextButton.Name = "NextButton";
            this.NextButton.Size = new System.Drawing.Size(105, 47);
            this.NextButton.TabIndex = 0;
            this.NextButton.Text = "[Next]";
            this.NextButton.UseVisualStyleBackColor = false;
            this.NextButton.Click += new System.EventHandler(this.NextButton_Click);
            this.NextButton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.NextButton_MouseDown);
            this.NextButton.MouseEnter += new System.EventHandler(this.NextButton_MouseEnter);
            this.NextButton.MouseLeave += new System.EventHandler(this.NextButton_MouseLeave);
            this.NextButton.MouseUp += new System.Windows.Forms.MouseEventHandler(this.NextButton_MouseUp);
            // 
            // Host_box
            // 
            this.Host_box.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.Host_box.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Host_box.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.Host_box.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(235)))), ((int)(((byte)(158)))));
            this.Host_box.Location = new System.Drawing.Point(177, 63);
            this.Host_box.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Host_box.Name = "Host_box";
            this.Host_box.Size = new System.Drawing.Size(117, 19);
            this.Host_box.TabIndex = 1;
            this.Host_box.Text = "127.0.0.1";
            // 
            // Port_box
            // 
            this.Port_box.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.Port_box.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Port_box.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.Port_box.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(235)))), ((int)(((byte)(158)))));
            this.Port_box.Location = new System.Drawing.Point(177, 120);
            this.Port_box.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Port_box.Name = "Port_box";
            this.Port_box.Size = new System.Drawing.Size(117, 19);
            this.Port_box.TabIndex = 2;
            this.Port_box.Text = "5432";
            // 
            // dbname_box
            // 
            this.dbname_box.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.dbname_box.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dbname_box.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.dbname_box.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(235)))), ((int)(((byte)(158)))));
            this.dbname_box.Location = new System.Drawing.Point(177, 180);
            this.dbname_box.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dbname_box.Name = "dbname_box";
            this.dbname_box.Size = new System.Drawing.Size(117, 19);
            this.dbname_box.TabIndex = 3;
            this.dbname_box.Text = "WFlabs";
            // 
            // Username_box
            // 
            this.Username_box.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.Username_box.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Username_box.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.Username_box.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(235)))), ((int)(((byte)(158)))));
            this.Username_box.Location = new System.Drawing.Point(177, 241);
            this.Username_box.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Username_box.Name = "Username_box";
            this.Username_box.Size = new System.Drawing.Size(117, 19);
            this.Username_box.TabIndex = 4;
            this.Username_box.Text = "wfadmin";
            // 
            // Password_box
            // 
            this.Password_box.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.Password_box.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Password_box.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.Password_box.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(235)))), ((int)(((byte)(158)))));
            this.Password_box.Location = new System.Drawing.Point(177, 305);
            this.Password_box.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Password_box.Name = "Password_box";
            this.Password_box.Size = new System.Drawing.Size(117, 19);
            this.Password_box.TabIndex = 5;
            this.Password_box.Text = "123";
            this.Password_box.UseSystemPasswordChar = true;
            // 
            // Host_label
            // 
            this.Host_label.AutoSize = true;
            this.Host_label.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Host_label.ForeColor = System.Drawing.Color.Yellow;
            this.Host_label.Location = new System.Drawing.Point(174, 43);
            this.Host_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Host_label.Name = "Host_label";
            this.Host_label.Size = new System.Drawing.Size(35, 15);
            this.Host_label.TabIndex = 6;
            this.Host_label.Text = "Host";
            // 
            // Port_label
            // 
            this.Port_label.AutoSize = true;
            this.Port_label.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Port_label.ForeColor = System.Drawing.Color.Yellow;
            this.Port_label.Location = new System.Drawing.Point(174, 99);
            this.Port_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Port_label.Name = "Port_label";
            this.Port_label.Size = new System.Drawing.Size(35, 15);
            this.Port_label.TabIndex = 7;
            this.Port_label.Text = "Port";
            // 
            // dbname_label
            // 
            this.dbname_label.AutoSize = true;
            this.dbname_label.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dbname_label.ForeColor = System.Drawing.Color.Yellow;
            this.dbname_label.Location = new System.Drawing.Point(174, 159);
            this.dbname_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.dbname_label.Name = "dbname_label";
            this.dbname_label.Size = new System.Drawing.Size(98, 15);
            this.dbname_label.TabIndex = 8;
            this.dbname_label.Text = "Database name";
            // 
            // Username_label
            // 
            this.Username_label.AutoSize = true;
            this.Username_label.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Username_label.ForeColor = System.Drawing.Color.Yellow;
            this.Username_label.Location = new System.Drawing.Point(174, 220);
            this.Username_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Username_label.Name = "Username_label";
            this.Username_label.Size = new System.Drawing.Size(63, 15);
            this.Username_label.TabIndex = 9;
            this.Username_label.Text = "Username";
            // 
            // Password_label
            // 
            this.Password_label.AutoSize = true;
            this.Password_label.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Password_label.ForeColor = System.Drawing.Color.Yellow;
            this.Password_label.Location = new System.Drawing.Point(174, 284);
            this.Password_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Password_label.Name = "Password_label";
            this.Password_label.Size = new System.Drawing.Size(63, 15);
            this.Password_label.TabIndex = 10;
            this.Password_label.Text = "Password";
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.ClientSize = new System.Drawing.Size(483, 457);
            this.Controls.Add(this.Password_label);
            this.Controls.Add(this.Username_label);
            this.Controls.Add(this.dbname_label);
            this.Controls.Add(this.Port_label);
            this.Controls.Add(this.Host_label);
            this.Controls.Add(this.Password_box);
            this.Controls.Add(this.Username_box);
            this.Controls.Add(this.dbname_box);
            this.Controls.Add(this.Port_box);
            this.Controls.Add(this.Host_box);
            this.Controls.Add(this.NextButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button NextButton;
        private System.Windows.Forms.TextBox Host_box;
        private System.Windows.Forms.TextBox Port_box;
        private System.Windows.Forms.TextBox dbname_box;
        private System.Windows.Forms.TextBox Username_box;
        private System.Windows.Forms.TextBox Password_box;
        private System.Windows.Forms.Label Host_label;
        private System.Windows.Forms.Label Port_label;
        private System.Windows.Forms.Label dbname_label;
        private System.Windows.Forms.Label Username_label;
        private System.Windows.Forms.Label Password_label;
    }
}

