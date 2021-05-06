using Bunifu.Framework.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Threading.Tasks;

namespace Market_wallpaper_Form_App
{
    class Produit
    {
        private string Name;
        private string Categorie;
        private string Released;
        //False price is the price before the discount.
        private double FalsePrix;
        //Prix is the real price
        private double Prix;
        private Image Picture;

        //get and set
        public string name
        {
            get { return Name; }
            set { Name = value; }
        }
        public string categorie
        {
            get { return Categorie; }
            set { Categorie = value; }
        }
        public double fprix
        {
            get { return FalsePrix; }
            set { FalsePrix = value; }
        }
        public double prix
        {
            get { return Prix; }
            set { Prix = value; }
        }
        public string released
        {
            get { return Released; }
            set { Released = value; }
        }
        public Image picture
        {
            get { return Picture; }
            set { Picture = value; }
        }
        
        //

        public Produit()
        {

        }

        public Produit(string N, string C, string R, double FPrice, double Price, Image P)
        {
            this.name = N;
            this.categorie = C;
            this.released = R;
            this.fprix = FPrice;
            this.prix = Price;
            this.picture = P;
        }
    }
}
