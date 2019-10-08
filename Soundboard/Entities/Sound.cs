using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soundboard.Entities
{
    public class Sound
    {
        public string Name { get; set; }

        public string SoundFilePath { get; set; }

        public Sound(string name, string filePath)
        {
            this.Name = name;
            this.SoundFilePath = filePath;
        }
    }
}
