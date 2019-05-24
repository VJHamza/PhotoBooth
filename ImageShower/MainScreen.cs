﻿using System;
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
    public partial class MainScreen : Form
    {
        String fileName=null;
        public MainScreen()
        {
            InitializeComponent();
        }

        public static Image image;
        public static Image image1
        {
            get { return image; }
            set { image = value; }
        }
        public static Image image2
        {
            get { return image; }
            set { image = value; }
        }
        public static Image image3
        {
            get { return image; }
            set { image = value; }
        }

        public void ShowForm()
        {
            Form form = Form.ActiveForm;
            FullScreen fs = new FullScreen();
            fs.Show();
        }
        private void pb1_Click(object sender, EventArgs e)
        {
            image = pb1.Image;
            this.Hide();
            ShowForm();
            
        }

        private void pb2_Click(object sender, EventArgs e)
        {
            image = pb2.Image;
            this.Hide();
            ShowForm();
        }

        private void pb3_Click(object sender, EventArgs e)
        {
            image = pb3.Image;
            this.Hide();
            ShowForm();
        }

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

        private void MainScreen_Load(object sender, EventArgs e)
        {


        }
    }
}
