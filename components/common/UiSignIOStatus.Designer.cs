namespace IdCard.Hanel_obj.forms
{
    partial class UiSignIOStatus
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lbStatus = new Label();
            SuspendLayout();
            // 
            // lbStatus
            // 
            lbStatus.AutoSize = true;
            lbStatus.Dock = DockStyle.Fill;
            lbStatus.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbStatus.Location = new Point(0, 0);
            lbStatus.Margin = new Padding(2, 0, 2, 0);
            lbStatus.Name = "lbStatus";
            lbStatus.Size = new Size(63, 25);
            lbStatus.TabIndex = 0;
            lbStatus.Text = "label1";
            // 
            // UiSignIOStatus
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(lbStatus);
            Margin = new Padding(2);
            Name = "UiSignIOStatus";
            Size = new Size(146, 29);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbStatus;
    }
}
