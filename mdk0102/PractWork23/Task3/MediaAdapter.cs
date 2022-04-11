using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class MediaAdapter : IMediaPlayer
    {
        IAdvancedMediaPlayer advancedMusicPlayer;

        public MediaAdapter(string audioType)
        {

            if (audioType.Equals("vlc",StringComparison.InvariantCultureIgnoreCase))
            {
                advancedMusicPlayer = new VlcPlayer();
            }
            else if (audioType.Equals("mp4", StringComparison.InvariantCultureIgnoreCase))
            {
                advancedMusicPlayer = new Mp4Player();
            }
        }
        public void Play(string audioType, string fileName)
        {
            if (audioType.Equals("vlc", StringComparison.InvariantCultureIgnoreCase))
            {
                advancedMusicPlayer.PlayVlc(fileName);
            }
            else if (audioType.Equals("mp4", StringComparison.InvariantCultureIgnoreCase))
            {
                advancedMusicPlayer.PlayMp4(fileName);
            }
        }
    }
}
