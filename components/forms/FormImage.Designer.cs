namespace IdCard.Hanel_obj.components.forms
{
    partial class FormImage
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
            pbImage = new PictureBox();
            label1 = new Label();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)pbImage).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // pbImage
            // 
            pbImage.Dock = DockStyle.Fill;
            pbImage.Location = new Point(0, 0);
            pbImage.Margin = new Padding(2);
            pbImage.Name = "pbImage";
            pbImage.Size = new Size(278, 289);
            pbImage.TabIndex = 0;
            pbImage.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            label1.Location = new Point(85, 18);
            label1.Name = "label1";
            label1.Size = new Size(174, 32);
            label1.TabIndex = 1;
            label1.Text = "Ảnh Signed in";
            // 
            // panel1
            // 
            panel1.Controls.Add(pbImage);
            panel1.Location = new Point(31, 80);
            panel1.Name = "panel1";
            panel1.Size = new Size(278, 289);
            panel1.TabIndex = 3;
            // 
            // FormImage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(342, 429);
            Controls.Add(panel1);
            Controls.Add(label1);
            Margin = new Padding(2);
            Name = "FormImage";
            Text = "FormImage";
            ((System.ComponentModel.ISupportInitialize)pbImage).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pbImage;
        private Label label1;
        private Panel panel1;
    }
}