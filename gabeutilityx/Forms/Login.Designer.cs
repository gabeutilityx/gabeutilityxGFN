namespace gabeutilityx
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.Taskbar = new System.Windows.Forms.Panel();
            this.exitButton = new System.Windows.Forms.PictureBox();
            this.register = new System.Windows.Forms.Label();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.UsernameLabel = new System.Windows.Forms.Label();
            this.Logo = new System.Windows.Forms.PictureBox();
            this.Elipse = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.Shadow = new Guna.UI2.WinForms.Guna2ShadowForm(this.components);
            this.Drag = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.Animate = new Guna.UI2.WinForms.Guna2AnimateWindow(this.components);
            this.Username = new Guna.UI2.WinForms.Guna2TextBox();
            this.Password = new Guna.UI2.WinForms.Guna2TextBox();
            this.loginbutton = new Guna.UI2.WinForms.Guna2Button();
            this.Taskbar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.exitButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            this.SuspendLayout();
            // 
            // Taskbar
            // 
            this.Taskbar.BackColor = System.Drawing.Color.Transparent;
            this.Taskbar.Controls.Add(this.exitButton);
            this.Taskbar.Dock = System.Windows.Forms.DockStyle.Top;
            this.Taskbar.Location = new System.Drawing.Point(0, 0);
            this.Taskbar.Name = "Taskbar";
            this.Taskbar.Size = new System.Drawing.Size(800, 25);
            this.Taskbar.TabIndex = 14;
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.Color.Transparent;
            this.exitButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("exitButton.BackgroundImage")));
            this.exitButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.exitButton.Location = new System.Drawing.Point(779, 7);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(12, 12);
            this.exitButton.TabIndex = 1;
            this.exitButton.TabStop = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // register
            // 
            this.register.AutoSize = true;
            this.register.BackColor = System.Drawing.Color.Transparent;
            this.register.Cursor = System.Windows.Forms.Cursors.Default;
            this.register.Font = new System.Drawing.Font("Yu Gothic UI Light", 10.25F);
            this.register.ForeColor = System.Drawing.Color.White;
            this.register.Location = new System.Drawing.Point(8, 423);
            this.register.Name = "register";
            this.register.Size = new System.Drawing.Size(56, 19);
            this.register.TabIndex = 18;
            this.register.Text = "Register";
            this.register.Click += new System.EventHandler(this.register_Click);
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.BackColor = System.Drawing.Color.Transparent;
            this.PasswordLabel.Cursor = System.Windows.Forms.Cursors.Default;
            this.PasswordLabel.Font = new System.Drawing.Font("Yu Gothic UI Light", 10.25F);
            this.PasswordLabel.ForeColor = System.Drawing.Color.White;
            this.PasswordLabel.Location = new System.Drawing.Point(295, 263);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(64, 19);
            this.PasswordLabel.TabIndex = 17;
            this.PasswordLabel.Text = "Password";
            // 
            // UsernameLabel
            // 
            this.UsernameLabel.AutoSize = true;
            this.UsernameLabel.BackColor = System.Drawing.Color.Transparent;
            this.UsernameLabel.Cursor = System.Windows.Forms.Cursors.Default;
            this.UsernameLabel.Font = new System.Drawing.Font("Yu Gothic UI Light", 10.25F);
            this.UsernameLabel.ForeColor = System.Drawing.Color.White;
            this.UsernameLabel.Location = new System.Drawing.Point(294, 215);
            this.UsernameLabel.Name = "UsernameLabel";
            this.UsernameLabel.Size = new System.Drawing.Size(69, 19);
            this.UsernameLabel.TabIndex = 16;
            this.UsernameLabel.Text = "Username";
            // 
            // Logo
            // 
            this.Logo.BackColor = System.Drawing.Color.Transparent;
            this.Logo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Logo.BackgroundImage")));
            this.Logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Logo.Location = new System.Drawing.Point(6, 112);
            this.Logo.Margin = new System.Windows.Forms.Padding(0);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(800, 88);
            this.Logo.TabIndex = 15;
            this.Logo.TabStop = false;
            // 
            // Elipse
            // 
            this.Elipse.BorderRadius = 25;
            this.Elipse.TargetControl = this;
            // 
            // Shadow
            // 
            this.Shadow.TargetForm = this;
            // 
            // Drag
            // 
            this.Drag.TargetControl = this.Taskbar;
            // 
            // Animate
            // 
            this.Animate.AnimationType = Guna.UI2.WinForms.Guna2AnimateWindow.AnimateWindowType.AW_BLEND;
            this.Animate.TargetForm = this;
            // 
            // Username
            // 
            this.Username.Animated = true;
            this.Username.AutoRoundedCorners = true;
            this.Username.BackColor = System.Drawing.Color.Transparent;
            this.Username.BorderRadius = 9;
            this.Username.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Username.DefaultText = "";
            this.Username.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.Username.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.Username.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Username.DisabledState.Parent = this.Username;
            this.Username.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Username.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Username.FocusedState.Parent = this.Username;
            this.Username.Font = new System.Drawing.Font("Yu Gothic UI Light", 9.25F);
            this.Username.ForeColor = System.Drawing.Color.Black;
            this.Username.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Username.HoverState.Parent = this.Username;
            this.Username.IconLeft = ((System.Drawing.Image)(resources.GetObject("Username.IconLeft")));
            this.Username.Location = new System.Drawing.Point(299, 237);
            this.Username.Name = "Username";
            this.Username.PasswordChar = '\0';
            this.Username.PlaceholderText = "";
            this.Username.SelectedText = "";
            this.Username.ShadowDecoration.Enabled = true;
            this.Username.ShadowDecoration.Parent = this.Username;
            this.Username.Size = new System.Drawing.Size(218, 21);
            this.Username.TabIndex = 19;
            this.Username.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Username_KeyUp);
            // 
            // Password
            // 
            this.Password.Animated = true;
            this.Password.AutoRoundedCorners = true;
            this.Password.BackColor = System.Drawing.Color.Transparent;
            this.Password.BorderRadius = 9;
            this.Password.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Password.DefaultText = "";
            this.Password.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.Password.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.Password.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Password.DisabledState.Parent = this.Password;
            this.Password.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Password.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Password.FocusedState.Parent = this.Password;
            this.Password.Font = new System.Drawing.Font("Yu Gothic UI Light", 9.25F);
            this.Password.ForeColor = System.Drawing.Color.Black;
            this.Password.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Password.HoverState.Parent = this.Password;
            this.Password.IconLeft = ((System.Drawing.Image)(resources.GetObject("Password.IconLeft")));
            this.Password.Location = new System.Drawing.Point(299, 285);
            this.Password.Name = "Password";
            this.Password.PasswordChar = '•';
            this.Password.PlaceholderText = "";
            this.Password.SelectedText = "";
            this.Password.ShadowDecoration.Enabled = true;
            this.Password.ShadowDecoration.Parent = this.Password;
            this.Password.Size = new System.Drawing.Size(218, 21);
            this.Password.TabIndex = 20;
            this.Password.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Password_KeyUp);
            // 
            // loginbutton
            // 
            this.loginbutton.Animated = true;
            this.loginbutton.AutoRoundedCorners = true;
            this.loginbutton.BackColor = System.Drawing.Color.Transparent;
            this.loginbutton.BorderColor = System.Drawing.Color.Transparent;
            this.loginbutton.BorderRadius = 21;
            this.loginbutton.CheckedState.Parent = this.loginbutton;
            this.loginbutton.CustomImages.Parent = this.loginbutton;
            this.loginbutton.FillColor = System.Drawing.Color.RoyalBlue;
            this.loginbutton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.loginbutton.ForeColor = System.Drawing.Color.White;
            this.loginbutton.HoverState.Parent = this.loginbutton;
            this.loginbutton.Location = new System.Drawing.Point(314, 340);
            this.loginbutton.Name = "loginbutton";
            this.loginbutton.ShadowDecoration.Parent = this.loginbutton;
            this.loginbutton.Size = new System.Drawing.Size(180, 45);
            this.loginbutton.TabIndex = 21;
            this.loginbutton.Text = "Login";
            this.loginbutton.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.loginbutton);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.Username);
            this.Controls.Add(this.register);
            this.Controls.Add(this.PasswordLabel);
            this.Controls.Add(this.UsernameLabel);
            this.Controls.Add(this.Logo);
            this.Controls.Add(this.Taskbar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Login";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.Taskbar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.exitButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel Taskbar;
        private System.Windows.Forms.PictureBox exitButton;
        private System.Windows.Forms.Label register;
        private System.Windows.Forms.Label PasswordLabel;
        private System.Windows.Forms.Label UsernameLabel;
        private System.Windows.Forms.PictureBox Logo;
        private Guna.UI2.WinForms.Guna2Elipse Elipse;
        private Guna.UI2.WinForms.Guna2TextBox Username;
        private Guna.UI2.WinForms.Guna2ShadowForm Shadow;
        private Guna.UI2.WinForms.Guna2DragControl Drag;
        private Guna.UI2.WinForms.Guna2AnimateWindow Animate;
        private Guna.UI2.WinForms.Guna2TextBox Password;
        private Guna.UI2.WinForms.Guna2Button loginbutton;
    }
}

