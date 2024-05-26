using QRCoder;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Elearning.Forms
{
    public partial class RegisterPayment : Form
    {
        public RegisterPayment()
        {
            InitializeComponent();
        }

        private int idPayment = 0;

        private void btnVisa_Click(object sender, EventArgs e)
        {
            idPayment = 1;
            picVisa.Image = Image.FromFile("D:\\Code\\C#\\Elearning\\images\\icons\\circle_filled_icon.png");
            btnVisa.BackColor = Color.WhiteSmoke;

            picBanking.Image = Image.FromFile("D:\\Code\\C#\\Elearning\\images\\icons\\circle_icon.png");
            btnBanking.BackColor = Color.White;

            picMomo.Image = Image.FromFile("D:\\Code\\C#\\Elearning\\images\\icons\\circle_icon.png");
            btnMoMo.BackColor = Color.White;

            picCash.Image = Image.FromFile("D:\\Code\\C#\\Elearning\\images\\icons\\circle_icon.png");
            btnCash.BackColor = Color.White;
        }

        private void btnBanking_Click(object sender, EventArgs e)
        {
            idPayment = 2;
            picBanking.Image = Image.FromFile("D:\\Code\\C#\\Elearning\\images\\icons\\circle_filled_icon.png");
            btnBanking.BackColor = Color.WhiteSmoke;

            picVisa.Image = Image.FromFile("D:\\Code\\C#\\Elearning\\images\\icons\\circle_icon.png");
            btnVisa.BackColor = Color.White;

            picMomo.Image = Image.FromFile("D:\\Code\\C#\\Elearning\\images\\icons\\circle_icon.png");
            btnMoMo.BackColor = Color.White;

            picCash.Image = Image.FromFile("D:\\Code\\C#\\Elearning\\images\\icons\\circle_icon.png");
            btnCash.BackColor = Color.White;
        }

        private void btnMoMo_Click(object sender, EventArgs e)
        {
            idPayment = 3;
            picMomo.Image = Image.FromFile("D:\\Code\\C#\\Elearning\\images\\icons\\circle_filled_icon.png");
            btnMoMo.BackColor = Color.WhiteSmoke;

            picBanking.Image = Image.FromFile("D:\\Code\\C#\\Elearning\\images\\icons\\circle_icon.png");
            btnBanking.BackColor = Color.White;

            picVisa.Image = Image.FromFile("D:\\Code\\C#\\Elearning\\images\\icons\\circle_icon.png");
            btnVisa.BackColor = Color.White;

            picCash.Image = Image.FromFile("D:\\Code\\C#\\Elearning\\images\\icons\\circle_icon.png");
            btnCash.BackColor = Color.White;
        }

        private void btnCash_Click(object sender, EventArgs e)
        {
            idPayment = 0;
            picCash.Image = Image.FromFile("D:\\Code\\C#\\Elearning\\images\\icons\\circle_filled_icon.png");
            btnCash.BackColor = Color.WhiteSmoke;

            picBanking.Image = Image.FromFile("D:\\Code\\C#\\Elearning\\images\\icons\\circle_icon.png");
            btnBanking.BackColor = Color.White;

            picMomo.Image = Image.FromFile("D:\\Code\\C#\\Elearning\\images\\icons\\circle_icon.png");
            btnMoMo.BackColor = Color.White;

            picVisa.Image = Image.FromFile("D:\\Code\\C#\\Elearning\\images\\icons\\circle_icon.png");
            btnVisa.BackColor = Color.White;
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (idPayment == 0)
            {
                DialogResult result = MessageBox.Show(
                    "Thanh toán thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information
                    );
                if (result == DialogResult.OK)
                {
                    this.Close();
                }
            }
            else
            {
                panPayment.Visible = false;
                panQRCode.Visible = true;
                CreateQRCode();
            }
        }

        private void CreateQRCode()
        {
            string dataPayment = "aaa";
            QRCodeGenerator qrGenerator = new QRCodeGenerator();
            QRCode qrCode = new QRCode(qrGenerator
                .CreateQrCode(dataPayment, QRCodeGenerator.ECCLevel.Q));
            picQRCode.Image = qrCode.GetGraphic(2, Color.Black, Color.White, false); qrGenerator.Dispose();
            qrCode.Dispose();
        }

        private void btnFinish_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Thanh toán thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information
                );
            if (result == DialogResult.OK)
            {
                this.Close();
            }
        }
    }
}
