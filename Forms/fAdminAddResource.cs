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
        public CourseResource resource;
        public EventHandler evtReload;
        bool isEdit = false;
        public fAdminAddResource()
        {
            InitializeComponent();
            for (int i = 0; i < Program.RESOURCE_TYPE.Length; ++i)
            {
                cbType.Items.Add(Program.RESOURCE_TYPE[i]);
            }

            cbType.SelectedIndex = 0;
            optNo.Checked = true;
        }

        public fAdminAddResource(CourseModule module) : this()
        {
            this.module = module;
        }

        public fAdminAddResource(CourseResource resource) : this()
        {
            // in the case of editing a resource
            tbName.Text = resource.resource_name;
            cbType.SelectedItem = Program.RESOURCE_TYPE[resource.resource_type];
            cbType.Enabled = false;
            optYes.Checked = resource.allow_download == 1;
            optNo.Checked = resource.allow_download == 0;
            lbTitle.Text = "Edit resource";

            isEdit = true;
            this.resource = resource;
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

        private void AddResource()
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

                if (type == Program.TYPE_TEST)
                {
                    // update the mandatory property of the test
                    var test = Program.provider.CourseTests.Where(t => t.resource_id == id).FirstOrDefault();
                    test.mandatory = Convert.ToInt32(optYes.Checked);
                    Program.provider.SaveChanges();
                    // show message box to ask if the user wants to add questions to the test
                    if (MessageBox.Show("New test added. Would you like to add questions to the test now?", "Add questions", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        fAdminEditTest form = new fAdminEditTest(test);
                        form.ShowDialog();  
                    }
                    return;
                }
                MessageBox.Show("Resource added successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void EditResource()
        {
            resource.resource_name = tbName.Text;
            resource.allow_download = cbType.SelectedItem.ToString() == "Video" || cbType.SelectedItem.ToString() == "Document" ? Convert.ToInt32(optYes.Checked) : 0;
            if (tbPath.Text != "")
            {
                // remove the old file
                System.IO.File.Delete(Program.RESOURCES_PATH + resource.resource_filename);
                string path = Program.RESOURCES_PATH + resource.resource_id + tbPath.Text.Substring(tbPath.Text.LastIndexOf('.'));
                System.IO.File.Copy(tbPath.Text, path);
                resource.resource_filename = resource.resource_id + tbPath.Text.Substring(tbPath.Text.LastIndexOf('.'));
            }
            Program.provider.SaveChanges();

            MessageBox.Show("Resource edited successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (isEdit)
            {
                EditResource();
            }
            else
            {
                AddResource();
                
                // clear all fields
                tbName.Text = "";
                tbPath.Text = "";
                cbType.SelectedIndex = 0;
                optNo.Checked = true;
            }

            evtReload?.Invoke(this, e);
        }
    }
}
