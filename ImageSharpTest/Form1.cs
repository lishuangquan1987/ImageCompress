using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SixLabors.ImageSharp;
using SixLabors.ImageSharp.Formats;
using SixLabors.ImageSharp.PixelFormats;
using SixLabors.ImageSharp.Processing;
using SixLabors.ImageSharp.Formats.Jpeg;
using SixLabors.ImageSharp.Formats.Png;
using SixLabors.ImageSharp.Formats.Bmp;
using SixLabors.ImageSharp.Formats.Gif;
using System.IO;
using System.Threading;

namespace ImageSharpTest
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            

        }
        public void CompressImageJpeg(string path,int quality, JpegSubsample jpegSubsample)
        {
            IImageFormat format;
            using (var image = SixLabors.ImageSharp.Image.Load(path,out format))
            {
                string extension = ".jpg";
                JpegEncoder encoder = new JpegEncoder() { Quality = quality, Subsample = jpegSubsample };
                
                string outputPath = Path.Combine(Path.GetDirectoryName(path), Path.GetFileNameWithoutExtension(path) + "_转换后" + extension);
                int count = 0;
                while (File.Exists(outputPath))
                {
                    count++;
                    outputPath = Path.Combine(Path.GetDirectoryName(outputPath), Path.GetFileNameWithoutExtension(path) + "_转换后" + count.ToString() + extension);
                }
                image.Save(outputPath,encoder);
            }

        }

        public void CompressImagePng(string path, int quality, JpegSubsample jpegSubsample)
        {
            using (var image = SixLabors.ImageSharp.Image.Load(path))
            {
                PngEncoder encoder = new PngEncoder();

                encoder.CompressionLevel = 8;
                //JpegEncoder encoder = new JpegEncoder() { Quality = quality, Subsample = jpegSubsample };
                string outputPath = Path.Combine(Path.GetDirectoryName(path), Path.GetFileNameWithoutExtension(path) + "_转换后" + Path.GetExtension(path));
                int count = 0;
                while (File.Exists(outputPath))
                {
                    count++;
                    outputPath = Path.Combine(Path.GetDirectoryName(outputPath), Path.GetFileNameWithoutExtension(path) + count.ToString() + Path.GetExtension(outputPath));
                }
                image.Save(outputPath, encoder);
            }
        }
        private void btnBrowser_Click(object sender, EventArgs e)
        {
            this.lbFileNames.Items.Clear();
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Multiselect = true;
            var result = dialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                foreach (var file in dialog.FileNames)
                {
                    this.lbFileNames.Items.Add(file);
                }
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            int quality;
            JpegSubsample jpegSubsample = JpegSubsample.Ratio444;
            if (!int.TryParse(this.tbQuality.Text, out quality))
            {
                MessageBox.Show("压缩质量必须是介于0~100的数字");
                return;
            }
            if (quality < 0 || quality > 100)
            {
                MessageBox.Show("压缩质量必须是介于0~100的数字");
                return;
            }

            if (this.rbHigh.Checked)
            {
                jpegSubsample = JpegSubsample.Ratio444;
            }
            else
            {
                jpegSubsample = JpegSubsample.Ratio420;
            }
            if (this.lbFileNames.Items.Count == 0)
            {
                MessageBox.Show("请选择图片！");
                return;
            }
            string[] fileNames = new string[this.lbFileNames.Items.Count];
            for (int i = 0; i < this.lbFileNames.Items.Count; i++)
            {
                fileNames[i] = this.lbFileNames.Items[i].ToString();
            }

            ThreadPool.QueueUserWorkItem(x =>
            {
                ExecuteInMainThread(() =>
                {
                    this.btnBrowser.Enabled = false;
                    this.btnStart.Enabled = false;
                });

                for (int i = 0; i < fileNames.Length; i++)
                {
                    ShowMessage("正在压缩保存" + Path.GetFileName(fileNames[i]) + "...",false);
                    try
                    {
                        CompressImageJpeg(fileNames[i], quality, jpegSubsample);
                    }
                    catch (Exception ee)
                    {
                        File.AppendAllText("error.txt",DateTime.Now.ToString()+ ee.Message + ee.StackTrace+"\r\n");
                    }
                    int processValue = (i + 1) * 100 / fileNames.Length;
                    ExecuteInMainThread(() => this.processBar.Value = processValue);
                }
                ShowMessage("操作完成", false);
                ExecuteInMainThread(() =>
                {
                    this.btnBrowser.Enabled = true;
                    this.btnStart.Enabled = true;
                });
            });
        }

        public void ExecuteInMainThread(Action action)
        {
            this.Invoke(new Action(() => action()));
        }
        public void ShowMessage(string message,bool isError)
        {
            this.Invoke(new Action(() =>
            {
                if (isError)
                {
                    this.lbInfo.ForeColor = System.Drawing.Color.Red;
                }
                else
                {
                    this.lbInfo.ForeColor = System.Drawing.Color.Black;
                }
                this.lbInfo.Text = message;
            }));
        }

        private void lbFileNames_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
                if (files != null && files.Length > 0)
                {
                    for (int i = 0; i < files.Length; i++)
                    {
                        this.lbFileNames.Items.Add(files[i]);
                    }
                }
            }
        }

        private void lbFileNames_DragOver(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Move;
            }
        }

        private void 清除所有文件ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.lbFileNames.Items.Clear();
        }
    }
}
