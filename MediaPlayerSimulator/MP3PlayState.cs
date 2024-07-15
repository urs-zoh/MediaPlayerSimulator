using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MediaPlayerSimulator
{
    public class MP3PlayState : IMediaPlayerState
    {
        private MediaPlayer mediaPlayer;

        public MP3PlayState(MediaPlayer mediaPlayer)
        {
            this.mediaPlayer = mediaPlayer;
        }

        public void PressPlayButton()
        {
            Console.WriteLine("Stopping music...");
            mediaPlayer.SetState(mediaPlayer.GetMP3PauseState());
        }

        public void PressAudioSourceButton()
        {
            mediaPlayer.SetState(mediaPlayer.GetRadioState());
        }

        public string GetState() => "MP3 Play";

        public void UpdatePlayButton(Button playButton)
        {
            playButton.Enabled = true;
            playButton.Text = "Pause";
        }
    }


}
