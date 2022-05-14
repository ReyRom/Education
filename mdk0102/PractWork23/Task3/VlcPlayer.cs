using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class VlcPlayer : IAdvancedMediaPlayer
    {
        public void PlayMp4(string fileName)
        {
            //do nothing
        }

        public void PlayVlc(string fileName)
        {
            Console.WriteLine("Playing vlc file.Name: " + fileName);
        }
    }
}
