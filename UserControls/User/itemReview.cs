using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Elearning.UserControls.User
{
    public partial class itemReview : UserControl
    {
        public itemReview()
        {
            InitializeComponent();
        }

        public void SetRating(int? rating)
        {
            if (rating == 1)
            {
                btnStar1.Image = Image.FromFile(Program.ICONS_PATH + "star_fill.png");
                btnStar2.Image = Image.FromFile(Program.ICONS_PATH + "star_solid.png");
                btnStar3.Image = Image.FromFile(Program.ICONS_PATH + "star_solid.png");
                btnStar4.Image = Image.FromFile(Program.ICONS_PATH + "star_solid.png");
                btnStar5.Image = Image.FromFile(Program.ICONS_PATH + "star_solid.png");
            }
            else if (rating == 2)
            {
                btnStar1.Image = Image.FromFile(Program.ICONS_PATH + "star_fill.png");
                btnStar2.Image = Image.FromFile(Program.ICONS_PATH + "star_fill.png");
                btnStar3.Image = Image.FromFile(Program.ICONS_PATH + "star_solid.png");
                btnStar4.Image = Image.FromFile(Program.ICONS_PATH + "star_solid.png");
                btnStar5.Image = Image.FromFile(Program.ICONS_PATH + "star_solid.png");
            }
            else if (rating == 3)
            {
                btnStar1.Image = Image.FromFile(Program.ICONS_PATH + "star_fill.png");
                btnStar2.Image = Image.FromFile(Program.ICONS_PATH + "star_fill.png");
                btnStar3.Image = Image.FromFile(Program.ICONS_PATH + "star_fill.png");
                btnStar4.Image = Image.FromFile(Program.ICONS_PATH + "star_solid.png");
                btnStar5.Image = Image.FromFile(Program.ICONS_PATH + "star_solid.png");
            }
            else if (rating == 4)
            {
                btnStar1.Image = Image.FromFile(Program.ICONS_PATH + "star_fill.png");
                btnStar2.Image = Image.FromFile(Program.ICONS_PATH + "star_fill.png");
                btnStar3.Image = Image.FromFile(Program.ICONS_PATH + "star_fill.png");
                btnStar4.Image = Image.FromFile(Program.ICONS_PATH + "star_fill.png");
                btnStar5.Image = Image.FromFile(Program.ICONS_PATH + "star_solid.png");
            }
            else if (rating == 5)
            {
                btnStar1.Image = Image.FromFile(Program.ICONS_PATH + "star_fill.png");
                btnStar2.Image = Image.FromFile(Program.ICONS_PATH + "star_fill.png");
                btnStar3.Image = Image.FromFile(Program.ICONS_PATH + "star_fill.png");
                btnStar4.Image = Image.FromFile(Program.ICONS_PATH + "star_fill.png");
                btnStar5.Image = Image.FromFile(Program.ICONS_PATH + "star_fill.png");
            }
            else
            {
                btnStar1.Image = Image.FromFile(Program.ICONS_PATH + "star_fill.png");
                btnStar2.Image = Image.FromFile(Program.ICONS_PATH + "star_fill.png");
                btnStar3.Image = Image.FromFile(Program.ICONS_PATH + "star_fill.png");
                btnStar4.Image = Image.FromFile(Program.ICONS_PATH + "star_fill.png");
                btnStar5.Image = Image.FromFile(Program.ICONS_PATH + "star_fill.png");
            }
        }

        public Image avatarPath
        {
            get { return picAvatar.Image; }
            set { picAvatar.Image = value; }
        }

        public string name
        {
            get { return lblName.Text; }
            set { lblName.Text = value; }
        }

        public string review
        {
            get { return lblReview.Text; }
            set { lblReview.Text = value; }
        }

        public string datetime
        {
            get { return lblDateTime.Text; }
            set { lblDateTime.Text = value; }
        }
    }
}
