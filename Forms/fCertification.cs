using Facebook;
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
using System.Net.Http;

namespace Elearning.Forms
{
    public partial class fCertification : Form
    {
        public fCertification()
        {
            InitializeComponent();
        }

        public string fullName
        {
            get { return lblName.Text; }
            set { lblName.Text = value; }
        }

        public string courseName
        {
            get { return lblCourseName.Text; }
            set { lblCourseName.Text = value; }
        }

        public string timeFinish
        {
            get { return lblTimeFinish.Text; }
            set { lblTimeFinish.Text = value; }
        }

        public string lecturer
        {
            get { return lblLecturer.Text; }
            set { lblLecturer.Text = value; }
        }

        private const string AppId = "301714003019345";
        private const string AppSecret = "7a9f5c3f19ddcce381e001b0e5806b13";
        private const string RedirectUri = "https://www.facebook.com/connect/login_success.html";
        private string accessToken = "EAAESaEP5RlEBOyLZBn0KsdF9KEkWdZBwZADeJAPyjZAbZBtXaSw0c1LgR7eMq0N9rW0vfIKlCgaeGE3efi8G05NyvOHr97TkaZAEofbgX3KZAcWXRrmNhoZCHTNmCTdVMpJVFNoA1VdQVnmMMWUjPqfmdwSZANTIHUzqFlmKZCIlO6Hb1qMmERIPdQQv9FXGiJfHhTipeU4zRyZBM4PJG6v29STUu0UTgyTwBDzfhbcZAbOyfAP9N6dU0HZCBsfmmSeJU1KNLE1HZC9QxZBX2c2";
        static async Task ShareCertoFB()
        {
            var facebookClient = new FacebookClient(accessToken);

            // Adjust the path and filename as per your requirement
            var imagePath = "path_to_your_image.jpg";
            var message = "Your message here";

            try
            {
                var mediaObject = new FacebookMediaObject
                {
                    FileName = Path.GetFileName(imagePath),
                    ContentType = "image/jpeg"
                };

                mediaObject.SetValue(File.ReadAllBytes(imagePath));

                var parameters = new Dictionary<string, object>
                {
                    { "message", message },
                    { "source", mediaObject }
                };

                dynamic result = await facebookClient.PostTaskAsync("me/photos", parameters);
                MessageBox.Show("Image posted successfully. Post ID: " + result.id);
            }
            catch (FacebookApiException ex)
            {
                MessageBox.Show("Error occurred: " + ex.Message);
            }
        }

        private void btnShareFB_Click(object sender, EventArgs e)
        {
            using (var browser = new Form())
            {
                var webBrowser = new WebBrowser { Dock = DockStyle.Fill };
                browser.Controls.Add(webBrowser);
                browser.Width = 800;
                browser.Height = 600;

                webBrowser.Navigated += async (s, ev) =>
                {
                    if (ev.Url.ToString().StartsWith(RedirectUri))
                    {
                        var uri = new Uri(ev.Url.ToString());
                        var queryParams = QueryHelpers.ParseQuery(uri.Fragment.Substring(1));
                        accessToken = queryParams["access_token"];
                        browser.Close();
                    }
                };

                string oauthUrl = $"https://www.facebook.com/dialog/oauth?client_id={AppId}&redirect_uri={RedirectUri}&response_type=token&scope=publish_actions";
                webBrowser.Navigate(oauthUrl);
                browser.ShowDialog();
            }

            if (!string.IsNullOrEmpty(accessToken))
            {
                await ShareImageToFacebook();
            }
        }
    }
}
