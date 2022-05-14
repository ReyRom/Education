using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class AudioPlayer : IMediaPlayer
    {
        MediaAdapter mediaAdapter;
        public void Play(string audioType, string fileName)
        {
            if (audioType.Equals("mp3", StringComparison.InvariantCultureIgnoreCase))
            {
                Console.WriteLine("Playing mp3 file. Name: " + fileName);
            }

            else if (audioType.Equals("vlc", StringComparison.InvariantCultureIgnoreCase) || audioType.Equals("mp4", StringComparison.InvariantCultureIgnoreCase))
            {
                mediaAdapter = new MediaAdapter(audioType);
                mediaAdapter.Play(audioType, fileName);
            }

            else
            {
                Console.WriteLine("Invalid media. " + audioType + " format not supported");
            }
        }
    }
}
