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
            this.label1 = new System.Windows.Forms.Label();
            this.labelSize = new System.Windows.Forms.Label();
            this.labelFile = new System.Windows.Forms.Label();
            this.buttonGray = new System.Windows.Forms.Button();
            this.buttonGist = new System.Windows.Forms.Button();
            this.buttonLSB = new System.Windows.Forms.Button();
            this.buttonLSBGraf = new System.Windows.Forms.Button();
            this.buttonOrigImage = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Location = new System.Drawing.Point(272, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(300, 303);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Выберите фото";
            // 
            // labelSize
            // 
            this.labelSize.AutoSize = true;
            this.labelSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSize.Location = new System.Drawing.Point(16, 326);
            this.labelSize.Name = "labelSize";
            this.labelSize.Size = new System.Drawing.Size(97, 16);
            this.labelSize.TabIndex = 2;
            this.labelSize.Text = "Размер фото:";
            // 
            // labelFile
            // 
            this.labelFile.AutoEllipsis = true;
            this.labelFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFile.Location = new System.Drawing.Point(16, 342);
            this.labelFile.Name = "labelFile";
            this.labelFile.Size = new System.Drawing.Size(556, 23);
            this.labelFile.TabIndex = 3;
            this.labelFile.Text = "Название файла:";
            // 
            // buttonGray
            // 
            this.buttonGray.Location = new System.Drawing.Point(19, 114);
            this.buttonGray.Name = "buttonGray";
            this.buttonGray.Size = new System.Drawing.Size(179, 37);
            this.buttonGray.TabIndex = 4;
            this.buttonGray.Text = "Серое изображение";
            this.buttonGray.UseVisualStyleBackColor = true;
            this.buttonGray.Click += new System.EventHandler(this.buttonGray_Click);
            // 
            // buttonGist
            // 
            this.buttonGist.Location = new System.Drawing.Point(19, 157);
            this.buttonGist.Name = "buttonGist";
            this.buttonGist.Size = new System.Drawing.Size(179, 37);
            this.buttonGist.TabIndex = 5;
            this.buttonGist.Text = "Гистограмма";
            this.buttonGist.UseVisualStyleBackColor = true;
            this.buttonGist.Click += new System.EventHandler(this.buttonGist_Click);
            // 
            // buttonLSB
            // 
            this.buttonLSB.Location = new System.Drawing.Point(19, 200);
            this.buttonLSB.Name = "buttonLSB";
            this.buttonLSB.Size = new System.Drawing.Size(179, 37);
            this.buttonLSB.TabIndex = 6;
            this.buttonLSB.Text = "Получение текста (LSB)";
            this.buttonLSB.UseVisualStyleBackColor = true;
            this.buttonLSB.Click += new System.EventHandler(this.buttonLSB_Click);
            // 
            // buttonLSBGraf
            // 
            this.buttonLSBGraf.Location = new System.Drawing.Point(19, 243);
            this.buttonLSBGraf.Name = "buttonLSBGraf";
            this.buttonLSBGraf.Size = new System.Drawing.Size(179, 37);
            this.buttonLSBGraf.TabIndex = 7;
            this.buttonLSBGraf.Text = "Усиление младших битов";
            this.buttonLSBGraf.UseVisualStyleBackColor = true;
            this.buttonLSBGraf.Click += new System.EventHandler(this.buttonLSBGraf_Click);
            // 
            // buttonOrigImage
            // 
            this.buttonOrigImage.Location = new System.Drawing.Point(19, 71);
            this.buttonOrigImage.Name = "buttonOrigImage";
            this.buttonOrigImage.Size = new System.Drawing.Size(179, 37);
            this.buttonOrigImage.TabIndex = 8;
            this.buttonOrigImage.Text = "Оригинальное изображение";
            this.buttonOrigImage.UseVisualStyleBackColor = true;
            this.buttonOrigImage.Click += new System.EventHandler(this.buttonOrigImage_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 375);
            this.Controls.Add(this.buttonOrigImage);
            this.Controls.Add(this.buttonLSBGraf);
            this.Controls.Add(this.buttonLSB);
            this.Controls.Add(this.buttonGist);
            this.Controls.Add(this.buttonGray);
            this.Controls.Add(this.labelFile);
            this.Controls.Add(this.labelSize);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormMain";
            this.Text = "Лабораторная работа: Графика";
            this.Load += new System.EventHandler(this.FormMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelSize;
        private System.Windows.Forms.Label labelFile;
        private System.Windows.Forms.Button buttonGray;
        private System.Windows.Forms.Button buttonGist;
        private System.Windows.Forms.Button buttonLSB;
        private System.Windows.Forms.Button buttonLSBGraf;
        private System.Windows.Forms.Button buttonOrigImage;
    }
}