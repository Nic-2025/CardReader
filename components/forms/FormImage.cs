using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IdCard.Hanel_obj.components.forms
{
    public partial class FormImage : Form
    {
        public string ImagePath { get; set; } = "";

        public FormImage(string path)
        {
            this.ImagePath = path;
            InitializeComponent();
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            if (File.Exists(ImagePath))
            {
                var image = Image.FromFile(ImagePath);
                pbImage.Image = image;

                // Adjust form and PictureBox size to fit the image
                this.ClientSize = new Size(image.Width, image.Height);
                pbImage.Size = image.Size;
            }
            else
            {
                MessageBox.Show("Image file not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
