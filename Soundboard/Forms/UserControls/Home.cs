using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Soundboard.Helpers;
using Soundboard.Entities.Keybinds;
using Soundboard.Entities;
using System.Media;
using System.Security;

namespace Soundboard.Forms.UserControls
{
    public partial class Home : UserControl
    {
        bool settingKeybind = false;
        private OpenFileDialog soundFile; // The file we are playing sound from
        private string soundPath = ""; // Current sound path

        public Home()
        {
            InitializeComponent();

            soundFile = new OpenFileDialog()
            {
                FileName = "Sound file",
                Filter = "Sound files (*.mp3)|*.mp3",
                Title = "Open sound file"
            };
        }

        // Handle setting keybinds
        private void KeybindInput_KeyDown(object sender, KeyEventArgs e)
        {
            if (settingKeybind)
            {
                settingKeybind = false;
                handleNewKeybind(e);
            }
        }

        private void KeybindInput_Click(object sender, EventArgs e)
        {
            settingKeybind = true;
        }

        private void handleNewKeybind(KeyEventArgs e)
        {
            // Make new keybind
            GlobalHotkey hotkey = new GlobalHotkey(KeyModifiers.NOMOD, e.KeyCode, this.ParentForm);

            string soundName = KeybindName.Text;
            Sound sound = new Sound(soundName, this.soundPath);
            Keybind bind = new Keybind(hotkey, sound);
            Keybinds.addKeybind(bind);

            SoundKeybind panel = new SoundKeybind();
            panel.SetSoundName(sound);
            panel.SetKeybindText(bind, e.KeyCode.ToString());
            SoundKeybinds.Controls.Add(panel);
        }

        private void FileButton_Click(object sender, EventArgs e)
        {
            if (soundFile.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    var filePath = soundFile.FileName;
                    this.soundPath = filePath;
                    this.KeybindName.Text = soundFile.FileName;
                }
                catch (SecurityException ex)
                {
                    MessageBox.Show($"Security error.\n\nError message: {ex.Message}\n\n" +
                    $"Details:\n\n{ex.StackTrace}");
                }
            }
        }
    }
}
