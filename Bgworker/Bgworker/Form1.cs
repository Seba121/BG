using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Bgworker
{
    public partial class Form1 : Form
    {
        Bitmap obrazek;
        int r = 0, g = 0, b = 0;
        private BackgroundWorker backgroundWorker = null;

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            pictureBox1.Image = new Bitmap(openFileDialog1.FileName);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            pictureBox1.Image.Save(@"C:\Users\Sebastian\Desktop\Nowy folder (7)\fotolia2.jpeg");
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
