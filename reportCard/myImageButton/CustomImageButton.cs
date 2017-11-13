using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace myImageButton
{
    public partial class CustomImageButton: PictureBox
    {
        public CustomImageButton()
        {
            InitializeComponent();
        }
        private Image NormalImage;
        private Image hobverImage;
        
        public Image ImageNormal
        {
            get { return NormalImage; }
            set { NormalImage = value; }
        }
        public Image ImageHover
        {
            get { return hobverImage; }
            set { hobverImage = value; }
        }

        private void CustomImageButton_MouseHover(object sender, EventArgs e)
        {
            this.Image = hobverImage;
        }

        private void CustomImageButton_MouseLeave(object sender, EventArgs e)
        {
            this.Image = NormalImage;
        }
    }
}
