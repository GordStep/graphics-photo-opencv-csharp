namespace graphics_photo_opencv
{
    partial class FormInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormInfo));
            this.pictureBoxIcon = new System.Windows.Forms.PictureBox();
            this.linkLabelCode = new System.Windows.Forms.LinkLabel();
            this.labelInfo = new System.Windows.Forms.Label();
            this.labelVersion = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxIcon
            // 
            this.pictureBoxIcon.Location = new System.Drawing.Point(29, 12);
            this.pictureBoxIcon.Name = "pictureBoxIcon";
            this.pictureBoxIcon.Size = new System.Drawing.Size(222, 137);
            this.pictureBoxIcon.TabIndex = 0;
            this.pictureBoxIcon.TabStop = false;
            // 
            // linkLabelCode
            // 
            this.linkLabelCode.ActiveLinkColor = System.Drawing.Color.Red;
            this.linkLabelCode.AutoSize = true;
            this.linkLabelCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabelCode.Location = new System.Drawing.Point(26, 254);
            this.linkLabelCode.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.linkLabelCode.Name = "linkLabelCode";
            this.linkLabelCode.Size = new System.Drawing.Size(137, 15);
            this.linkLabelCode.TabIndex = 12;
            this.linkLabelCode.TabStop = true;
            this.linkLabelCode.Text = "Исходный код (GitHub)";
            this.linkLabelCode.VisitedLinkColor = System.Drawing.Color.DarkGray;
            this.linkLabelCode.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelCode_LinkClicked);
            // 
            // labelInfo
            // 
            this.labelInfo.Location = new System.Drawing.Point(26, 152);
            this.labelInfo.Name = "labelInfo";
            this.labelInfo.Size = new System.Drawing.Size(225, 102);
            this.labelInfo.TabIndex = 13;
            // 
            // labelVersion
            // 
            this.labelVersion.AutoSize = true;
            this.labelVersion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelVersion.Location = new System.Drawing.Point(26, 269);
            this.labelVersion.Name = "labelVersion";
            this.labelVersion.Size = new System.Drawing.Size(55, 15);
            this.labelVersion.TabIndex = 14;
            this.labelVersion.Text = "Версия: ";
            // 
            // FormInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 361);
            this.Controls.Add(this.labelVersion);
            this.Controls.Add(this.labelInfo);
            this.Controls.Add(this.linkLabelCode);
            this.Controls.Add(this.pictureBoxIcon);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormInfo";
            this.Text = "О программе";
            this.Load += new System.EventHandler(this.FormInfo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxIcon;
        private System.Windows.Forms.LinkLabel linkLabelCode;
        private System.Windows.Forms.Label labelInfo;
        private System.Windows.Forms.Label labelVersion;
    }
}