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
    public partial class fTestResult : Form
    {
        public fTestResult()
        {
            InitializeComponent();
        }

        public string finishTestName
        {
            get { return lblFinishTest.Text; }
            set { lblFinishTest.Text = value; }
        }

        public string timeStart
        {
            get { return lblStart.Text; }
            set { lblStart.Text = value; }
        }

        public string timeFinish
        {
            get { return lblFinish.Text; }
            set { lblFinish.Text = value; }
        }

        public string testState
        {
            get { return lblState.Text; }
            set { lblState.Text = value; }
        }

        public string totalTime
        {
            get { return lblTotalTime.Text; }
            set { lblTotalTime.Text = value; }
        }

        public string source
        {
            get { return lblSource.Text; }
            set { lblSource.Text = value; }
        }

        public string testOrdinal
        {
            get { return lblTestOrdinal.Text; }
            set { lblTestOrdinal.Text = value; }
        }

        public EventHandler fResultTestClose;
        public EventHandler ViewDetailTest;
        private void btnViewDetail_Click(object sender, EventArgs e)
        {
            ViewDetailTest?.Invoke(this, e);
            this.Close();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            fResultTestClose?.Invoke(this, e);
            this.Close();
        }

        private void fTestResult_FormClosed(object sender, FormClosedEventArgs e)
        {
            fResultTestClose?.Invoke(this, e);
            this.Close();
        }

        public Color TextStateColor
        {
            get { return lblState.ForeColor; }
            set { lblState.ForeColor = value; }
        }
    }
}
