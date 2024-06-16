using Elearning.Entities;
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
    public partial class ucAdminReview : UserControl
    {
        CourseReview review;
        public ucAdminReview(CourseReview review)
        {
            InitializeComponent();
            this.review = review;
            LoadData();
        }

        private void LoadData()
        {
            lbStar.Text = review.stars.ToString();
            tbContent.Text = review.content;
            lbName.Text = review.Register.Account.username;
            lbDate.Text = "Reviewed on " + review.review_time.ToString("f");
            pbAvatar.Image = Image.FromFile(Program.AVARTAR_PATH + review.Register.Account.avatar);
            pbAvatar.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        public int star()
        {
            return (int)review.stars;
        }
    }
}
