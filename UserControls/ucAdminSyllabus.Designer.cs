﻿namespace Elearning.UserControls
{
    partial class ucAdminSyllabus
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
            this.label2 = new System.Windows.Forms.Label();
            this.tlpModules = new System.Windows.Forms.TableLayoutPanel();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("UTM Cooper Black", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(36)))), ((int)(((byte)(202)))));
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(1, 0, 0, 0);
            this.label2.Size = new System.Drawing.Size(1032, 48);
            this.label2.TabIndex = 4;
            this.label2.Text = "Syllabus";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tlpModules
            // 
            this.tlpModules.ColumnCount = 2;
            this.tlpModules.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpModules.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpModules.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpModules.Location = new System.Drawing.Point(0, 48);
            this.tlpModules.Margin = new System.Windows.Forms.Padding(2);
            this.tlpModules.Name = "tlpModules";
            this.tlpModules.Padding = new System.Windows.Forms.Padding(110, 3, 250, 3);
            this.tlpModules.RowCount = 2;
            this.tlpModules.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpModules.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpModules.Size = new System.Drawing.Size(1032, 452);
            this.tlpModules.TabIndex = 8;
            // 
            // ucAdminSyllabus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.tlpModules);
            this.Controls.Add(this.label2);
            this.Name = "ucAdminSyllabus";
            this.Size = new System.Drawing.Size(1032, 500);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TableLayoutPanel tlpModules;
    }
}
