using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using FaceRecognitionDotNet;

namespace Distance
{
    public partial class FaceRecognition_FSI : Form
    {
        public static string Imgtest;
        public static string ImgResult;
        public FaceRecognition_FSI()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dlg = new FolderBrowserDialog();
            dlg.Description = "Hãy chọn thư mục để chia tập train và test cho bài toán";
            dlg.ShowNewFolderButton = false;
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                string folder;
                folder = dlg.SelectedPath;
                txtPath.Text = dlg.SelectedPath;
            }
        }

        private void btnSlipitDataSet_Click(object sender, EventArgs e)
        {
            api.Train_To_Slpit(txtPath.Text, @"D:\FSI\Distance\Distance\TrainDotNet", @"D:\FSI\Distance\Distance\TestDotNet");
            List<string> X_Train = new List<string>();
            string[] datafolder = Directory.GetDirectories(@"D:\FSI\Distance\Distance\TrainDotNet");
            foreach (string folder in datafolder)
            {
                string curr_path = Path.Combine(@"D:\FSI\Distance\Distance\TrainDotNet", folder);
                string[] File_List = Directory.GetFiles(curr_path);
                foreach (string file in File_List)
                {
                    string curr_file = Path.Combine(curr_path, file);
                    if (curr_file.Length != 0)
                        X_Train.Add(Path.GetFileName(file));
                }
            }
            txtTrain.Text = Convert.ToInt32(X_Train.Count).ToString();
            DirectoryInfo dir = new DirectoryInfo(@"D:\FSI\Distance\Distance\TestDotNet");
            int count = dir.GetFiles().Length;
            txtTest.Text = count.ToString();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtPath.Text = "";
            txtTest.Text = "";
            txtTrain.Text = "";
        }

        private void btnDetectorAndDistance_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlgOpen = new OpenFileDialog();
            dlgOpen.Filter = "JPEG(*.jpg)|*.jpg|GIF(*.gif)|*.gif|Bitmap(*.bmp)|*.bmp|All files(*.*)|*.*";
            dlgOpen.FilterIndex = 1;
            dlgOpen.RestoreDirectory = true;
            if (dlgOpen.ShowDialog() == DialogResult.OK)
            {
                picimagetest.ImageLocation = dlgOpen.FileName;
                Imgtest = dlgOpen.FileName;
                Imgtest = Imgtest.Replace("\\", "\\\\");
                api.Detector(Imgtest, @"D:\FSI\Distance\Distance\image\input.jpg");
                picimagetest.Image = System.Drawing.Image.FromFile(@"D:\FSI\Distance\Distance\image\input.jpg");
            }

        }

        private void btnTrainFace_Click(object sender, EventArgs e)
        {
            api.train(@"D:\FSI\Distance\Distance\TrainDotNet");
        }


    }
}
