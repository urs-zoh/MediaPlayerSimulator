using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MediaPlayerSimulator
{
    public class StandbyState : IMediaPlayerState
    {
        private MediaPlayer mediaPlayer;

        public StandbyState(MediaPlayer mediaPlayer)
        {
            this.mediaPlayer = mediaPlayer;
        }

        public void PressPlayButton()
        {
            // No effect in Standby state
        }

        public void PressAudioSourceButton()
        {
            mediaPlayer.SetState(mediaPlayer.GetMP3PlayState());
        }

        public string GetState() => "Standby";

        public void UpdatePlayButton(Button playButton)
        {
            playButton.Enabled = false;
            playButton.Text = "Play";
        }
    }

}
