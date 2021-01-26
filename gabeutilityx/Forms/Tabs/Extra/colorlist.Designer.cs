namespace gabeutilityx.Forms.Tabs.Extra
{
    partial class colorlist
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(colorlist));
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.Taskbar = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.TaskbarLabel = new System.Windows.Forms.Label();
            this.exitButton = new System.Windows.Forms.PictureBox();
            this.Elipse = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.Draggable = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.Shadow = new Guna.UI2.WinForms.Guna2ShadowForm(this.components);
            this.Animate = new Guna.UI2.WinForms.Guna2AnimateWindow(this.components);
            this.Taskbar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.exitButton)).BeginInit();
            this.SuspendLayout();
            // 
            // webBrowser1
            // 
            this.webBrowser1.AllowNavigation = false;
            this.webBrowser1.AllowWebBrowserDrop = false;
            this.webBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser1.IsWebBrowserContextMenuEnabled = false;
            this.webBrowser1.Location = new System.Drawing.Point(0, 25);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.ScriptErrorsSuppressed = true;
            this.webBrowser1.Size = new System.Drawing.Size(800, 425);
            this.webBrowser1.TabIndex = 5;
            this.webBrowser1.Url = new System.Uri("https://www.99colors.net/dot-net-colors", System.UriKind.Absolute);
            this.webBrowser1.WebBrowserShortcutsEnabled = false;
            // 
            // Taskbar
            // 
            this.Taskbar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.Taskbar.Controls.Add(this.panel2);
            this.Taskbar.Controls.Add(this.TaskbarLabel);
            this.Taskbar.Controls.Add(this.exitButton);
            this.Taskbar.Dock = System.Windows.Forms.DockStyle.Top;
            this.Taskbar.Location = new System.Drawing.Point(0, 0);
            this.Taskbar.Name = "Taskbar";
            this.Taskbar.Size = new System.Drawing.Size(800, 25);
            this.Taskbar.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(180, 24);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(10, 100);
            this.panel2.TabIndex = 27;
            // 
            // TaskbarLabel
            // 
            this.TaskbarLabel.AutoSize = true;
            this.TaskbarLabel.BackColor = System.Drawing.Color.Transparent;
            this.TaskbarLabel.Cursor = System.Windows.Forms.Cursors.Default;
            this.TaskbarLabel.Font = new System.Drawing.Font("Yu Gothic UI Light", 10.25F);
            this.TaskbarLabel.ForeColor = System.Drawing.Color.White;
            this.TaskbarLabel.Location = new System.Drawing.Point(7, 2);
            this.TaskbarLabel.Name = "TaskbarLabel";
            this.TaskbarLabel.Size = new System.Drawing.Size(47, 19);
            this.TaskbarLabel.TabIndex = 7;
            this.TaskbarLabel.Text = "Colors";
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.Color.Transparent;
            this.exitButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("exitButton.BackgroundImage")));
            this.exitButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.exitButton.Location = new System.Drawing.Point(778, 7);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(12, 12);
            this.exitButton.TabIndex = 1;
            this.exitButton.TabStop = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // Elipse
            // 
            this.Elipse.BorderRadius = 25;
            this.Elipse.TargetControl = this;
            // 
            // Draggable
            // 
            this.Draggable.TargetControl = this.Taskbar;
            // 
            // Shadow
            // 
            this.Shadow.TargetForm = this;
            // 
            // Animate
            // 
            this.Animate.AnimationType = Guna.UI2.WinForms.Guna2AnimateWindow.AnimateWindowType.AW_BLEND;
            this.Animate.TargetForm = this;
            // 
            // colorlist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.Taskbar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "colorlist";
            this.Text = "colorlist";
            this.Taskbar.ResumeLayout(false);
            this.Taskbar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.exitButton)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.Panel Taskbar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label TaskbarLabel;
        private System.Windows.Forms.PictureBox exitButton;
        private Guna.UI2.WinForms.Guna2Elipse Elipse;
        private Guna.UI2.WinForms.Guna2DragControl Draggable;
        private Guna.UI2.WinForms.Guna2ShadowForm Shadow;
        private Guna.UI2.WinForms.Guna2AnimateWindow Animate;
    }
}