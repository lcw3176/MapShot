using System;
using System.Threading;
using System.Windows.Forms;

namespace MapShot
{
    public partial class Form1 : Form
    {

        private CaptureManager capture = new CaptureManager();

        public Form1()
        {
            InitializeComponent();
            webBrowser1.Navigate("https://map.kakao.com/");
            capture.add += AddCount;
            LevelCombobox.SelectedIndex = 0;
        }

        private void captureButton_Click(object sender, EventArgs e)
        {
            string qstr = (string)coTextbox.Text.Trim();
            int zoomLevel = LevelCombobox.SelectedIndex + 17;
            int zoom = zoomComboBox.SelectedIndex;

            if (LevelCombobox.SelectedIndex == 1) { zoom = ultraZoomComboBox.SelectedIndex; }

            int blockNum = (int)Math.Pow((2 * (zoom + 1) + 1), 2);

            if(string.IsNullOrEmpty(qstr) || string.IsNullOrEmpty(zoom.ToString()))
            {
                MessageBox.Show("빈칸을 모두 기입해 주세요.", "알림");
                return;
            }

            using (FolderBrowserDialog folder = new FolderBrowserDialog())
            {
                if (folder.ShowDialog() == DialogResult.OK)
                {
                    string path = folder.SelectedPath;

                    progressBar1.Value = 0;
                    progressBar1.Maximum = blockNum + 1;

                    Thread thread = new Thread(() => capture.StartCapture(qstr, blockNum, path, zoomLevel.ToString()));
                    thread.Start();
                }
            }
        }

        private void AddCount(int value)
        {
            this.Invoke(new Action(delegate ()
            {
                progressBar1.Value++;
            }));

        }

        private void LevelCombobox_SelectedChanged(object sender, EventArgs e)
        {
            if(LevelCombobox.SelectedIndex == 0)
            {
                zoomComboBox.Visible = true;
                ultraZoomComboBox.Visible = false;
            }
            else
            {
                zoomComboBox.Visible = false;
                ultraZoomComboBox.Visible = true;
            }
        }
    }
}
