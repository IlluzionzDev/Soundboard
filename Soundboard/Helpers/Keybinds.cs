using Soundboard.Entities;
using Soundboard.Entities.Keybinds;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Soundboard.Helpers
{
    class Keybinds
    {
        public static Dictionary<int, Keybind> binds = new Dictionary<int, Keybind>();

        public static void addKeybind(Keybind bind)
        {
            binds.Add(bind.keyBind.GetHashCode(), bind);
        }

        public static void removeKeybind(Keybind bind)
        {
            binds.Remove(bind.keyBind.GetHashCode());
        }

        public static void registerKeybinds(Form form)
        {
            //GlobalHotkey ghk = new GlobalHotkey(KeyModifiers.NOMOD, Keys.NumPad2, form);
            //Keybinds.addKeybind(new Keybind(ghk, new Sound("Yeetism", "C:/noy")));
        }

        public static void handleKeybinds(Message m)
        {
            foreach (KeyValuePair<int, Keybind> pair in Keybinds.binds)
            {
                Keybind bind = pair.Value; // The keybind

                if (m.Msg == KeyModifiers.WM_HOTKEY_MSG_ID)
                {
                    // Check if a keybind exists, then run code
                    if (m.WParam.ToInt32() == bind.keyBind.GetHashCode())
                    {
                        // Play sounds here etc
                        string filePath = bind.Sound.SoundFilePath;

                        WMPLib.WindowsMediaPlayer wplayer = new WMPLib.WindowsMediaPlayer();

                        wplayer.URL = filePath;
                        wplayer.controls.play();
                    }
                }
            }
        }
    }
}
