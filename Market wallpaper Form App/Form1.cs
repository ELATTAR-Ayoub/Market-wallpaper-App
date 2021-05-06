using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Market_wallpaper_Form_App
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttWall1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Wallpaper1 W1 = new Wallpaper1();
            W1.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Wallpaper2 W2 = new Wallpaper2();
            W2.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Wallpaper3 W3 = new Wallpaper3();
            W3.Show();
        }
    }
}
