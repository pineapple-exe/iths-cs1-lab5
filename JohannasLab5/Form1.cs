using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JohannasLab5
{
    public partial class IMGHunterForm : Form
    {
        private List<string> imgURLs;

        public IMGHunterForm()
        {
            InitializeComponent();
        }

        private void HowManyImages(int imgURLCount)
        {
            HowManyIMGLinksLabel.Text = imgURLCount.ToString();
        }

        private void RefreshField()
        {
            if (imgURLs != null)
            {
                ImageLinksTextBox.Clear();
                imgURLs.Clear();

                EmptyLinkLabel.Visible = false;
                ProgressBar.Visible = false;
                ProgressBar.Value = 0;

                HowManyImages(0);
            }
        }

        private string MakeAbsolute(string url)
        {
            if (Uri.IsWellFormedUriString(url, UriKind.Absolute))
            {
                return url;
            }

            else
            {
                Uri uri = new Uri(URLEaterTextBox.Text);
                string host = uri.Host;
                return uri.Scheme + "://" + host + url;
            }
        }

        private void HandleURL()
        {
            if (!Uri.IsWellFormedUriString(URLEaterTextBox.Text, UriKind.Absolute))
            {
                InvalidURILabel.Visible = true;
                InvalidURITimer.Enabled = true;
                SaveImgsButton.Enabled = false;
                return;
            }
            else
            {
                HttpClient webWizard = new HttpClient();
                Task<byte[]> data = webWizard.GetByteArrayAsync(URLEaterTextBox.Text);

                Regex pattern = new Regex("(?<=<img.*?src=\")(.*?)(?=\")");
                imgURLs = new List<string>();
                data.Wait();

                string dataString = Encoding.ASCII.GetString(data.Result);
                MatchCollection imgMatches = pattern.Matches(dataString);

                foreach (Match m in imgMatches)
                {
                    if (m.ToString() != "" && !imgURLs.Contains(m.Value))
                    {
                        imgURLs.Add(m.Value);
                    }
                }
                HowManyImages(imgURLs.Count);
                SaveImgsButton.Enabled = true;

                imgURLs = imgURLs.Select(MakeAbsolute).ToList();

                string n = Environment.NewLine + Environment.NewLine;
                foreach (string s in imgURLs)
                {
                    ImageLinksTextBox.Text += s + n;
                }
            }
        }

        private async Task<byte[]> ProcessURLAsync(string url, HttpClient client)
        {
            Byte[] data = await client.GetByteArrayAsync(url);
            return data;
        }

        private async Task<IMGKit> GenerateIMGKit(string url, HttpClient client)
        {
            return new IMGKit(url, await ProcessURLAsync(url, client));
        }

        private async Task WriteAllBytesAsync(string path, byte[] content)
        {
            using (FileStream fs = new FileStream(path, FileMode.Create))
            {
                await fs.WriteAsync(content, 0, content.Length);
            }
        }

        private string EnsureAvailableName(string fileName)
        {
            string extension = Path.GetExtension(fileName);
            string name = Path.GetFileNameWithoutExtension(fileName);

            int copyCat = 0;
            string finalName = fileName;

            while (true)
            {
                if (File.Exists(Path.Combine(ChooseFolderDialog.SelectedPath, finalName)))
                {
                    copyCat++;
                    finalName = name + "_" + copyCat + extension;
                }
                else
                {
                    break;
                }
            }
            return finalName;
        }

        private string URLToPath(string url)
        {
            string localPath = new Uri(url).LocalPath;
            string fileName = Path.GetFileName(localPath);

            return Path.Combine(ChooseFolderDialog.SelectedPath, EnsureAvailableName(fileName));
        }

        private void CalculateProgress(int max, int progress)
        {
            ProgressBar.Value = 100 / (max / progress);
        }

        private async Task DownloadImagesALaFredrik()
        {
            ProgressBar.Visible = true;
            int countProgress = 0;
            int countessEmptiness = 0;

            List<Task<IMGKit>> downloadsInDistress = new List<Task<IMGKit>>();
            HttpClient webWizard = new HttpClient();

            for (int i = 0; i < imgURLs.Count; i++)
            {
                downloadsInDistress.Add(GenerateIMGKit(imgURLs[i], webWizard));

                //Ensure no more than seven concurrent downloads.
                while (downloadsInDistress.Count > 6 || (i == imgURLs.Count - 1 && downloadsInDistress.Count > 0))
                {
                    Task<IMGKit> readyToBeSaved = await Task.WhenAny(downloadsInDistress);
                    downloadsInDistress.Remove(readyToBeSaved);

                    if (readyToBeSaved.Result.Content.Length > 0)
                    {
                        await WriteAllBytesAsync(URLToPath(readyToBeSaved.Result.URL), readyToBeSaved.Result.Content);
                    }
                    else
                    {
                        countessEmptiness++;
                        EmptyLinkLabel.Text = "Empty links: " + countessEmptiness;
                        EmptyLinkLabel.Visible = true;
                    }
                    countProgress++;
                    CalculateProgress(imgURLs.Count, countProgress);
                }
            }
        }

        private void ExtractButton_Click(object sender, EventArgs e)
        {
            RefreshField();
            HandleURL();
        }

        private void URLEaterTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
            {
                RefreshField();
                HandleURL();
            }
        }

        private void InvalidURITimer_Tick(object sender, EventArgs e)
        {
            InvalidURILabel.Visible = false;
            InvalidURITimer.Enabled = false;
        }

        private async void SaveImgsButton_Click(object sender, EventArgs e)
        {
            if (imgURLs != null && imgURLs.Count > 0)
            {
                if (ChooseFolderDialog.ShowDialog() == DialogResult.OK)
                {
                    ExtractButton.Enabled = false;
                    SaveImgsButton.Enabled = false;

                    await DownloadImagesALaFredrik();

                    DownloadCompletedLabel.Visible = true;
                    DownloadCompletedTimer.Enabled = true;

                    ExtractButton.Enabled = true;
                    SaveImgsButton.Enabled = true;
                }
            }
        }

        private void DownloadCompletedTimer_Tick(object sender, EventArgs e)
        {
            DownloadCompletedLabel.Visible = false;
            DownloadCompletedTimer.Enabled = false;
        }
    }
}
