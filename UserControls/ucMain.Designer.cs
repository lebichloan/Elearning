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
            this.panelTab = new System.Windows.Forms.Panel();
            this.btnMyLearning = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.panelMain = new System.Windows.Forms.Panel();
            this.panelTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTab
            // 
            this.panelTab.Controls.Add(this.btnMyLearning);
            this.panelTab.Controls.Add(this.btnHome);
            this.panelTab.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTab.Location = new System.Drawing.Point(0, 0);
            this.panelTab.Name = "panelTab";
            this.panelTab.Size = new System.Drawing.Size(1222, 77);
            this.panelTab.TabIndex = 0;
            // 
            // btnMyLearning
            // 
            this.btnMyLearning.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnMyLearning.Font = new System.Drawing.Font("Segoe UI Variable Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMyLearning.Location = new System.Drawing.Point(238, 0);
            this.btnMyLearning.Name = "btnMyLearning";
            this.btnMyLearning.Size = new System.Drawing.Size(238, 77);
            this.btnMyLearning.TabIndex = 1;
            this.btnMyLearning.Text = "My learning";
            this.btnMyLearning.UseVisualStyleBackColor = true;
            this.btnMyLearning.Click += new System.EventHandler(this.btnMyLearning_Click);
            // 
            // btnHome
            // 
            this.btnHome.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnHome.Font = new System.Drawing.Font("Segoe UI Variable Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.Location = new System.Drawing.Point(0, 0);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(238, 77);
            this.btnHome.TabIndex = 0;
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // panelMain
            // 
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 77);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(1222, 676);
            this.panelMain.TabIndex = 1;
            // 
            // ucMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panelTab);
            this.Name = "ucMain";
            this.Size = new System.Drawing.Size(1222, 753);
            this.Load += new System.EventHandler(this.ucMain_Load);
            this.panelTab.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTab;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Button btnMyLearning;
        private System.Windows.Forms.Button btnHome;
    }
}
