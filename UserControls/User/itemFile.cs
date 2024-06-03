using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Elearning.UserControls
{
    public partial class itemFile : UserControl
    {
        public itemFile()
        {
            InitializeComponent();
        }

        private int candownload = 0;
        public string resuorceName
        {
            get { return lblResourceName.Text; }
            set { lblResourceName.Text = value; }
        }

        public string resourceFileName
        {
            get { return lblLinkFile.Text; }
            set { lblLinkFile.Text = value; }
        }

        public int canDownload
        {
            get { return candownload; }
            set { candownload = value; }
        }

        public void SetCanDownload()
        {
            if (canDownload == 0)
            {
                btnDownload.Visible = false;
            }
            else
            {
                btnDownload.Visible = true;
            }
        }

        private void btnDownload_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();

            saveFileDialog.FileName = resourceFileName;

            saveFileDialog.Filter = "All files (*.*)|*.*";

            DialogResult result = saveFileDialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                string destinationPath = saveFileDialog.FileName;
                File.Copy(Program.RESOURCES_PATH + resourceFileName, destinationPath, true);

                MessageBox.Show($"Lưu file thành công tại {destinationPath}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
