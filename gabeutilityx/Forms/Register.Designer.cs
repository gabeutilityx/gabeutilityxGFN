namespace gabeutilityx.Forms
{
    partial class Register
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Register));
            this.loginButton = new Guna.UI2.WinForms.Guna2GradientButton();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.taskbar = new System.Windows.Forms.Panel();
            this.exitButton = new System.Windows.Forms.PictureBox();
            this.Registerlabel = new System.Windows.Forms.Label();
            this.keylabel = new System.Windows.Forms.Label();
            this.keybut = new Guna.UI2.WinForms.Guna2TextBox();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.Password = new Guna.UI2.WinForms.Guna2TextBox();
            this.userlabel = new System.Windows.Forms.Label();
            this.Username = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.guna2ShadowForm1 = new Guna.UI2.WinForms.Guna2ShadowForm(this.components);
            this.taskbar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.exitButton)).BeginInit();
            this.SuspendLayout();
            // 
            // loginButton
            // 
            this.loginButton.Animated = true;
            this.loginButton.AutoRoundedCorners = true;
            this.loginButton.BackColor = System.Drawing.Color.Transparent;
            this.loginButton.BorderRadius = 21;
            this.loginButton.CheckedState.Parent = this.loginButton;
            this.loginButton.CustomImages.Parent = this.loginButton;
            this.loginButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.loginButton.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.loginButton.Font = new System.Drawing.Font("Yu Gothic UI Light", 15F);
            this.loginButton.ForeColor = System.Drawing.Color.White;
            this.loginButton.HoverState.Parent = this.loginButton;
            this.loginButton.Location = new System.Drawing.Point(37, 186);
            this.loginButton.Name = "loginButton";
            this.loginButton.ShadowDecoration.Parent = this.loginButton;
            this.loginButton.Size = new System.Drawing.Size(190, 45);
            this.loginButton.TabIndex = 23;
            this.loginButton.Text = "Register";
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 25;
            this.guna2Elipse1.TargetControl = this;
            // 
            // taskbar
            // 
            this.taskbar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.taskbar.Controls.Add(this.exitButton);
            this.taskbar.Controls.Add(this.Registerlabel);
            this.taskbar.Dock = System.Windows.Forms.DockStyle.Top;
            this.taskbar.Location = new System.Drawing.Point(0, 0);
            this.taskbar.Name = "taskbar";
            this.taskbar.Size = new System.Drawing.Size(281, 23);
            this.taskbar.TabIndex = 16;
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.Color.Transparent;
            this.exitButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("exitButton.BackgroundImage")));
            this.exitButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.exitButton.Location = new System.Drawing.Point(259, 6);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(12, 12);
            this.exitButton.TabIndex = 16;
            this.exitButton.TabStop = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // Registerlabel
            // 
            this.Registerlabel.AutoSize = true;
            this.Registerlabel.BackColor = System.Drawing.Color.Transparent;
            this.Registerlabel.Cursor = System.Windows.Forms.Cursors.Default;
            this.Registerlabel.Font = new System.Drawing.Font("Yu Gothic UI Light", 10.25F);
            this.Registerlabel.ForeColor = System.Drawing.Color.White;
            this.Registerlabel.Location = new System.Drawing.Point(8, 2);
            this.Registerlabel.Name = "Registerlabel";
            this.Registerlabel.Size = new System.Drawing.Size(56, 19);
            this.Registerlabel.TabIndex = 7;
            this.Registerlabel.Text = "Register";
            // 
            // keylabel
            // 
            this.keylabel.AutoSize = true;
            this.keylabel.BackColor = System.Drawing.Color.Transparent;
            this.keylabel.Cursor = System.Windows.Forms.Cursors.Default;
            this.keylabel.Font = new System.Drawing.Font("Yu Gothic UI Light", 10.25F);
            this.keylabel.ForeColor = System.Drawing.Color.White;
            this.keylabel.Location = new System.Drawing.Point(26, 134);
            this.keylabel.Name = "keylabel";
            this.keylabel.Size = new System.Drawing.Size(29, 19);
            this.keylabel.TabIndex = 22;
            this.keylabel.Text = "Key";
            // 
            // keybut
            // 
            this.keybut.Animated = true;
            this.keybut.AutoRoundedCorners = true;
            this.keybut.BackColor = System.Drawing.Color.Transparent;
            this.keybut.BorderRadius = 8;
            this.keybut.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.keybut.DefaultText = "";
            this.keybut.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.keybut.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.keybut.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.keybut.DisabledState.Parent = this.keybut;
            this.keybut.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.keybut.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.keybut.FocusedState.Parent = this.keybut;
            this.keybut.Font = new System.Drawing.Font("Yu Gothic UI Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.keybut.ForeColor = System.Drawing.Color.Black;
            this.keybut.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.keybut.HoverState.Parent = this.keybut;
            this.keybut.IconLeft = ((System.Drawing.Image)(resources.GetObject("keybut.IconLeft")));
            this.keybut.Location = new System.Drawing.Point(28, 154);
            this.keybut.Name = "keybut";
            this.keybut.PasswordChar = '\0';
            this.keybut.PlaceholderForeColor = System.Drawing.Color.Black;
            this.keybut.PlaceholderText = "";
            this.keybut.SelectedText = "";
            this.keybut.ShadowDecoration.Parent = this.keybut;
            this.keybut.Size = new System.Drawing.Size(209, 19);
            this.keybut.TabIndex = 21;
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.BackColor = System.Drawing.Color.Transparent;
            this.PasswordLabel.Cursor = System.Windows.Forms.Cursors.Default;
            this.PasswordLabel.Font = new System.Drawing.Font("Yu Gothic UI Light", 10.25F);
            this.PasswordLabel.ForeColor = System.Drawing.Color.White;
            this.PasswordLabel.Location = new System.Drawing.Point(24, 89);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(64, 19);
            this.PasswordLabel.TabIndex = 20;
            this.PasswordLabel.Text = "Password";
            // 
            // Password
            // 
            this.Password.Animated = true;
            this.Password.AutoRoundedCorners = true;
            this.Password.BackColor = System.Drawing.Color.Transparent;
            this.Password.BorderRadius = 8;
            this.Password.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Password.DefaultText = "";
            this.Password.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.Password.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.Password.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Password.DisabledState.Parent = this.Password;
            this.Password.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Password.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Password.FocusedState.Parent = this.Password;
            this.Password.Font = new System.Drawing.Font("Yu Gothic UI Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Password.ForeColor = System.Drawing.Color.Black;
            this.Password.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Password.HoverState.Parent = this.Password;
            this.Password.IconLeft = ((System.Drawing.Image)(resources.GetObject("Password.IconLeft")));
            this.Password.Location = new System.Drawing.Point(26, 109);
            this.Password.Name = "Password";
            this.Password.PasswordChar = '•';
            this.Password.PlaceholderForeColor = System.Drawing.Color.Black;
            this.Password.PlaceholderText = "";
            this.Password.SelectedText = "";
            this.Password.ShadowDecoration.Parent = this.Password;
            this.Password.Size = new System.Drawing.Size(209, 19);
            this.Password.TabIndex = 19;
            // 
            // userlabel
            // 
            this.userlabel.AutoSize = true;
            this.userlabel.BackColor = System.Drawing.Color.Transparent;
            this.userlabel.Cursor = System.Windows.Forms.Cursors.Default;
            this.userlabel.Font = new System.Drawing.Font("Yu Gothic UI Light", 10.25F);
            this.userlabel.ForeColor = System.Drawing.Color.White;
            this.userlabel.Location = new System.Drawing.Point(23, 41);
            this.userlabel.Name = "userlabel";
            this.userlabel.Size = new System.Drawing.Size(69, 19);
            this.userlabel.TabIndex = 18;
            this.userlabel.Text = "Username";
            // 
            // Username
            // 
            this.Username.Animated = true;
            this.Username.AutoRoundedCorners = true;
            this.Username.BackColor = System.Drawing.Color.Transparent;
            this.Username.BorderRadius = 8;
            this.Username.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Username.DefaultText = "";
            this.Username.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.Username.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.Username.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Username.DisabledState.Parent = this.Username;
            this.Username.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Username.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Username.FocusedState.Parent = this.Username;
            this.Username.Font = new System.Drawing.Font("Yu Gothic UI Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Username.ForeColor = System.Drawing.Color.Black;
            this.Username.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Username.HoverState.Parent = this.Username;
            this.Username.IconLeft = ((System.Drawing.Image)(resources.GetObject("Username.IconLeft")));
            this.Username.Location = new System.Drawing.Point(26, 61);
            this.Username.Name = "Username";
            this.Username.PasswordChar = '\0';
            this.Username.PlaceholderForeColor = System.Drawing.Color.Black;
            this.Username.PlaceholderText = "";
            this.Username.SelectedText = "";
            this.Username.ShadowDecoration.Parent = this.Username;
            this.Username.Size = new System.Drawing.Size(209, 19);
            this.Username.TabIndex = 17;
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.TargetControl = this.taskbar;
            // 
            // guna2ShadowForm1
            // 
            this.guna2ShadowForm1.TargetForm = this;
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(74)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(281, 262);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.taskbar);
            this.Controls.Add(this.keylabel);
            this.Controls.Add(this.keybut);
            this.Controls.Add(this.PasswordLabel);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.userlabel);
            this.Controls.Add(this.Username);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Register";
            this.Text = "Register";
            this.taskbar.ResumeLayout(false);
            this.taskbar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.exitButton)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2GradientButton loginButton;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private System.Windows.Forms.Panel taskbar;
        private System.Windows.Forms.PictureBox exitButton;
        private System.Windows.Forms.Label Registerlabel;
        private System.Windows.Forms.Label keylabel;
        private Guna.UI2.WinForms.Guna2TextBox keybut;
        private System.Windows.Forms.Label PasswordLabel;
        private Guna.UI2.WinForms.Guna2TextBox Password;
        private System.Windows.Forms.Label userlabel;
        private Guna.UI2.WinForms.Guna2TextBox Username;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private Guna.UI2.WinForms.Guna2ShadowForm guna2ShadowForm1;
    }
}