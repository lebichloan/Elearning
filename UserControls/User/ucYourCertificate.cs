using Elearning.Entities;
using Elearning.Forms;
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
    public partial class ucYourCertificate : UserControl
    {
        public ucYourCertificate()
        {
            InitializeComponent();
            currentAccount = fLogin.currentAccount;
            InitUI();
        }

        private Account currentAccount;

        private void InitUI()
        {
            tbAllCertificate.Controls.Clear();
            tbAllCertificate.AutoScroll = true;
            tbAllCertificate.VerticalScroll.Visible = true;
            tbAllCertificate.VerticalScroll.Enabled = true;
            tbAllCertificate.HorizontalScroll.Visible = false;
            tbAllCertificate.HorizontalScroll.Enabled = false;
            tbAllCertificate.RowCount = 0;
            tbAllCertificate.RowStyles.Clear();
            tbAllCertificate.RowStyles.Add(new RowStyle(SizeType.AutoSize));

            List<Register> registers = (
                from regis in Program.provider.Registers
                where regis.register_status == 2
                select regis
                ).ToList();

            if (registers.Count > 0 )
            {
                foreach (Register reg in registers)
                {
                    ucCertificate certificate = new ucCertificate(reg);
                    tbAllCertificate.Controls.Add(certificate);
                }
            }
            else
            {
                Label lbl = new Label();
                lbl.Text = "You haven't completed any courses yet. \n" +
                    "Please go to the My Elearning page to continue.";
                lbl.AutoSize = false;
                lbl.Dock = DockStyle.Fill;
                lbl.TextAlign = ContentAlignment.MiddleCenter;
                lbl.Font = new Font("Segoe UI Semibold", 20f, FontStyle.Bold);
                tbAllCertificate.Controls.Add(lbl);
            }
        }
    }
}
