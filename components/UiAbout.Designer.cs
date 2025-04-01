namespace IdCard.Hanel_obj.components
{
    partial class UiAbout
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
            _lbTitle = new Label();
            SuspendLayout();
            // 
            // _lbTitle
            // 
            _lbTitle.AutoSize = true;
            _lbTitle.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            _lbTitle.Location = new Point(45, 0);
            _lbTitle.Name = "_lbTitle";
            _lbTitle.Size = new Size(140, 54);
            _lbTitle.TabIndex = 0;
            _lbTitle.Text = "About";
            // 
            // UiAbout
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(_lbTitle);
            Name = "UiAbout";
            Size = new Size(1209, 925);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label _lbTitle;
    }
}
