using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppKep
{
    public partial class Form1 : Form
    {
        List<Image> Images;
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonKep_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "*.jpg|*.jpg|*.png|*.png|*.webp|*.webp";
            if (openFileDialog1.ShowDialog()==DialogResult.OK)
            {
                string kepFajl = openFileDialog1.FileName;
                pictureBox1.Image =Image.FromFile(kepFajl);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
