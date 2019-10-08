using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Soundboard.Entities.Keybinds;
using Soundboard.Helpers;
using Soundboard.Entities;

namespace Soundboard.Forms.UserControls
{
    public partial class SoundKeybind : UserControl
    {
        private bool settingKeybind = false;
        private Keybind keybind;
        private Sound sound;

        public SoundKeybind()
        {
            InitializeComponent();
        }

        public void SetSoundName(Sound sound)
        {
            this.sound = sound;
            this.SoundName.Text = sound.Name;
        }

        public void SetKeybindText(Keybind bind, string text)
        {
            Keybind.Text = text;
            this.keybind = bind;
        }

        private void Keybind_KeyDown(object sender, KeyEventArgs e)
        {
            if (settingKeybind)
            {
                Keybind.Text = e.KeyCode.ToString();
                settingKeybind = false;

                handleNewKeybind(e);
            }
        }

        private void Keybind_Click(object sender, EventArgs e)
        {
            settingKeybind = true;
        }

        private void handleNewKeybind(KeyEventArgs e)
        {
            // Make new keybind
            GlobalHotkey hotkey = new GlobalHotkey(KeyModifiers.NOMOD, e.KeyCode, this.ParentForm);
            Keybinds.addKeybind(new Keybind(hotkey, this.sound));
            Keybinds.removeKeybind(this.keybind);

            this.Keybind.Text = e.KeyCode.ToString();
        }

        private void PlayButton_Click(object sender, EventArgs e)
        {
            WMPLib.WindowsMediaPlayer wplayer = new WMPLib.WindowsMediaPlayer();

            wplayer.URL = this.sound.SoundFilePath;
            wplayer.controls.play();
        }
    }
}
