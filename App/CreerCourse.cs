using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App
{
    public partial class CreerCourse : Form
    {
        public string NomCourse { get { return NomTB.Text; } }

        public int AnneeCourse { get { return Convert.ToInt32(AnneeMTB.Text); } }

        public CreerCourse()
        {
            InitializeComponent();
        }

        private void NomTB_TextChanged(object sender, EventArgs e)
        {
            ValiderBtn.Enabled = NomTB.TextLength > 0 && AnneeMTB.MaskCompleted;
        }

        private void AnneeMTB_TextChanged(object sender, EventArgs e)
        {
            ValiderBtn.Enabled = AnneeMTB.MaskCompleted && NomTB.TextLength > 0;
        }
    }
}
