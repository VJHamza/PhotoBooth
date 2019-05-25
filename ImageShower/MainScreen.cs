using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace ImageShower
{
    public partial class MainScreen : Form
    {
        
        public MainScreen()
        {
            InitializeComponent();
        }

        //public static Image image;
        //public static Image image1
        //{
        //    get { return image; }
        //    set { image = value; }
        //}
        //public static Image image2
        //{
        //    get { return image; }
        //    set { image = value; }
        //}
        //public static Image image3
        //{
        //    get { return image; }
        //    set { image = value; }
        //}

        //public void ShowForm()
        //{
        //    Form form = Form.ActiveForm;
        //    FullScreen fs = new FullScreen();
        //    fs.Show();
        //}
        //private void pb1_Click(object sender, EventArgs e)
        //{
        //    image = pb1.Image;
        //    this.Hide();
        //    ShowForm();
            
        //}

        //private void pb2_Click(object sender, EventArgs e)
        //{
        //    image = pb2.Image;
        //    this.Hide();
        //    ShowForm();
        //}

        //private void pb3_Click(object sender, EventArgs e)
        //{
        //    image = pb3.Image;
        //    this.Hide();
        //    ShowForm();
        //}

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            OpenFileDialog openFileDialogue = new OpenFileDialog();
            if (openFileDialogue.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                this.textBox1.Text = openFileDialogue.FileName;
                

            }

        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            String fileName = this.textBox1.Text;
            if (fileName=="" )
            {
                MessageBox.Show("Select the media file!");

            }
            else
            {
                VideoPlay videoPlay = new VideoPlay(fileName);
                this.Hide();
                videoPlay.Show();
            }
            
        }
        public void FillPanel2()
        {
            Image image;
            int x = 20, y = 20, maxheight = 100;
            string[] files = Directory.GetFiles(@"D:\Projects\ImageShower\ImageShower\Resources\Image");

            for (int i = 0; i < files.Length; i++)
            {
                image = Image.FromFile(files[i]);
                PictureBox pb = new PictureBox();

                pb.Image = image;
                //pb.Image.Dispose();
                pb.Width = 200;
                pb.Height = 200;
                pb.Location = new Point(x, y);

                x += pb.Width + 100;
                maxheight = Math.Max(pb.Height, maxheight);
                if (x > this.ClientSize.Width - 100)
                {
                    x = 20;
                    y += maxheight + 10;
                }

                this.panel2.Controls.Add(pb);
                pb.Click += new System.EventHandler(this.ClickImage);
            }
        }
        private void MainScreen_Load(object sender, EventArgs e)
        {
            Image image;
            int x = 20, y = 20, maxheight = 100;
            string[] files = Directory.GetFiles(@"D:\Projects\ImageShower\ImageShower\Resources");

            for (int i = 0; i < files.Length; i++)
            {
                image = Image.FromFile(files[i]);
                PictureBox pb = new PictureBox();
                pb.Image = image;
                pb.Width = 200;
                pb.Height = 200;
                pb.Location = new Point(x, y);

                x += pb.Width + 100;
                maxheight = Math.Max(pb.Height, maxheight);
                if (x > this.ClientSize.Width - 100)
                {
                    x = 20;
                    y += maxheight + 10;
                }

                this.panel1.Controls.Add(pb);
                pb.Click += new System.EventHandler(this.ClickImage);

            }
            FillPanel2();


        }
        public void ClickImage(object sender,EventArgs e)
        {
            PictureBox img = (PictureBox)sender;
            
            
            FullScreen fs = new FullScreen();
            fs.Show();


        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

            

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
            
        }
    }
}
