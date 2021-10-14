using System;
using System.Windows.Forms;
using FaceRecognitionDotNet;

namespace Distance
{
    public partial class Form1 : Form
    {
        public static FaceRecognition _FaceRecognition;
        public static string Imginput;
        public static string ImgTest;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnInputImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlgOpen = new OpenFileDialog();
            dlgOpen.Filter = "JPEG(*.jpg)|*.jpg|GIF(*.gif)|*.gif|Bitmap(*.bmp)|*.bmp|All files(*.*)|*.*";
            dlgOpen.FilterIndex = 1;
            dlgOpen.RestoreDirectory = true;
            if (dlgOpen.ShowDialog() == DialogResult.OK)
            {
                picInput.ImageLocation = dlgOpen.FileName;
                Imginput = dlgOpen.FileName;
                Imginput = Imginput.Replace("\\", "\\\\");
                api.Detector(Imginput, @"D:\FSI\Distance\Distance\image\input.jpg");
                pictureChuyen1.Image = System.Drawing.Image.FromFile(@"D:\FSI\Distance\Distance\image\input.jpg");
            }
        }

        private void btnImageTest_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlgOpen = new OpenFileDialog();
            dlgOpen.Filter = "JPEG(*.jpg)|*.jpg|GIF(*.gif)|*.gif|Bitmap(*.bmp)|*.bmp|All files(*.*)|*.*";
            dlgOpen.FilterIndex = 1;
            dlgOpen.RestoreDirectory = true;
            if (dlgOpen.ShowDialog() == DialogResult.OK)
            {
                picTest.ImageLocation = dlgOpen.FileName;
                ImgTest = dlgOpen.FileName;
                ImgTest = ImgTest.Replace("\\", "\\\\");
                api.Detector(ImgTest, @"D:\FSI\Distance\Distance\image\test.jpg");
                pictureChuyen2.Image = System.Drawing.Image.FromFile(@"D:\FSI\Distance\Distance\image\test.jpg");
            }
        }

        private void btnDistance_Click(object sender, EventArgs e)
        {
            if (!api.isLoadModel)
            {
                api.LoadModelFace(@"D:\FSI\Distance\Distance\Models", @"D:\FSI\Distance\Distance\DLL\cpu");
            }
            double distance = api.Distance2Images(Imginput, ImgTest);
            txtDistance.Text = distance.ToString();
            if (distance < 0.6)
            {
                txtKetLuan.Text = "Hai ảnh là một người";
            }
            else
            {
                txtKetLuan.Text = "Hai ảnh là hai người khác nhau";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtKetLuan.Text = "";
            txtDistance.Text = "";
            picInput.Image = null;
            picTest.Image = null;
            pictureChuyen1.Image = null;
            pictureChuyen2.Image = null;
        }
    }
}
