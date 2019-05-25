using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImageShower
{
    public partial class FullScreen : Form
    {
        Image img;
        public FullScreen(Image image)
        {
            InitializeComponent();
            img = image;
        }

        private void FullScreen_Load(object sender, EventArgs e)
        {
            pictureBox1.Image = img;
        }

        private void FullScreen_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Escape)
            {
                this.Close();
                MainScreen ms = new MainScreen();
                ms.Show();
            }
        }
    }
}
