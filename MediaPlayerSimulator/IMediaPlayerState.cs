using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MediaPlayerSimulator
{
    public interface IMediaPlayerState
    {
        void PressPlayButton();
        void PressAudioSourceButton();
        string GetState();
        void UpdatePlayButton(Button playButton);
    }
}
