using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Elearning.UserControls
{
    public partial class itemVideo : UserControl
    {
        public itemVideo()
        {
            InitializeComponent();
            isPlay = 0;
        }

        private int isPlay = 0;
        public void HideContextMenu()
        {
            medVideo.uiMode = "none";
            medVideo.Ctlcontrols.stop();
            btnPlay.Image = Image.FromFile(Program.ICONS_PATH + "play.png");
        }

        public string resuorceName
        {
            get { return lblResourceName.Text; }
            set { lblResourceName.Text = value; }
        }
        
        public string videoURL
        {
            get { return medVideo.URL; }
            set { medVideo.URL = value; }
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            if (isPlay == 0)
            {
                isPlay = 1;
                medVideo.Ctlcontrols.pause();
                btnPlay.Image = Image.FromFile(Program.ICONS_PATH + "play.png");
                timerVideo.Stop();
            }
            else
            {
                isPlay = 0;
                medVideo.Ctlcontrols.play();
                btnPlay.Image = Image.FromFile(Program.ICONS_PATH + "stop.png");
                timerVideo.Start();
            }
        }

        private void timerVideo_Tick(object sender, EventArgs e)
        {
            if (medVideo.playState == WMPLib.WMPPlayState.wmppsPlaying)
            {
                progressBar.Maximum = (int)medVideo.Ctlcontrols.currentItem.duration;
                progressBar.Value = (int)medVideo.Ctlcontrols.currentPosition;
            }
            lblTimePlay.Text = String.Format("{0} / {1}",
                medVideo.Ctlcontrols.currentPositionString,
                medVideo.Ctlcontrols.currentItem.durationString.ToString());
        }

        private void trackBarVolume_Scroll(object sender, ScrollEventArgs e)
        {
            medVideo.settings.volume = trackBarVolume.Value;
            if (trackBarVolume.Value == 0)
            {
                btnVolume.Image = Image.FromFile(Program.ICONS_PATH + "mute_volume.png");
            }
            else
            {
                btnVolume.Image = Image.FromFile(Program.ICONS_PATH + "volume.png");
            }
        }

        private void btnVolume_Click(object sender, EventArgs e)
        {
            if (trackBarVolume.Value == 0)
            {
                btnVolume.Image = Image.FromFile(Program.ICONS_PATH + "volume.png");
                trackBarVolume.Value = 100;
            }
            else
            {
                btnVolume.Image = Image.FromFile(Program.ICONS_PATH + "mute_volume.png");
                trackBarVolume.Value = 0;
            }
        }
    }
}
