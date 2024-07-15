using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MediaPlayerSimulator
{
    public partial class Form1 : Form
    {
        private MediaPlayer mediaPlayer;

        public Form1()
        {
            InitializeComponent();
            mediaPlayer = new MediaPlayer(lblState, btnPlay);
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            mediaPlayer.PressPlayButton();
            mediaPlayer.UpdateStateLabel(lblState);
            mediaPlayer.UpdatePlayButton();
        }

        private void btnAudioSource_Click(object sender, EventArgs e)
        {
            mediaPlayer.PressAudioSourceButton();
            mediaPlayer.UpdateStateLabel(lblState);
            mediaPlayer.UpdatePlayButton();
        }

        private void lblState_Click(object sender, EventArgs e)
        {

        }
    }
}
