using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;

namespace App
{
    public partial class Connexion : Form
    {
        public Connexion()
        {
            InitializeComponent();
        }

        private void ConnexionBtn_Click(object sender, EventArgs e)
        {
            
            if (UtilisateurCourant.Connecter(IdTB.Text, MdpTB.Text))
            {
                Console.WriteLine(UtilisateurCourant.Utilisateur == null);
                MessageBox.Show($"Bienvenue {UtilisateurCourant.Utilisateur.Prenom}.");
                DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Mauvaise combinaison identifiant/mot de passe, veuillez réessayer.");
            }
        }
    }
}
