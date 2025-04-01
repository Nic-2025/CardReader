namespace IdCard.Hanel_obj.components.common
{
    partial class UiFormComponent
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
            pnFormField = new FlowLayoutPanel();
            SuspendLayout();
            // 
            // pnFormField
            // 
            pnFormField.AutoScroll = true;
            pnFormField.Dock = DockStyle.Fill;
            pnFormField.FlowDirection = FlowDirection.TopDown;
            pnFormField.Location = new Point(16, 16);
            pnFormField.Name = "pnFormField";
            pnFormField.Size = new Size(543, 622);
            pnFormField.TabIndex = 4;
            // 
            // UiFormThongTin
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(pnFormField);
            Name = "UiFormThongTin";
            Padding = new Padding(16);
            Size = new Size(575, 654);
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel pnFormField;
    }
}
