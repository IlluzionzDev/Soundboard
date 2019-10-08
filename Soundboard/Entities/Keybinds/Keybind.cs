using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soundboard.Entities.Keybinds
{
    public class Keybind
    {
        public GlobalHotkey keyBind { get; set; }

        public Sound Sound { get; set; }

        public Keybind(GlobalHotkey key, Sound sound)
        {
            this.keyBind = key;
            this.Sound = sound;

            key.Register(); // Self register in keybind
        }

    }
}
