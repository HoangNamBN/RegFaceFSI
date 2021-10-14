namespace Distance
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.picInput = new System.Windows.Forms.PictureBox();
            this.picTest = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnImageTest = new System.Windows.Forms.Button();
            this.btnDistance = new System.Windows.Forms.Button();
            this.txtDistance = new System.Windows.Forms.TextBox();
            this.txtKetLuan = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureChuyen1 = new System.Windows.Forms.PictureBox();
            this.pictureChuyen2 = new System.Windows.Forms.PictureBox();
            this.btnChuyen1 = new System.Windows.Forms.Button();
            this.btnChuyen2 = new System.Windows.Forms.Button();
            this.btnInputImage = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTest)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureChuyen1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureChuyen2)).BeginInit();
            this.SuspendLayout();
            // 
            // picInput
            // 
            this.picInput.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picInput.Location = new System.Drawing.Point(30, 82);
            this.picInput.Name = "picInput";
            this.picInput.Size = new System.Drawing.Size(160, 165);
            this.picInput.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picInput.TabIndex = 0;
            this.picInput.TabStop = false;
            // 
            // picTest
            // 
            this.picTest.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picTest.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picTest.Location = new System.Drawing.Point(455, 82);
            this.picTest.Name = "picTest";
            this.picTest.Size = new System.Drawing.Size(160, 165);
            this.picTest.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picTest.TabIndex = 1;
            this.picTest.TabStop = false;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(61, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ảnh 1";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(488, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 23);
            this.label2.TabIndex = 3;
            this.label2.Text = "Ảnh 2";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(212, 318);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "Distance";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(212, 371);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 19);
            this.label4.TabIndex = 5;
            this.label4.Text = "Kết luận";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnImageTest
            // 
            this.btnImageTest.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImageTest.Location = new System.Drawing.Point(593, 253);
            this.btnImageTest.Name = "btnImageTest";
            this.btnImageTest.Size = new System.Drawing.Size(114, 35);
            this.btnImageTest.TabIndex = 7;
            this.btnImageTest.Text = "Tải ảnh";
            this.btnImageTest.UseVisualStyleBackColor = true;
            this.btnImageTest.Click += new System.EventHandler(this.btnImageTest_Click);
            // 
            // btnDistance
            // 
            this.btnDistance.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDistance.Location = new System.Drawing.Point(525, 448);
            this.btnDistance.Name = "btnDistance";
            this.btnDistance.Size = new System.Drawing.Size(149, 38);
            this.btnDistance.TabIndex = 8;
            this.btnDistance.Text = "Tính Distance";
            this.btnDistance.UseVisualStyleBackColor = true;
            this.btnDistance.Click += new System.EventHandler(this.btnDistance_Click);
            // 
            // txtDistance
            // 
            this.txtDistance.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDistance.Location = new System.Drawing.Point(301, 313);
            this.txtDistance.Name = "txtDistance";
            this.txtDistance.Size = new System.Drawing.Size(298, 27);
            this.txtDistance.TabIndex = 9;
            // 
            // txtKetLuan
            // 
            this.txtKetLuan.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKetLuan.Location = new System.Drawing.Point(301, 371);
            this.txtKetLuan.Name = "txtKetLuan";
            this.txtKetLuan.Size = new System.Drawing.Size(298, 27);
            this.txtKetLuan.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(287, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(281, 28);
            this.label5.TabIndex = 11;
            this.label5.Text = "Xác Thực Hai Khuôn Mặt";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(694, 448);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(149, 38);
            this.button1.TabIndex = 12;
            this.button1.Text = "Làm Mới";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureChuyen1
            // 
            this.pictureChuyen1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureChuyen1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureChuyen1.Location = new System.Drawing.Point(255, 82);
            this.pictureChuyen1.Name = "pictureChuyen1";
            this.pictureChuyen1.Size = new System.Drawing.Size(160, 165);
            this.pictureChuyen1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureChuyen1.TabIndex = 13;
            this.pictureChuyen1.TabStop = false;
            // 
            // pictureChuyen2
            // 
            this.pictureChuyen2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureChuyen2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureChuyen2.Location = new System.Drawing.Point(680, 82);
            this.pictureChuyen2.Name = "pictureChuyen2";
            this.pictureChuyen2.Size = new System.Drawing.Size(160, 165);
            this.pictureChuyen2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureChuyen2.TabIndex = 14;
            this.pictureChuyen2.TabStop = false;
            // 
            // btnChuyen1
            // 
            this.btnChuyen1.BackColor = System.Drawing.Color.Transparent;
            this.btnChuyen1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnChuyen1.BackgroundImage")));
            this.btnChuyen1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnChuyen1.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChuyen1.Location = new System.Drawing.Point(196, 145);
            this.btnChuyen1.Name = "btnChuyen1";
            this.btnChuyen1.Size = new System.Drawing.Size(53, 35);
            this.btnChuyen1.TabIndex = 15;
            this.btnChuyen1.UseVisualStyleBackColor = false;
            // 
            // btnChuyen2
            // 
            this.btnChuyen2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnChuyen2.BackgroundImage")));
            this.btnChuyen2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnChuyen2.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChuyen2.Location = new System.Drawing.Point(621, 145);
            this.btnChuyen2.Name = "btnChuyen2";
            this.btnChuyen2.Size = new System.Drawing.Size(53, 35);
            this.btnChuyen2.TabIndex = 16;
            this.btnChuyen2.UseVisualStyleBackColor = true;
            // 
            // btnInputImage
            // 
            this.btnInputImage.BackColor = System.Drawing.Color.Transparent;
            this.btnInputImage.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInputImage.Location = new System.Drawing.Point(170, 253);
            this.btnInputImage.Name = "btnInputImage";
            this.btnInputImage.Size = new System.Drawing.Size(121, 35);
            this.btnInputImage.TabIndex = 6;
            this.btnInputImage.Text = "Tải ảnh";
            this.btnInputImage.UseVisualStyleBackColor = false;
            this.btnInputImage.Click += new System.EventHandler(this.btnInputImage_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(855, 509);
            this.Controls.Add(this.btnChuyen2);
            this.Controls.Add(this.btnChuyen1);
            this.Controls.Add(this.pictureChuyen2);
            this.Controls.Add(this.pictureChuyen1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtKetLuan);
            this.Controls.Add(this.txtDistance);
            this.Controls.Add(this.btnDistance);
            this.Controls.Add(this.btnImageTest);
            this.Controls.Add(this.btnInputImage);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.picTest);
            this.Controls.Add(this.picInput);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.picInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTest)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureChuyen1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureChuyen2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picInput;
        private System.Windows.Forms.PictureBox picTest;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnImageTest;
        private System.Windows.Forms.Button btnDistance;
        private System.Windows.Forms.TextBox txtDistance;
        private System.Windows.Forms.TextBox txtKetLuan;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureChuyen1;
        private System.Windows.Forms.PictureBox pictureChuyen2;
        private System.Windows.Forms.Button btnChuyen1;
        private System.Windows.Forms.Button btnChuyen2;
        private System.Windows.Forms.Button btnInputImage;
    }
}

