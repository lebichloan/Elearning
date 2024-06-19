using PdfiumViewer;
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
            timerEvent.Start();
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
                panDownload.Size = new Size(0, 0);
            }
            else
            {
                panDownload.Size = new Size(60, 870);
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

        public void LoadPDF(string filename)
        {
            if (System.IO.Path.GetExtension(filename) == ".pdf")
            {
                pdfViewer.Document = PdfDocument.Load(filename);
                lblPage.Text = String.Format("{0}/{1}",
                    pdfViewer.Renderer.Page + 1,
                    pdfViewer.Document.PageCount);
            }
            else
            {
                pdfViewer.Visible = false;
                panToolBar.Visible = false;
                this.Size = new Size(600, 145);
            }
        }

        private void btnZoomIn_Click(object sender, EventArgs e)
        {
            pdfViewer.ZoomMode = PdfViewerZoomMode.FitWidth;
        }

        private void btnZoomOut_Click(object sender, EventArgs e)
        {
            pdfViewer.ZoomMode = PdfViewerZoomMode.FitHeight;
        }

        private void btnPre_Click(object sender, EventArgs e)
        {
            if (pdfViewer.Renderer.Page > 0)
            {
                pdfViewer.Renderer.Page--;
                lblPage.Text = String.Format("{0}/{1}",
                    pdfViewer.Renderer.Page + 1,
                    pdfViewer.Document.PageCount);
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (pdfViewer.Renderer.Page < pdfViewer.Document.PageCount -1)
            {
                pdfViewer.Renderer.Page++;
                lblPage.Text = String.Format("{0}/{1}",
                    pdfViewer.Renderer.Page + 1,
                    pdfViewer.Document.PageCount);
            }
        }

        private void timerEvent_Tick(object sender, EventArgs e)
        {
            if (System.IO.Path.GetExtension(resourceFileName) == ".pdf")
            {
                lblPage.Text = String.Format("{0}/{1}",
                    pdfViewer.Renderer.Page + 1,
                    pdfViewer.Document.PageCount);
            }
        }
    }
}
