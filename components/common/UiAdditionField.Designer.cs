namespace IdCard.Hanel_obj.components.common
{
    partial class UiAdditionField
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
            flowPn = new FlowLayoutPanel();
            panel1 = new Panel();
            btnDelete = new Button();
            btnEdit = new Button();
            flowPn.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // _lbTitle
            // 
            _lbTitle.AutoSize = true;
            _lbTitle.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            _lbTitle.Location = new Point(3, 0);
            _lbTitle.Name = "_lbTitle";
            _lbTitle.Size = new Size(91, 38);
            _lbTitle.TabIndex = 0;
            _lbTitle.Text = "label1";
            // 
            // flowPn
            // 
            flowPn.Controls.Add(panel1);
            flowPn.FlowDirection = FlowDirection.TopDown;
            flowPn.Location = new Point(0, 0);
            flowPn.Name = "flowPn";
            flowPn.Size = new Size(452, 117);
            flowPn.TabIndex = 1;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnDelete);
            panel1.Controls.Add(btnEdit);
            panel1.Controls.Add(_lbTitle);
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(446, 52);
            panel1.TabIndex = 1;
            // 
            // btnDelete
            // 
            btnDelete.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDelete.Location = new Point(356, 6);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(85, 46);
            btnDelete.TabIndex = 1;
            btnDelete.Text = "Del";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += BtnDelete_Click;
            // 
            // btnEdit
            // 
            btnEdit.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEdit.Location = new Point(265, 6);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(85, 46);
            btnEdit.TabIndex = 1;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += BtnEdit_Click;
            // 
            // UiAdditionField
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(flowPn);
            Name = "UiAdditionField";
            Size = new Size(452, 113);
            flowPn.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label _lbTitle;
        private FlowLayoutPanel flowPn;
        private Panel panel1;
        private Button btnEdit;
        private Button btnDelete;
    }
}
