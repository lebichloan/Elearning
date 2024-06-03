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
            medVideo.uiMode = "mini";
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
                medVideo.Ctlcontrols.stop();
                btnPlay.Image = Image.FromFile(Program.ICONS_PATH + "play.png");
            }
            else
            {
                isPlay = 0;
                medVideo.Ctlcontrols.play();
                btnPlay.Image = Image.FromFile(Program.ICONS_PATH + "stop.png");
            }
        }
    }
}
