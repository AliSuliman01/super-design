using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace myImageButton
{
    public partial class CustomImageButton: PictureBox
    {
        public CustomImageButton()
        {
            InitializeComponent();
        }

        private Image Normal_Image;
        private Image Hovered_Image;

        public Image Image_Normal
        {
            get { return Normal_Image; }
            set { Normal_Image = value; }
        }

        public Image Image_Hovered
        {
            get { return Hovered_Image; }
            set { Hovered_Image = value; }
        }

        private void CustomImageButton_MouseHover(object sender, EventArgs e)
        {
            this.Image = Hovered_Image;
        }

        private void CustomImageButton_MouseLeave(object sender, EventArgs e)
        {
            this.Image = Normal_Image;
        }
    }
}
