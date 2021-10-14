using System;
using System.Collections.Generic;
using System.Linq;
using FaceRecognitionDotNet;
using System.Drawing;
using System.IO;


namespace Distance
{
    class api
    {
        public static FaceRecognition _FaceRecognition;
        public static bool isLoadModel = false;
        public static bool LoadModelFace(string modelPath, string optProcess)
        {
            var dllDirectory = @"D:\FSI\Distance\Distance\DLL" + optProcess;
            Environment.SetEnvironmentVariable("PATH", Environment.GetEnvironmentVariable("PATH") + ";" + dllDirectory);
            _FaceRecognition = FaceRecognition.Create(modelPath);
            return true;
        }

        /*Face Detection*/
        public static List<Location> FaceDetect(string imageToCheck, Model model)
        {
            List<Location> lisFaceBoxes = new List<Location>();

            using (var unknownImage = FaceRecognition.LoadImageFile(imageToCheck))
            {
                var faceLocations = _FaceRecognition.FaceLocations(unknownImage, 0, model).ToArray();
                foreach (var faceLocation in faceLocations)
                    lisFaceBoxes.Add(faceLocation);
            }
            return lisFaceBoxes;
        }

        /*Similar Calculate*/
        public static double Distance2Images(string perPath1, string perPath2)
        {
            var img1 = FaceRecognition.LoadImageFile(perPath1);
            var img2 = FaceRecognition.LoadImageFile(perPath2);
            var endcodings1 = _FaceRecognition.FaceEncodings(img1).ToArray();
            var endcodings2 = _FaceRecognition.FaceEncodings(img2).ToArray();
            double distance = FaceRecognition.FaceDistance(endcodings1.First(), endcodings2.First());
            return distance;
        }

        public static void Detector(string image, string output)
        {
            if (!isLoadModel)
            {
                LoadModelFace(@"D:\FSI\Distance\Distance\Models", @"D:\FSI\Distance\Distance\DLL\cpu");
            }
            Bitmap bmp = new Bitmap(image);
            Graphics graphic = Graphics.FromImage(bmp);
            List<Location> lisFaceBoxes = FaceDetect(image, Model.Hog);
            for (int i = 0; i < lisFaceBoxes.Count; i++)
            {
                Console.WriteLine("Face {0}: {1} {2} {3} {4}", i, lisFaceBoxes[i].Left, lisFaceBoxes[i].Top, lisFaceBoxes[i].Right, lisFaceBoxes[i].Bottom);
                graphic.DrawRectangle(new Pen(Color.Red, 2), new Rectangle(lisFaceBoxes[i].Left, lisFaceBoxes[i].Top, lisFaceBoxes[i].Right - lisFaceBoxes[i].Left, lisFaceBoxes[i].Bottom - lisFaceBoxes[i].Top));
            }
            bmp.Save(output);
        }

        public static void Train_To_Slpit(string datafolder2, string path_train, string path_test)
        {
                string[] datafolder = Directory.GetDirectories(datafolder2);
                foreach (string folder in datafolder)
                {
                    List<string> X = new List<string>();
                    string curr_path = Path.Combine(datafolder2, folder);
                    if (!Directory.Exists(path_train + "/" + Path.GetFileName(folder)))
                    {
                        Directory.CreateDirectory(path_train + "/" + Path.GetFileName(folder));
                    }
                    if (!Directory.Exists(path_test))
                    {
                        Directory.CreateDirectory(path_test);
                    }
                    string[] File_List = Directory.GetFiles(curr_path);
                    foreach (string file in File_List)
                    {
                        string curr_file = Path.Combine(curr_path, file);
                        if (curr_file.Length != 0)
                            X.Add(Path.GetFileName(file));
                    }
                    List<string> train_Set = new List<string>();
                    List<string> test_Set = new List<string>();
                    for (int i = 0; i < X.Count; i++)
                    {
                        if (i <= X.Count * 0.8)
                            train_Set.Add(X[i]);
                        else
                            test_Set.Add(X[i]);
                    }
                    foreach (string f in train_Set)
                    {
                        File.Copy(Path.Combine(curr_path, f), Path.Combine(path_train + "/" + Path.GetFileName(folder), f), true);
                    }
                    foreach (string f in test_Set)
                    {
                        File.Copy(Path.Combine(curr_path, f), Path.Combine(path_test, Path.GetFileName(folder) + "_" + f),true);
                    }
                }
        }


        public static void train(string path_train)
        {
            List<string> Names = new List<string>();
            List<string> Encodings = new List<string>();
            string[] datafolder = Directory.GetDirectories(path_train);
            foreach (string folder in datafolder)
            {
                string curr_path = Path.Combine(path_train, folder);
                string[] File_List = Directory.GetFiles(curr_path);
                foreach (string file in File_List)
                {
                   
                    string curr_file = Path.Combine(curr_path, file); //curr_file: D:\FSI\Distance\Distance\TrainDotNet\AlainDelon\1 (2).jpg, ...
                    Console.WriteLine(curr_file);
                    var image = FaceRecognition.LoadImageFile(curr_file);
                    var face_bounding_boxes = _FaceRecognition.FaceLocations(image).ToArray();
                    List<Location> lisFaceBoxes = new List<Location>();
                    foreach(var faceLocation in face_bounding_boxes)
                    {
                        lisFaceBoxes.Add(faceLocation);
                    }
                    if (lisFaceBoxes.Count != 1)
                    {
                        Console.WriteLine("Image not suitable for training");
                    }
                    //Console.WriteLine(image);
                    //FaceEncoding[] faces_encodings = _FaceRecognition.FaceEncodings(image).ToArray();
                    var faces_encodings = _FaceRecognition.FaceEncodings(image).ToArray();
                    Encodings.Add(faces_encodings.First().ToString());
                    // Console.WriteLine(Encodings[0]);
                    Names.Add(Path.GetFileName(folder));
                    // Console.WriteLine(Names[0]);
                }
            }
            //var svm = new SupportVectorMachine("poly", 0);
            //svm.gamma = 1.0;
            //svm.coef = 0.0;
            //svm.degree = 2;
        }

        public static void TestImage(string ImageTest)
        {
            var X_img = FaceRecognition.LoadImageFile(ImageTest);
            var face_bounding_boxes = _FaceRecognition.FaceLocations(X_img).ToArray();
            var face_encodings = _FaceRecognition.FaceEncodings(X_img).ToArray();
        }
    }
}
