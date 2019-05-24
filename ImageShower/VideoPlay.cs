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
    public partial class VideoPlay : Form
    {
        String File_Name;
        public VideoPlay(String FileName)
        {
            InitializeComponent();
            File_Name = FileName;
        }

        private void VideoPlay_Load(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = File_Name;
            axWindowsMediaPlayer1.Ctlcontrols.play();

        }

        private void VideoPlay_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Escape)
            {
                this.Close();
                MainScreen ms = new MainScreen();
                ms.Show();
            }
        }

        private void axWindowsMediaPlayer1_KeyPressEvent(object sender, AxWMPLib._WMPOCXEvents_KeyPressEvent e)
        {
            if (e.nKeyAscii==(char)Keys.Escape)
            {
                this.Close();
                MainScreen ms = new MainScreen();
                ms.Show();
            }

        }
    }
}
