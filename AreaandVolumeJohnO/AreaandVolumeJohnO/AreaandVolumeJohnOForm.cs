using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AreaandVolumeJohnO
{
    public partial class AreaandVolumeJohnOForm : Form
    {
        public AreaandVolumeJohnOForm()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void btnCalculateTrapezoid_Click(object sender, EventArgs e)
        {
            //declare local variables
            double Height, Width, Base, Area;

            //convert the string from each text box to a double
            Height = double.Parse(txtHeightTrapeziod.Text);
            Width = double.Parse(txtWidthTrapeziod.Text);
            Base = double.Parse(txtBaseTrapeziod.Text);

            //calculate the area of the trapezoid
            Area = (Width + Base) / 2 * Height;

            //insert the area into the label
            this.lblTrapezoidAnswer.Text = Convert.ToString(Area) + "cm";
        }

        private void btnCalculateCylinder_Click(object sender, EventArgs e)
        {
            //declare local variables 
            double Height, Radius, Volume, Pi;

            //convert the string form each text box to a double 
            Height = double.Parse(txtHeightCylinder.Text);
            Radius = double.Parse(txtRadiusCylinder.Text);
            Pi = Math.PI;

            //calculate the volume of the cylinder 
            Volume = Pi * Radius * Radius * Height;

            //insert the Volume into the label
            this.lblCylinderAnswer.Text = Convert.ToString(Volume) + "cm";
        }

        private void btnCalculateSphere_Click(object sender, EventArgs e)
        {
            //declare local variable
            double Radius, Pi, Volume;

            //convert the string from each text box to a double 
            Radius = double.Parse(txtRadiusSphere.Text);
            Pi = Math.PI;

            //calculate the volume of the sphere 
            Volume = 4 / 3 * Pi * Radius * Radius * Radius;

            //insert the volume into the label
            this.lblSphereAnswer.Text = Convert.ToString(Volume + "cm");
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
