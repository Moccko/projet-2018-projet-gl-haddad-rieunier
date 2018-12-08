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
    public partial class Accueil : Form
    {
        public Accueil()
        {
            InitializeComponent();
        }

        private void ConnexionBtn_Click(object sender, EventArgs e)
        {
            Connexion connexion = new Connexion();
            if (connexion.ShowDialog() == DialogResult.OK)
            {

            }
        }

        private void CoursesListeBtn_Click(object sender, EventArgs e)
        {
            ListeCourses listeCourses = new ListeCourses();
            if (listeCourses.ShowDialog() == DialogResult.OK)
            {

            }
        }

        private void CoureursListeBtn_Click(object sender, EventArgs e)
        {
            ListeCoureurs listeCoureurs = new ListeCoureurs();
            if (listeCoureurs.ShowDialog() == DialogResult.OK)
            {

            }
        }
    }
}
