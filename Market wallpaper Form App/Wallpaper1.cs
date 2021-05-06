using Bunifu.Framework.UI;
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
    public partial class Wallpaper1 : Form
    {
        private int Timer = 0;
        private int i = 0;

        private static Produit P1;
        private static Produit P2;
        private static Produit P3;
        private static Produit P4;

        private readonly Produit[] P = new Produit[] { P1, P2, P3, P4 };

        public Wallpaper1()
        {
            InitializeComponent();

            
        }

        private void buttClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
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

        private void buttBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 F1 = new Form1();
            F1.Show();
        }
        private void panelTop_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Wallpaper1_Load(object sender, EventArgs e)
        {
            timer1.Start();

            pictureBox1.Image = Properties.Resources.social_share_image;
            pictureBox2.Image = Properties.Resources.maxresdefault;
            pictureBox3.Image = Properties.Resources._1612537654220;
            pictureBox4.Image = Properties.Resources.Grand_Theft_Auto_V_PS5;

            P1 = new Produit("CALL OF DUTY : Modern warframe", "+18, shooting, Online PvP, Online Co - op, rpg, fps, battle royale", "2019", 60.99, 50.23, pictureBox1.Image);
            P2 = new Produit("Phantasy Star Online 2 New Genesis", "+12, mmorpg, PvP, PvE, Online PvP, Online Co - op, role playing", "2021", 0, 0, pictureBox2.Image);
            P3 = new Produit("Rocket League", "+12, Single - player, Online PvP, Shared / Split Screen PvP, Cross - Platform Multiplayer", "2017", 4.99, 0, pictureBox3.Image);
            P4 = new Produit("Grand Theft Auto V", "+18, Single - player, Online PvP, Online Co - op, Full controller support", "September 17, 2013", 55.45, 29.89, pictureBox4.Image);

        }

        private void timer1_Tick(object sender, EventArgs e)
        {


            Produit[] P = new Produit[] { P1, P2, P3, P4 };
            BunifuProgressBar[] BProgress = new BunifuProgressBar[] {bunifuProgressBar1, bunifuProgressBar2, bunifuProgressBar3, bunifuProgressBar4};
            
            Timer++;
            //for the error of out of index
            if (i >= P.Length)
                i = 0;

            BProgress[i].Value = Timer;

            pictureBoxWall.Image = P[i].picture;
            labelName.Text = P[i].name;
            labelCateg.Text = P[i].categorie;
            if (P[i].prix == 0)
            {
                labelPrix.Text = "Free";
                labelFPrix.Visible = true;
                labelFPrix.Text = P[i].fprix.ToString() + "$";
            }
            
            else
            {
                //If the product is free, we won't show the false price.
                labelPrix.Text = P[i].prix.ToString() + "$";
                labelFPrix.Visible = true;
                labelFPrix.Text = P[i].fprix.ToString() + "$";
            }
            labelReleased.Text = P[i].released;

            //If the price doesn't have a discount, we won't show the false price.
            if (P[i].prix == P[i].fprix)
            {
                labelFPrix.Visible = false;
            }

            if (BProgress[i].Value == 100)
            {
                
                Timer = 0;
                BProgress[i].Value = 0;
                i++;
            }
            //labelPercentage.Text = Timer.ToString();

            
        }

        private void NextTarget()
        {
            Produit[] P = new Produit[] { P1, P2, P3, P4 };
            BunifuProgressBar[] BProgress = new BunifuProgressBar[] { bunifuProgressBar1, bunifuProgressBar2, bunifuProgressBar3, bunifuProgressBar4 };

            Timer = 0;
            BProgress[i].Value = 0;
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            NextTarget();

            i = 0;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            NextTarget();

            i = 1;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            NextTarget();

            i =2;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            NextTarget();

            i =3;
        }

        private void pictureBoxWall_DoubleClick(object sender, EventArgs e)
        {
            //Opening the main web site of the game by double clicking on its photo
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

        private void pictureBoxWall_Click(object sender, EventArgs e)
        {

        }

        private void GitHub_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/ELATTAR-Ayoub");
        }









        /*
            Produit P1 = new Produit("CALL OF DUTY : Modern warframe", "+18, shooting, Online PvP, Online Co - op, rpg, fps, battle royale", "2019", 50.23,pictureBox1, bunifuProgressBar1);
            Produit P2 = new Produit("Phantasy Star Online 2 New Genesis", "+12, mmorpg, PvP, PvE, Online PvP, Online Co - op, role playing", "2021", 0,pictureBox2, bunifuProgressBar2);
            Produit P3 = new Produit("Rocket League", " +12, Single - player, Online PvP, Shared / Split Screen PvP, Online Co-op, Shared / Split Screen Co-op, Cross - Platform Multiplayer", "2017", 0,pictureBox3,bunifuProgressBar3);
            Produit P4 = new Produit("Grand Theft Auto V", "+ 18, Single - player, Online PvP, Online Co - op, Steam Achievements, Full controller support", "September 17, 2013", 29.89,pictureBox4,bunifuProgressBar4);

            Produit[] P = new Produit[] { P1, P2, P3, P4 };*/


    }
}
