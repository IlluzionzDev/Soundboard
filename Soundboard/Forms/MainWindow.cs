using Soundboard.Entities.Keybinds;
using Soundboard.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Soundboard
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();

            Keybinds.registerKeybinds(this);
        }

        // Handle keybinds
        protected override void WndProc(ref Message m)
        {
            Keybinds.handleKeybinds(m);
            base.WndProc(ref m);
        }

        // Handle window dragging
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        private void Toolbar_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void Title_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        public UserControl openUserControl = new Forms.UserControls.Home();
        private Color selectedColor = Color.FromArgb(22, 23, 28);
        private Color unSelectedColor = Color.FromArgb(24, 30, 36);

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Environment.Exit(1);
        }

        private void MinimizeButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        /**
         * Handles browsing through the UserControls by setting colours 
         */

        private void HomeButton_MouseDown(object sender, MouseEventArgs e)
        {
            this.HomeBG.BackColor = selectedColor;
            this.ProfileBG.BackColor = unSelectedColor;
            this.SettingsBG.BackColor = unSelectedColor;
        }

        private void ProfileButton_MouseDown(object sender, MouseEventArgs e)
        {
            this.HomeBG.BackColor = unSelectedColor;
            this.ProfileBG.BackColor = selectedColor;
            this.SettingsBG.BackColor = unSelectedColor;
        }

        private void SettingsButton_MouseDown(object sender, MouseEventArgs e)
        {
            this.HomeBG.BackColor = unSelectedColor;
            this.ProfileBG.BackColor = unSelectedColor;
            this.SettingsBG.BackColor = selectedColor;
        }
    }
}
