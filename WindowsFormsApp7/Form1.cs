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

namespace WindowsFormsApp7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.Title = "resim seç";
            openFileDialog1.Filter = "jpg dosyaları(*.jpg)|*.jpg|jpeg dosyaları(*.jpeg)|*.jpeg|png dosyaları(*.png)|*.png|bitmap dosyaları(*.bmp)|*.bmp";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.ImageLocation = openFileDialog1.FileName;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string imagefile =Path.GetFileName(pictureBox1.ImageLocation);
            string imagepath = Path.Combine(Application.StartupPath + "\\img\\" + imagefile);
            File.Copy(pictureBox1.ImageLocation,imagepath,true);
        }
    }
}
