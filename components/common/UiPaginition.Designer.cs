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
            btnPrevious.Size = new Size(30, 30);
            btnPrevious.TabIndex = 0;
            btnPrevious.Text = "⮜";

            btnPrevious.BackColor = ColorTranslator.FromHtml("#231F1F");
            btnPrevious.ForeColor = Color.White;
            btnPrevious.FlatStyle = FlatStyle.Flat;
            btnPrevious.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            // Hover và viền
            btnPrevious.FlatAppearance.BorderSize = 0;
            btnPrevious.FlatAppearance.MouseOverBackColor = ColorTranslator.FromHtml("#3A3737");
            // Đổi con trỏ khi hover
            btnPrevious.Cursor = Cursors.Hand;
            btnPrevious.Click += BtnPrevious_Click;
            // 
            // btnNext
            // 
            btnNext.Location = new Point(0, 0);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(30, 30);
            btnNext.TabIndex = 2;
            btnNext.Text = "⮞";
            btnNext.BackColor = ColorTranslator.FromHtml("#231F1F");
            btnNext.ForeColor = Color.White;
            btnNext.FlatStyle = FlatStyle.Flat;
            btnNext.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            // Hover và viền
            btnNext.FlatAppearance.BorderSize = 0;
            btnNext.FlatAppearance.MouseOverBackColor = ColorTranslator.FromHtml("#3A3737");
            // Đổi con trỏ khi hover
            btnNext.Cursor = Cursors.Hand;

            btnNext.Click += BtnNext_Click;
            // 
            // pnlPages
            // 
            pnlPages.AutoSize = true;
            pnlPages.Controls.Add(btnPrevious);
            pnlPages.Location = new Point(0, 0);
            pnlPages.Name = "pnlPages";
            pnlPages.Size = new Size(30, 30);
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
