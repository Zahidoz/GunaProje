using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GunaProje
{
    public partial class UserControl1 : System.Windows.Forms.UserControl
    {
        public int DiamondCount { get; set; } = 5;
        public UserControl1() 
        {
            InitializeComponent();
        }

        public UserControl1(Student student)
        {
            InitializeComponent();
            lbl_Id_Name.Text = student.ToString();          
        }

        private void diamond1_Click(object sender, EventArgs e)
        {
           
                diamond1.Image = Properties.Resources.diamond;
                diamond2.Image = Properties.Resources.undiamond;
                diamond3.Image = Properties.Resources.undiamond;
               


        }

        private void diamond2_Click(object sender, EventArgs e)
        {
            diamond1.Image = Properties.Resources.diamond;
            diamond2.Image = Properties.Resources.diamond;
            diamond3.Image = Properties.Resources.undiamond;
        }

        private void diamond3_Click(object sender, EventArgs e)
        {
            diamond1.Image = Properties.Resources.diamond;
            diamond2.Image = Properties.Resources.diamond;
            diamond3.Image = Properties.Resources.diamond;
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2CirclePictureBox2_Click(object sender, EventArgs e)
        {
            diamond1.Image = Properties.Resources.undiamond;
            diamond2.Image = Properties.Resources.undiamond;
            diamond3.Image = Properties.Resources.undiamond;
        }

    }
}
