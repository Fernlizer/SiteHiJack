using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing.Printing;
using System.Security.Policy;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SiteHiJack
{
    public partial class Form1 : Form
    {
        private PageParser _parser;
        public Form1()
        {
            InitializeComponent();
        }

        private void bt_hijeck_Click(object sender, EventArgs e)
        {
            _parser = new PageParser(tb_domain.Text, tb_directory.Text);
            toolStripStatusLabel1.Text = "Hijacking ... ";
            toolStripProgressBar1.Value = 15;
            backgroundWorker1.RunWorkerAsync();
            tb_domain.Enabled = false;
            tb_directory.Enabled = false;
            bt_cancle.Enabled = true;
            bt_hijeck.Enabled = false;
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            _parser.DownloadPage();
            backgroundWorker1.ReportProgress(50);

            _parser.ParsePage();
            backgroundWorker1.ReportProgress(100);
        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            toolStripProgressBar1.Value = e.ProgressPercentage;
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            listBox1.DataSource = _parser.GetLinks();
            listBox2.DataSource = _parser.GetCssFiles();
            listBox3.DataSource = _parser.GetJsFiles();
            listBox4.DataSource = _parser.GetImages();

            string pagesource = _parser.GetSource();
            tb_viewer.Text = pagesource;
            tb_uritarget.Text = tb_domain.Text;
            toolStripStatusLabel1.Text = "Done";
        }


        private void listBox1_DoubleClick(object sender, EventArgs e)
        {
            string text = listBox1.GetItemText(listBox1.SelectedItem);
            tb_uritarget.Text = text;
        }

        private void bt_open_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start(new ProcessStartInfo(tb_uritarget.Text) { UseShellExecute = true });
            }
            catch (Win32Exception noBrowser)
            {
                if (noBrowser.ErrorCode == -2147467259)
                    MessageBox.Show(noBrowser.Message);
            }
            catch (Exception other)
            {
                MessageBox.Show(other.Message);
            }
        }

        private void bt_cancle_Click(object sender, EventArgs e)
        {
            tb_domain.Enabled = true;
            tb_directory.Enabled = true;
            bt_cancle.Enabled = false;
            bt_hijeck.Enabled = true;
        }

        private async void bt_view_Click(object sender, EventArgs e)
        {
            // Disable the download button to prevent multiple clicks
            bt_view.Enabled = false;
            tb_viewer.Text = "loading";
            try
            {
                // Get the URL of the web page to download
                string url = tb_uritarget.Text;

                // Download the web page content asynchronously
                string pageContent = await _parser.GetViewAsync(url);

                // Display the downloaded content in the pageContentTextBox
                tb_viewer.Text = "";
                tb_viewer.Text = pageContent;
            }
            catch (Exception ex)
            {
                // Display any errors that occurred during the download
                //MessageBox.Show($"An error occurred while downloading the web page: {ex.Message}");
                tb_viewer.Text = ex.Message;
            }
            finally
            {
                // Re-enable the download button when the download is complete
                bt_view.Enabled = true;
            }
        }

        private void listBox2_DoubleClick(object sender, EventArgs e)
        {
            string text = listBox2.GetItemText(listBox2.SelectedItem);
            tb_uritarget.Text = text;
        }

        private void listBox3_DoubleClick(object sender, EventArgs e)
        {
            string text = listBox3.GetItemText(listBox3.SelectedItem);
            tb_uritarget.Text = text;
        }

        private void listBox4_DoubleClick(object sender, EventArgs e)
        {
            string text = listBox4.GetItemText(listBox4.SelectedItem);
            tb_uritarget.Text = text;
        }

        private async void bt_download_Click(object sender, EventArgs e)
        {

            bt_download.Enabled = false;
            tb_viewer.Text = "loading";
            try
            {
                // Get the URL of the web page to download
                string url = tb_uritarget.Text;

                // Download the web page content asynchronously
                string pageContent = await _parser.GetViewAsync(url);
                tb_viewer.Text = pageContent;
                var filename = Path.GetFileName(url);

                // Prompt the user to select a save location
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.FileName = filename;
                saveFileDialog.Filter = "HTML Files|*.html|CSS Files|*.css|JavaScript Files|*.js|All Files|*.*";
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Save the file to the selected path
                    File.WriteAllText(saveFileDialog.FileName, pageContent);
                    MessageBox.Show("File saved successfully.");
                }
            }
            catch (Exception ex)
            {
                // Display any errors that occurred during the download
                //MessageBox.Show($"An error occurred while downloading the web page: {ex.Message}");
                bt_download.Text = ex.Message;
            }
            finally
            {
                // Re-enable the download button when the download is complete
                bt_download.Enabled = true;
            }


        }
    }
}