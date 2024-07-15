using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MediaPlayerSimulator
{
    public class MP3PauseState : IMediaPlayerState
    {
        private MediaPlayer mediaPlayer;

        public MP3PauseState(MediaPlayer mediaPlayer)
        {
            this.mediaPlayer = mediaPlayer;
        }

        public void PressPlayButton()
        {
            Console.WriteLine("Starting music...");
            mediaPlayer.SetState(mediaPlayer.GetMP3PlayState());
        }

        public void PressAudioSourceButton()
        {
            mediaPlayer.SetState(mediaPlayer.GetRadioState());
        }

        public string GetState() => "MP3 Pause";

        public void UpdatePlayButton(Button playButton)
        {
            playButton.Enabled = true;
            playButton.Text = "Play";
        }
    }


}
