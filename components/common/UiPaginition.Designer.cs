namespace IdCard.Hanel_obj.components
{
    partial class UiPaginition
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        private Button btnPrevious;
        private Button btnNext;
        private FlowLayoutPanel pnlPages;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise.</param>
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
            btnPrevious = new Button();
            btnNext = new Button();
            pnlPages = new FlowLayoutPanel();
            pnlPages.SuspendLayout();
            SuspendLayout();
            // 
            // btnPrevious
            // 
            btnPrevious.Location = new Point(3, 3);
            btnPrevious.Name = "btnPrevious";
            btnPrevious.Size = new Size(100, 50);
            btnPrevious.TabIndex = 0;
            btnPrevious.Text = "<";
            btnPrevious.Click += BtnPrevious_Click;
            // 
            // btnNext
            // 
            btnNext.Location = new Point(0, 0);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(75, 23);
            btnNext.TabIndex = 2;
            btnNext.Text = ">";
            btnNext.Click += BtnNext_Click;
            // 
            // pnlPages
            // 
            pnlPages.AutoSize = true;
            pnlPages.Controls.Add(btnPrevious);
            pnlPages.Location = new Point(0, 0);
            pnlPages.Name = "pnlPages";
            pnlPages.Size = new Size(912, 57);
            pnlPages.TabIndex = 1;
            // 
            // UiPaginition
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(pnlPages);
            Controls.Add(btnNext);
            Name = "UiPaginition";
            Size = new Size(915, 61);
            pnlPages.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
    }
}
