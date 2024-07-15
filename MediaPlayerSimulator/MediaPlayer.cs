using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MediaPlayerSimulator
{
    public class MediaPlayer
    {
        private IMediaPlayerState currentState;
        private IMediaPlayerState standbyState;
        private IMediaPlayerState mp3PlayState;
        private IMediaPlayerState mp3PauseState;
        private IMediaPlayerState radioState;

        private Button playButton;

        public MediaPlayer(Label stateLabel, Button playButton)
        {
            this.playButton = playButton;

            standbyState = new StandbyState(this);
            mp3PlayState = new MP3PlayState(this);
            mp3PauseState = new MP3PauseState(this);
            radioState = new RadioState(this);

            currentState = standbyState;
            UpdateStateLabel(stateLabel);
            UpdatePlayButton();
        }

        public void SetState(IMediaPlayerState state)
        {
            currentState = state;
        }

        public void UpdateStateLabel(Label stateLabel)
        {
            stateLabel.Text = currentState.GetState();
        }

        public void UpdatePlayButton()
        {
            currentState.UpdatePlayButton(playButton);
        }

        public IMediaPlayerState GetStandbyState() => standbyState;
        public IMediaPlayerState GetMP3PlayState() => mp3PlayState;
        public IMediaPlayerState GetMP3PauseState() => mp3PauseState;
        public IMediaPlayerState GetRadioState() => radioState;

        public void PressPlayButton()
        {
            currentState.PressPlayButton();
        }

        public void PressAudioSourceButton()
        {
            currentState.PressAudioSourceButton();
        }
    }


}
