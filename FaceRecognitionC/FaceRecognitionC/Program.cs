using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FaceRecognitionC
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            if (!api.isLoadModel)
            {
                api.LoadModelFace(@"D:\FSI\Distance\Distance\Models", @"D:\FSI\Distance\Distance\DLL\cpu");
            }
            // api.train(@"D:\FSI\Distance\Distance\TrainDotNet");
            api.ReadModelFace(@"D:\FSI\FSI_Face\examples\Test\AlainDelon_1049.jpg");
        }
    }
}
