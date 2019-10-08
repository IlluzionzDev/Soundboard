namespace Soundboard
{
    partial class MainWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.Sidebar = new System.Windows.Forms.Panel();
            this.SettingsBG = new System.Windows.Forms.Panel();
            this.SettingsButton = new System.Windows.Forms.Button();
            this.ProfileBG = new System.Windows.Forms.Panel();
            this.ProfileButton = new System.Windows.Forms.Button();
            this.HomeBG = new System.Windows.Forms.Panel();
            this.HomeButton = new System.Windows.Forms.Button();
            this.MinimizeButton = new System.Windows.Forms.Button();
            this.CloseButton = new System.Windows.Forms.Button();
            this.Title = new System.Windows.Forms.Label();
            this.Toolbar = new System.Windows.Forms.Panel();
            this.HomePanel = new Soundboard.Forms.UserControls.Home();
            this.Sidebar.SuspendLayout();
            this.SettingsBG.SuspendLayout();
            this.ProfileBG.SuspendLayout();
            this.HomeBG.SuspendLayout();
            this.Toolbar.SuspendLayout();
            this.SuspendLayout();
            // 
            // Sidebar
            // 
            this.Sidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(36)))));
            this.Sidebar.Controls.Add(this.SettingsBG);
            this.Sidebar.Controls.Add(this.ProfileBG);
            this.Sidebar.Controls.Add(this.HomeBG);
            this.Sidebar.Location = new System.Drawing.Point(0, 0);
            this.Sidebar.Name = "Sidebar";
            this.Sidebar.Size = new System.Drawing.Size(50, 700);
            this.Sidebar.TabIndex = 5;
            // 
            // SettingsBG
            // 
            this.SettingsBG.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(36)))));
            this.SettingsBG.Controls.Add(this.SettingsButton);
            this.SettingsBG.Location = new System.Drawing.Point(0, 98);
            this.SettingsBG.Name = "SettingsBG";
            this.SettingsBG.Size = new System.Drawing.Size(50, 50);
            this.SettingsBG.TabIndex = 9;
            // 
            // SettingsButton
            // 
            this.SettingsButton.BackgroundImage = global::Soundboard.Properties.Resources.settings;
            this.SettingsButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.SettingsButton.FlatAppearance.BorderSize = 0;
            this.SettingsButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.SettingsButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.SettingsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SettingsButton.Location = new System.Drawing.Point(12, 12);
            this.SettingsButton.Name = "SettingsButton";
            this.SettingsButton.Size = new System.Drawing.Size(25, 25);
            this.SettingsButton.TabIndex = 3;
            this.SettingsButton.UseVisualStyleBackColor = true;
            this.SettingsButton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.SettingsButton_MouseDown);
            // 
            // ProfileBG
            // 
            this.ProfileBG.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(36)))));
            this.ProfileBG.Controls.Add(this.ProfileButton);
            this.ProfileBG.Location = new System.Drawing.Point(0, 49);
            this.ProfileBG.Name = "ProfileBG";
            this.ProfileBG.Size = new System.Drawing.Size(50, 50);
            this.ProfileBG.TabIndex = 8;
            // 
            // ProfileButton
            // 
            this.ProfileButton.BackgroundImage = global::Soundboard.Properties.Resources.profile;
            this.ProfileButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ProfileButton.FlatAppearance.BorderSize = 0;
            this.ProfileButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.ProfileButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.ProfileButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ProfileButton.Location = new System.Drawing.Point(12, 12);
            this.ProfileButton.Name = "ProfileButton";
            this.ProfileButton.Size = new System.Drawing.Size(25, 25);
            this.ProfileButton.TabIndex = 3;
            this.ProfileButton.UseVisualStyleBackColor = true;
            this.ProfileButton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ProfileButton_MouseDown);
            // 
            // HomeBG
            // 
            this.HomeBG.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(23)))), ((int)(((byte)(28)))));
            this.HomeBG.Controls.Add(this.HomeButton);
            this.HomeBG.Location = new System.Drawing.Point(0, 0);
            this.HomeBG.Name = "HomeBG";
            this.HomeBG.Size = new System.Drawing.Size(50, 50);
            this.HomeBG.TabIndex = 7;
            // 
            // HomeButton
            // 
            this.HomeButton.BackgroundImage = global::Soundboard.Properties.Resources.home;
            this.HomeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.HomeButton.FlatAppearance.BorderSize = 0;
            this.HomeButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.HomeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.HomeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HomeButton.Location = new System.Drawing.Point(12, 12);
            this.HomeButton.Name = "HomeButton";
            this.HomeButton.Size = new System.Drawing.Size(25, 25);
            this.HomeButton.TabIndex = 3;
            this.HomeButton.UseVisualStyleBackColor = true;
            this.HomeButton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.HomeButton_MouseDown);
            // 
            // MinimizeButton
            // 
            this.MinimizeButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("MinimizeButton.BackgroundImage")));
            this.MinimizeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.MinimizeButton.FlatAppearance.BorderSize = 0;
            this.MinimizeButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.MinimizeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.MinimizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MinimizeButton.Location = new System.Drawing.Point(1140, 8);
            this.MinimizeButton.Name = "MinimizeButton";
            this.MinimizeButton.Size = new System.Drawing.Size(15, 15);
            this.MinimizeButton.TabIndex = 3;
            this.MinimizeButton.UseVisualStyleBackColor = true;
            this.MinimizeButton.Click += new System.EventHandler(this.MinimizeButton_Click);
            // 
            // CloseButton
            // 
            this.CloseButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("CloseButton.BackgroundImage")));
            this.CloseButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CloseButton.FlatAppearance.BorderSize = 0;
            this.CloseButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.CloseButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.CloseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseButton.Location = new System.Drawing.Point(1170, 8);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(15, 15);
            this.CloseButton.TabIndex = 2;
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Raleway", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.Location = new System.Drawing.Point(500, 9);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(100, 15);
            this.Title.TabIndex = 7;
            this.Title.Text = "SOUNDBOARD";
            this.Title.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Title_MouseDown);
            // 
            // Toolbar
            // 
            this.Toolbar.Controls.Add(this.Title);
            this.Toolbar.Location = new System.Drawing.Point(49, 0);
            this.Toolbar.Name = "Toolbar";
            this.Toolbar.Size = new System.Drawing.Size(1078, 32);
            this.Toolbar.TabIndex = 8;
            this.Toolbar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Toolbar_MouseDown);
            // 
            // HomePanel
            // 
            this.HomePanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.HomePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(23)))), ((int)(((byte)(28)))));
            this.HomePanel.Location = new System.Drawing.Point(49, 33);
            this.HomePanel.Name = "HomePanel";
            this.HomePanel.Size = new System.Drawing.Size(1150, 663);
            this.HomePanel.TabIndex = 6;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(23)))), ((int)(((byte)(28)))));
            this.ClientSize = new System.Drawing.Size(1200, 700);
            this.Controls.Add(this.Toolbar);
            this.Controls.Add(this.HomePanel);
            this.Controls.Add(this.Sidebar);
            this.Controls.Add(this.MinimizeButton);
            this.Controls.Add(this.CloseButton);
            this.Font = new System.Drawing.Font("Raleway", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Soundboard";
            this.Sidebar.ResumeLayout(false);
            this.SettingsBG.ResumeLayout(false);
            this.ProfileBG.ResumeLayout(false);
            this.HomeBG.ResumeLayout(false);
            this.Toolbar.ResumeLayout(false);
            this.Toolbar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.Button MinimizeButton;
        private System.Windows.Forms.Panel Sidebar;
        private Forms.UserControls.Home HomePanel;
        private System.Windows.Forms.Button HomeButton;
        private System.Windows.Forms.Panel HomeBG;
        private System.Windows.Forms.Panel ProfileBG;
        private System.Windows.Forms.Button ProfileButton;
        private System.Windows.Forms.Panel SettingsBG;
        private System.Windows.Forms.Button SettingsButton;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Panel Toolbar;
    }
}

