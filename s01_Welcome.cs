using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sexta8Semestre
{
    public partial class s01_Welcome : Form
    {
        public s01_Welcome()
        {
            InitializeComponent();
        }

        private void s01_Welcome_Load(object sender, EventArgs e)
        {
            //Bitmap lImageLocation = new Bitmap("C:/Users/-/Documents/visual studio 2017/Projects/Sexta8Semestre/Sexta8Semestre/Images/car-dealer.gif");
            //pbLoadText.BackgroundImage = lImageLocation;
        }

        private void pClickToGo_Click(object sender, EventArgs e)
        {
            s02_Select lGoTo = new s02_Select();
            lGoTo.Visible = true;
            this.Visible = false;
        }

        private void pbLoadText_Click(object sender, EventArgs e)
        {
            s02_Select lGoTo = new s02_Select();
            lGoTo.Visible = true;
            this.Visible = false;
        }

        private void lblWelcome_Click(object sender, EventArgs e)
        {
            s02_Select lGoTo = new s02_Select();
            lGoTo.Visible = true;
            this.Visible = false;
        }

        private void llblCickToGo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            s02_Select lGoTo = new s02_Select();
            lGoTo.Visible = true;
            this.Visible = false;
        }
    }
}
