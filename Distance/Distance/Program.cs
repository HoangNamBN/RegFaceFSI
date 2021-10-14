using System;
using System.Windows.Forms;

namespace Distance
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            if (!api.isLoadModel)
            {
                api.LoadModelFace(@"D:\FSI\Distance\Distance\Models", @"D:\FSI\Distance\Distance\DLL\cpu");
            }
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FaceRecognition_FSI());
        }
    }
}
