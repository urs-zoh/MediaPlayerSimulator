using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MediaPlayerSimulator
{
    public class RadioState : IMediaPlayerState
    {
        private MediaPlayer mediaPlayer;

        public RadioState(MediaPlayer mediaPlayer)
        {
            this.mediaPlayer = mediaPlayer;
        }

        public void PressPlayButton()
        {
            Console.WriteLine("Tuning next radio station...");
        }

        public void PressAudioSourceButton()
        {
            mediaPlayer.SetState(mediaPlayer.GetStandbyState());
        }

        public string GetState() => "Radio";

        public void UpdatePlayButton(Button playButton)
        {
            playButton.Enabled = false;
            playButton.Text = "Play";
        }
    }


}
