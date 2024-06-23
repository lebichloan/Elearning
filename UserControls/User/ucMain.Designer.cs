namespace Elearning.UserControls
{
    partial class ucMain
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnHome = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.btnMyLearning = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.btnAccount = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.conMain = new Siticone.Desktop.UI.WinForms.SiticoneContainerControl();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btnHome);
            this.flowLayoutPanel1.Controls.Add(this.btnMyLearning);
            this.flowLayoutPanel1.Controls.Add(this.btnAccount);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(100, 0, 4, 0);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(916, 62);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // btnHome
            // 
            this.btnHome.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(36)))), ((int)(((byte)(202)))));
            this.btnHome.CustomBorderColor = System.Drawing.Color.White;
            this.btnHome.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.btnHome.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(36)))), ((int)(((byte)(202)))));
            this.btnHome.DisabledState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(36)))), ((int)(((byte)(202)))));
            this.btnHome.DisabledState.FillColor = System.Drawing.Color.White;
            this.btnHome.DisabledState.Font = new System.Drawing.Font("Segoe UI Variable Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(36)))), ((int)(((byte)(202)))));
            this.btnHome.Enabled = false;
            this.btnHome.FillColor = System.Drawing.Color.White;
            this.btnHome.Font = new System.Drawing.Font("Segoe UI Variable Display", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.ForeColor = System.Drawing.Color.DimGray;
            this.btnHome.ImageSize = new System.Drawing.Size(22, 22);
            this.btnHome.Location = new System.Drawing.Point(105, 5);
            this.btnHome.Margin = new System.Windows.Forms.Padding(5);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(159, 57);
            this.btnHome.TabIndex = 10;
            this.btnHome.Text = "Home";
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // btnMyLearning
            // 
            this.btnMyLearning.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(36)))), ((int)(((byte)(202)))));
            this.btnMyLearning.CustomBorderColor = System.Drawing.Color.White;
            this.btnMyLearning.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.btnMyLearning.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(36)))), ((int)(((byte)(202)))));
            this.btnMyLearning.DisabledState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(36)))), ((int)(((byte)(202)))));
            this.btnMyLearning.DisabledState.FillColor = System.Drawing.Color.White;
            this.btnMyLearning.DisabledState.Font = new System.Drawing.Font("Segoe UI Variable Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMyLearning.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(36)))), ((int)(((byte)(202)))));
            this.btnMyLearning.FillColor = System.Drawing.Color.White;
            this.btnMyLearning.Font = new System.Drawing.Font("Segoe UI Variable Display", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMyLearning.ForeColor = System.Drawing.Color.DimGray;
            this.btnMyLearning.ImageSize = new System.Drawing.Size(22, 22);
            this.btnMyLearning.Location = new System.Drawing.Point(274, 5);
            this.btnMyLearning.Margin = new System.Windows.Forms.Padding(5);
            this.btnMyLearning.Name = "btnMyLearning";
            this.btnMyLearning.Size = new System.Drawing.Size(159, 57);
            this.btnMyLearning.TabIndex = 11;
            this.btnMyLearning.Text = "My Learning";
            this.btnMyLearning.Click += new System.EventHandler(this.btnMyLearning_Click);
            // 
            // btnAccount
            // 
            this.btnAccount.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(36)))), ((int)(((byte)(202)))));
            this.btnAccount.CustomBorderColor = System.Drawing.Color.White;
            this.btnAccount.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.btnAccount.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(36)))), ((int)(((byte)(202)))));
            this.btnAccount.DisabledState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(36)))), ((int)(((byte)(202)))));
            this.btnAccount.DisabledState.FillColor = System.Drawing.Color.White;
            this.btnAccount.DisabledState.Font = new System.Drawing.Font("Segoe UI Variable Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAccount.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(36)))), ((int)(((byte)(202)))));
            this.btnAccount.FillColor = System.Drawing.Color.White;
            this.btnAccount.Font = new System.Drawing.Font("Segoe UI Variable Display", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAccount.ForeColor = System.Drawing.Color.DimGray;
            this.btnAccount.ImageSize = new System.Drawing.Size(22, 22);
            this.btnAccount.Location = new System.Drawing.Point(443, 5);
            this.btnAccount.Margin = new System.Windows.Forms.Padding(5);
            this.btnAccount.Name = "btnAccount";
            this.btnAccount.Size = new System.Drawing.Size(159, 57);
            this.btnAccount.TabIndex = 12;
            this.btnAccount.Text = "Account";
            this.btnAccount.Click += new System.EventHandler(this.btnAccount_Click);
            // 
            // conMain
            // 
            this.conMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.conMain.Location = new System.Drawing.Point(0, 62);
            this.conMain.Name = "conMain";
            this.conMain.Size = new System.Drawing.Size(916, 550);
            this.conMain.TabIndex = 2;
            this.conMain.Text = "siticoneContainerControl1";
            // 
            // ucMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.conMain);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ucMain";
            this.Size = new System.Drawing.Size(916, 612);
            this.Load += new System.EventHandler(this.ucMain_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private Siticone.Desktop.UI.WinForms.SiticoneButton btnHome;
        private Siticone.Desktop.UI.WinForms.SiticoneButton btnAccount;
        private Siticone.Desktop.UI.WinForms.SiticoneContainerControl conMain;
        private Siticone.Desktop.UI.WinForms.SiticoneButton btnMyLearning;
    }
}
