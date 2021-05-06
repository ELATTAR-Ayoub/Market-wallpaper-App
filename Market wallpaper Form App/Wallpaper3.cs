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
    public partial class Wallpaper3 : Form
    {
        private int Timer = 0;
        private int i = 0;

        private static Produit P1;
        private static Produit P2;
        private static Produit P3;
        private static Produit P4;

        private readonly Produit[] P = new Produit[] { P1, P2, P3, P4 };

        public Wallpaper3()
        {
            InitializeComponent();
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            e.Graphics.DrawLine(Pens.Yellow, 0, 0, 100, 100);
        }

        private void Wallpaper3_Load(object sender, EventArgs e)
        {

            //
            timer1.Start();


            P1 = new Produit("CALL OF DUTY : Modern warframe", "+18, shooting, Online PvP, Online Co - op, rpg, fps, battle royale", "2019", 60.99, 50.23, Properties.Resources.social_share_image);
            P2 = new Produit("Phantasy Star Online 2 New Genesis", "+12, mmorpg, PvP, PvE, Online PvP, Online Co - op, role playing", "2021", 0, 0, Properties.Resources.maxresdefault);
            P3 = new Produit("Rocket League", "+12, Single - player, Online PvP, Shared / Split Screen PvP, Cross - Platform Multiplayer", "2017", 4.99, 0, Properties.Resources._1612537654220);
            P4 = new Produit("Grand Theft Auto V", "+18, Single - player, Online PvP, Online Co - op, Full controller support", "September 17, 2013", 55.45, 29.89, Properties.Resources.Grand_Theft_Auto_V_PS5);
        }

        private void buttClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttMaximize_Click(object sender, EventArgs e)
        {
            if (WindowState.ToString() == "Maximized")
            {
                this.WindowState = FormWindowState.Normal;
            }
            else
            {
                this.WindowState = FormWindowState.Maximized;
            }
        }

        private void buttMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void buttBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 F1 = new Form1();
            F1.Show();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            Produit[] P = new Produit[] { P1, P2, P3, P4 };
            int R = i + 1;
            int L = i - 1;

            if (R >= P.Length)
            {
                R = 0;
            }

            if (L == -1)
            {
                L = P.Length - 1;
            }

            Timer++;
            //for the error of out of index
            if (i >= P.Length)
                i = 0;
            if (i == -1)
            {
                i = P.Length - 1;
                L = P.Length - 2;
            }


            pictureBoxWall.Image = P[i].picture;
            pictureBoxBackground.Image = P[i].picture;

            pictureBoxRSide.Image = P[R].picture;
            pictureBoxLSide.Image = P[L].picture;

            labelName.Text = P[i].name;
            labelCateg.Text = P[i].categorie;
            if (P[i].prix == 0)
            {
                labelPrix.Text = "Free";
                labelFPrix.Visible = true;
                labelFPrix.Text = P[i].fprix.ToString() + "$";
            }
            else if (P[i].prix == P[i].fprix)
            {
                labelPrix.Text = "Free";
                labelFPrix.Visible = false;
            }
            else
            {
                //If the product is free, we won't show the false price.
                labelPrix.Text = P[i].prix.ToString() + "$";
                labelFPrix.Visible = true;
                labelFPrix.Text = P[i].fprix.ToString() + "$";
            }
            labelReleased.Text = P[i].released;

            if (P[i].prix == P[i].fprix)
            {
                labelPrix.Text = "Free";
                labelFPrix.Visible = false;
            }

            if (Timer == 100)
            {
                Timer = 0;
                i++;
            }
        }
        //A method to Blur an image in Picturebox <-------------------------------
        private void Blur(PictureBox PB)
        {

        }
        //Method for switching images in picturBoxby user clicks
        private void pictureBoxRSide_Click(object sender, EventArgs e)
        {
            Timer = 0;
            i++;
        }

        private void pictureBoxLSide_Click(object sender, EventArgs e)
        {
            Timer = 0;
            i--;
            
        }

        private void pictureBoxRSide_MouseHover(object sender, EventArgs e)
        {
        }

        private void pictureBoxWall_DoubleClick(object sender, EventArgs e)
        {
            if (i == 0)
            {
                System.Diagnostics.Process.Start("https://www.callofduty.com/modernwarfare");
            }
            else if (i == 1)
            {
                System.Diagnostics.Process.Start("https://new-gen.pso2.com/");

            }
            else if (i == 2)
            {
                System.Diagnostics.Process.Start("https://www.rocketleague.com/");

            }
            else
            {
                System.Diagnostics.Process.Start("https://www.rockstargames.com/V/");

            }
        }

        private void GitHub_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/ELATTAR-Ayoub");
        }
    }
}
