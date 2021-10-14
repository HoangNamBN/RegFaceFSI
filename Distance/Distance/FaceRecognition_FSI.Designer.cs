namespace Distance
{
    partial class FaceRecognition_FSI
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtPath = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.btnSlipitDataSet = new System.Windows.Forms.Button();
            this.txtTrain = new System.Windows.Forms.TextBox();
            this.txtTest = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnDetectorAndDistance = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnTrainFace = new System.Windows.Forms.Button();
            this.picimagetest = new System.Windows.Forms.PictureBox();
            this.picimageresult = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picimagetest)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picimageresult)).BeginInit();
            this.SuspendLayout();
            // 
            // txtPath
            // 
            this.txtPath.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPath.Location = new System.Drawing.Point(101, 68);
            this.txtPath.Name = "txtPath";
            this.txtPath.Size = new System.Drawing.Size(401, 22);
            this.txtPath.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(155, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(255, 37);
            this.label2.TabIndex = 2;
            this.label2.Text = "Face Recognition using SVM";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(9, 66);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(79, 26);
            this.button1.TabIndex = 3;
            this.button1.Text = "Browse";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnSlipitDataSet
            // 
            this.btnSlipitDataSet.Location = new System.Drawing.Point(399, 415);
            this.btnSlipitDataSet.Name = "btnSlipitDataSet";
            this.btnSlipitDataSet.Size = new System.Drawing.Size(103, 45);
            this.btnSlipitDataSet.TabIndex = 4;
            this.btnSlipitDataSet.Text = "Split The DataSet";
            this.btnSlipitDataSet.UseVisualStyleBackColor = true;
            this.btnSlipitDataSet.Click += new System.EventHandler(this.btnSlipitDataSet_Click);
            // 
            // txtTrain
            // 
            this.txtTrain.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTrain.Location = new System.Drawing.Point(101, 126);
            this.txtTrain.Name = "txtTrain";
            this.txtTrain.Size = new System.Drawing.Size(101, 22);
            this.txtTrain.TabIndex = 5;
            // 
            // txtTest
            // 
            this.txtTest.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTest.Location = new System.Drawing.Point(365, 127);
            this.txtTest.Name = "txtTest";
            this.txtTest.Size = new System.Drawing.Size(101, 22);
            this.txtTest.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 22);
            this.label1.TabIndex = 8;
            this.label1.Text = "DataTrain";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(271, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 22);
            this.label3.TabIndex = 9;
            this.label3.Text = "DataTest";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(296, 415);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(88, 45);
            this.btnReset.TabIndex = 10;
            this.btnReset.Text = "ReSet";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnDetectorAndDistance
            // 
            this.btnDetectorAndDistance.Location = new System.Drawing.Point(153, 415);
            this.btnDetectorAndDistance.Name = "btnDetectorAndDistance";
            this.btnDetectorAndDistance.Size = new System.Drawing.Size(125, 45);
            this.btnDetectorAndDistance.TabIndex = 11;
            this.btnDetectorAndDistance.Text = "Detector And Distance";
            this.btnDetectorAndDistance.UseVisualStyleBackColor = true;
            this.btnDetectorAndDistance.Click += new System.EventHandler(this.btnDetectorAndDistance_Click);
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(208, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 22);
            this.label4.TabIndex = 12;
            this.label4.Text = "file";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(468, 127);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 22);
            this.label5.TabIndex = 13;
            this.label5.Text = "file";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnTrainFace
            // 
            this.btnTrainFace.Location = new System.Drawing.Point(40, 415);
            this.btnTrainFace.Name = "btnTrainFace";
            this.btnTrainFace.Size = new System.Drawing.Size(95, 45);
            this.btnTrainFace.TabIndex = 14;
            this.btnTrainFace.Text = "Train Face Recognition";
            this.btnTrainFace.UseVisualStyleBackColor = true;
            this.btnTrainFace.Click += new System.EventHandler(this.btnTrainFace_Click);
            // 
            // picimagetest
            // 
            this.picimagetest.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.picimagetest.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picimagetest.Location = new System.Drawing.Point(13, 176);
            this.picimagetest.Name = "picimagetest";
            this.picimagetest.Size = new System.Drawing.Size(190, 217);
            this.picimagetest.TabIndex = 15;
            this.picimagetest.TabStop = false;
            // 
            // picimageresult
            // 
            this.picimageresult.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.picimageresult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picimageresult.Location = new System.Drawing.Point(312, 176);
            this.picimageresult.Name = "picimageresult";
            this.picimageresult.Size = new System.Drawing.Size(190, 217);
            this.picimageresult.TabIndex = 16;
            this.picimageresult.TabStop = false;
            // 
            // FaceRecognition_FSI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(512, 472);
            this.Controls.Add(this.picimageresult);
            this.Controls.Add(this.picimagetest);
            this.Controls.Add(this.btnTrainFace);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnDetectorAndDistance);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTest);
            this.Controls.Add(this.txtTrain);
            this.Controls.Add(this.btnSlipitDataSet);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPath);
            this.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "FaceRecognition_FSI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FaceRecognition";
            ((System.ComponentModel.ISupportInitialize)(this.picimagetest)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picimageresult)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPath;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button btnSlipitDataSet;
        private System.Windows.Forms.TextBox txtTrain;
        private System.Windows.Forms.TextBox txtTest;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnDetectorAndDistance;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnTrainFace;
        private System.Windows.Forms.PictureBox picimagetest;
        private System.Windows.Forms.PictureBox picimageresult;
    }
}