namespace graphics_photo_opencv
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelSize = new System.Windows.Forms.Label();
            this.labelFile = new System.Windows.Forms.Label();
            this.buttonGray = new System.Windows.Forms.Button();
            this.buttonGist = new System.Windows.Forms.Button();
            this.buttonLSB = new System.Windows.Forms.Button();
            this.buttonLSBGraf = new System.Windows.Forms.Button();
            this.buttonOrigImage = new System.Windows.Forms.Button();
            this.buttonPhoto = new System.Windows.Forms.Button();
            this.labelLog = new System.Windows.Forms.Label();
            this.linkLabelCode = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(363, 15);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(400, 350);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // labelSize
            // 
            this.labelSize.AutoSize = true;
            this.labelSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSize.Location = new System.Drawing.Point(21, 401);
            this.labelSize.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelSize.Name = "labelSize";
            this.labelSize.Size = new System.Drawing.Size(127, 20);
            this.labelSize.TabIndex = 2;
            this.labelSize.Text = "Размер фото:";
            // 
            // labelFile
            // 
            this.labelFile.AutoEllipsis = true;
            this.labelFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFile.Location = new System.Drawing.Point(21, 421);
            this.labelFile.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelFile.Name = "labelFile";
            this.labelFile.Size = new System.Drawing.Size(517, 28);
            this.labelFile.TabIndex = 3;
            this.labelFile.Text = "Название файла:";
            // 
            // buttonGray
            // 
            this.buttonGray.Location = new System.Drawing.Point(25, 134);
            this.buttonGray.Margin = new System.Windows.Forms.Padding(4);
            this.buttonGray.Name = "buttonGray";
            this.buttonGray.Size = new System.Drawing.Size(239, 46);
            this.buttonGray.TabIndex = 4;
            this.buttonGray.Text = "Серое изображение";
            this.buttonGray.UseVisualStyleBackColor = true;
            this.buttonGray.Click += new System.EventHandler(this.buttonGray_Click);
            // 
            // buttonGist
            // 
            this.buttonGist.Location = new System.Drawing.Point(25, 187);
            this.buttonGist.Margin = new System.Windows.Forms.Padding(4);
            this.buttonGist.Name = "buttonGist";
            this.buttonGist.Size = new System.Drawing.Size(239, 46);
            this.buttonGist.TabIndex = 5;
            this.buttonGist.Text = "Гистограмма";
            this.buttonGist.UseVisualStyleBackColor = true;
            this.buttonGist.Click += new System.EventHandler(this.buttonGist_Click);
            // 
            // buttonLSB
            // 
            this.buttonLSB.Location = new System.Drawing.Point(25, 240);
            this.buttonLSB.Margin = new System.Windows.Forms.Padding(4);
            this.buttonLSB.Name = "buttonLSB";
            this.buttonLSB.Size = new System.Drawing.Size(239, 46);
            this.buttonLSB.TabIndex = 6;
            this.buttonLSB.Text = "Получение текста (LSB)";
            this.buttonLSB.UseVisualStyleBackColor = true;
            this.buttonLSB.Click += new System.EventHandler(this.buttonLSB_Click);
            // 
            // buttonLSBGraf
            // 
            this.buttonLSBGraf.Location = new System.Drawing.Point(25, 293);
            this.buttonLSBGraf.Margin = new System.Windows.Forms.Padding(4);
            this.buttonLSBGraf.Name = "buttonLSBGraf";
            this.buttonLSBGraf.Size = new System.Drawing.Size(239, 46);
            this.buttonLSBGraf.TabIndex = 7;
            this.buttonLSBGraf.Text = "Усиление младших битов";
            this.buttonLSBGraf.UseVisualStyleBackColor = true;
            this.buttonLSBGraf.Click += new System.EventHandler(this.buttonLSBGraf_Click);
            // 
            // buttonOrigImage
            // 
            this.buttonOrigImage.Location = new System.Drawing.Point(25, 81);
            this.buttonOrigImage.Margin = new System.Windows.Forms.Padding(4);
            this.buttonOrigImage.Name = "buttonOrigImage";
            this.buttonOrigImage.Size = new System.Drawing.Size(239, 46);
            this.buttonOrigImage.TabIndex = 8;
            this.buttonOrigImage.Text = "Оригинальное изображение";
            this.buttonOrigImage.UseVisualStyleBackColor = true;
            this.buttonOrigImage.Click += new System.EventHandler(this.buttonOrigImage_Click);
            // 
            // buttonPhoto
            // 
            this.buttonPhoto.Location = new System.Drawing.Point(25, 28);
            this.buttonPhoto.Margin = new System.Windows.Forms.Padding(4);
            this.buttonPhoto.Name = "buttonPhoto";
            this.buttonPhoto.Size = new System.Drawing.Size(239, 46);
            this.buttonPhoto.TabIndex = 9;
            this.buttonPhoto.Text = "Выбрать файл";
            this.buttonPhoto.UseVisualStyleBackColor = true;
            this.buttonPhoto.Click += new System.EventHandler(this.buttonPhoto_Click);
            // 
            // labelLog
            // 
            this.labelLog.AutoSize = true;
            this.labelLog.Location = new System.Drawing.Point(21, 372);
            this.labelLog.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelLog.Name = "labelLog";
            this.labelLog.Size = new System.Drawing.Size(73, 16);
            this.labelLog.TabIndex = 10;
            this.labelLog.Text = "Лог лабел";
            // 
            // linkLabelCode
            // 
            this.linkLabelCode.AutoSize = true;
            this.linkLabelCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabelCode.Location = new System.Drawing.Point(594, 421);
            this.linkLabelCode.Name = "linkLabelCode";
            this.linkLabelCode.Size = new System.Drawing.Size(165, 18);
            this.linkLabelCode.TabIndex = 11;
            this.linkLabelCode.TabStop = true;
            this.linkLabelCode.Text = "Исходный код(GitHub)";
            this.linkLabelCode.VisitedLinkColor = System.Drawing.Color.DarkGray;
            this.linkLabelCode.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelCode_LinkClicked);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(779, 462);
            this.Controls.Add(this.linkLabelCode);
            this.Controls.Add(this.labelLog);
            this.Controls.Add(this.buttonPhoto);
            this.Controls.Add(this.buttonOrigImage);
            this.Controls.Add(this.buttonLSBGraf);
            this.Controls.Add(this.buttonLSB);
            this.Controls.Add(this.buttonGist);
            this.Controls.Add(this.buttonGray);
            this.Controls.Add(this.labelFile);
            this.Controls.Add(this.labelSize);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormMain";
            this.Text = "Лабораторная работа: Графика";
            this.Load += new System.EventHandler(this.FormMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelSize;
        private System.Windows.Forms.Label labelFile;
        private System.Windows.Forms.Button buttonGray;
        private System.Windows.Forms.Button buttonGist;
        private System.Windows.Forms.Button buttonLSB;
        private System.Windows.Forms.Button buttonLSBGraf;
        private System.Windows.Forms.Button buttonOrigImage;
        private System.Windows.Forms.Button buttonPhoto;
        private System.Windows.Forms.Label labelLog;
        private System.Windows.Forms.LinkLabel linkLabelCode;
    }
}