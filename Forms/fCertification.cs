using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Elearning.Forms
{
    public partial class fCertification : Form
    {
        public fCertification()
        {
            InitializeComponent();
        }

        public string fullName
        {
            get { return lblName.Text; }
            set { lblName.Text = value; }
        }

        public string courseName
        {
            get { return lblCourseName.Text; }
            set { lblCourseName.Text = value; }
        }

        public string timeFinish
        {
            get { return lblTimeFinish.Text; }
            set { lblTimeFinish.Text = value; }
        }

        public string lecturer
        {
            get { return lblLecturer.Text; }
            set { lblLecturer.Text = value; }
        }

        private void btnDownload_Click(object sender, EventArgs e)
        {
            Bitmap bmp = new Bitmap(picCertificate.Width, picCertificate.Height);

            this.DrawToBitmap(bmp, new Rectangle(0, 0,
                this.Width, this.Height));

            using (Graphics g = Graphics.FromImage(bmp))
            {
                Point screenPoint = this.PointToScreen(new Point(0, 0));

                g.CopyFromScreen(screenPoint, new Point(0, 0), 
                    new Size(this.Width, this.Height));
            }

            bmp.Save(Program.CERTIFICATE_PATH + fullName + courseName + ".png",
                System.Drawing.Imaging.ImageFormat.Png);

            MessageBox.Show("Hình ảnh đã được chụp và lưu thành công!");
        }
    }
}
