using Elearning.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Validation;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Elearning.Forms
{
    public partial class fAdminAddResource : Form
    {
        public CourseModule module;
        public EventHandler evtReload;
        public fAdminAddResource()
        {
            InitializeComponent();
        }

        public fAdminAddResource(CourseModule module) : this()
        {
            this.module = module;

            for (int i = 0; i < Program.RESOURCE_TYPE.Length; ++i)
            {
                cbType.Items.Add(Program.RESOURCE_TYPE[i]);
            }

            cbType.SelectedIndex = 0;
        }

        private void btnChooseFile_Click(object sender, EventArgs e)
        {
            string type = cbType.SelectedItem.ToString();

            if (type == "Video")
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "Video files (*.mp4, *.avi, *.flv, *.wmv)|*.mp4;*.avi;*.flv;*.wmv";
                dialog.Title = "Choose a video file";
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    tbPath.Text = dialog.FileName;
                }
            }
            else if (type == "Document")
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "Document files (*.pdf, *.doc, *.docx, *.ppt, *.pptx)|*.pdf;*.doc;*.docx;*.ppt;*.pptx";
                dialog.Title = "Choose a document file";
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    tbPath.Text = dialog.FileName;
                }
            }
        }

        private void cbType_SelectedIndexChanged(object sender, EventArgs e)
        {
            string type = cbType.SelectedItem.ToString();
            if (type == "Video" || type == "Document")
            {
                conChooseFile.Visible = true;
                lbChooseFile.Visible = true;
                lbOption.Text = "Allow download";
            }
            else
            {
                conChooseFile.Visible = false;
                lbChooseFile.Visible = false;
                lbOption.Text = "Mandatory";
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            int type = 0;
            switch (cbType.SelectedItem.ToString())
            {
                case "Video":
                    type = Program.TYPE_VIDEO;
                    break;
                case "Document":
                    type = Program.TYPE_DOC;
                    break;
                case "Test":
                    type = Program.TYPE_TEST;
                    break;
            }

            if (type != Program.TYPE_TEST && tbPath.Text == "")
            {
                MessageBox.Show("Please choose a file", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // copy the file to the resource folder with filename is the new id + file extension
            // get the last resource id

            try
            {
                CourseResource resource = new CourseResource()
                {
                    module_id = module.module_id,
                    resource_name = tbName.Text,
                    resource_type = type,
                    resource_filename = "",
                    allow_download = cbType.SelectedItem.ToString() == "Video" || cbType.SelectedItem.ToString() == "Document" ? Convert.ToInt32(optYes.Checked) : 0
                };

                Program.provider.CourseResources.Add(resource);
                Program.provider.SaveChanges();

                int id = resource.resource_id;

                if (type != Program.TYPE_TEST)
                {
                    string path = Program.RESOURCES_PATH + id + tbPath.Text.Substring(tbPath.Text.LastIndexOf('.'));
                    System.IO.File.Copy(tbPath.Text, path);
                    resource.resource_filename = id + tbPath.Text.Substring(tbPath.Text.LastIndexOf('.'));

                    Program.provider.SaveChanges();
                }


                MessageBox.Show("Resource added successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                evtReload?.Invoke(this, e);
            }
            catch (DbEntityValidationException ex)
            {
                foreach (var eve in ex.EntityValidationErrors)
                {
                    Console.WriteLine("Entity of type \"{0}\" in state \"{1}\" has the following validation errors:",
                        eve.Entry.Entity.GetType().Name, eve.Entry.State);
                    foreach (var ve in eve.ValidationErrors)
                    {
                        Console.WriteLine("- Property: \"{0}\", Error: \"{1}\"",
                            ve.PropertyName, ve.ErrorMessage);
                    }
                }
                throw;
            }
        }
    }
}
