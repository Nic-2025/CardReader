namespace IdCard.Hanel
{
    partial class CaptureFace
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
            picFromCamera = new PictureBox();
            btnCapture = new Button();
            btnCancel = new Button();
            ((System.ComponentModel.ISupportInitialize)picFromCamera).BeginInit();
            SuspendLayout();
            // 
            // picFromCamera
            // 
            picFromCamera.Location = new Point(19, 22);
            picFromCamera.Name = "picFromCamera";
            picFromCamera.Size = new Size(743, 418);
            picFromCamera.SizeMode = PictureBoxSizeMode.Zoom;
            picFromCamera.TabIndex = 0;
            picFromCamera.TabStop = false;
            // 
            // btnCapture
            // 
            btnCapture.Location = new Point(322, 449);
            btnCapture.Name = "btnCapture";
            btnCapture.Size = new Size(141, 48);
            btnCapture.TabIndex = 1;
            btnCapture.Text = "Chụp";
            btnCapture.UseVisualStyleBackColor = true;
            btnCapture.Click += btnCapture_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(621, 449);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(141, 48);
            btnCancel.TabIndex = 2;
            btnCancel.Text = "Bỏ qua";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // CaptureFace
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 595);
            ControlBox = false;
            Controls.Add(btnCancel);
            Controls.Add(btnCapture);
            Controls.Add(picFromCamera);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "CaptureFace";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "Chụp ảnh khuôn mặt";
            FormClosing += CaptureFace_FormClosing;
            FormClosed += CaptureFace_FormClosed;
            Load += CaptureFace_Load;
            Shown += CaptureFace_Shown;
            ((System.ComponentModel.ISupportInitialize)picFromCamera).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox picFromCamera;
        private Button btnCapture;
        private Button btnCancel;
    }
}