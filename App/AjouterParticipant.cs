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
    public partial class AjouterParticipant : Form
    {
        private Coureur[] _coureurs;
        public Coureur Coureur { get { return _coureurs[CoureurCB.SelectedIndex]; } }
        public string Temps { get { return TempsMTB.Text; } }
        public int NoDossard { get { return Convert.ToInt32(NoDossardMTB.Text); } }

        public AjouterParticipant(string course)
        {
            InitializeComponent();
            ICoureurRepository coureurRepository = StubCoureurRepository.Instance;
            // On récupère la liste des coureurs qu'on trie par Nom, Prenom ascendant
            _coureurs = coureurRepository.GetAll().OrderBy(x => x.Nom).ThenBy(x => x.Prenom).ToArray();
            CourseTB.Text = course;
            CoureurCB.Items.AddRange(_coureurs);
            CoureurCB.SelectedIndex = 0;
        }

        private void CoureurCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            Coureur coureurActuel = _coureurs[CoureurCB.SelectedIndex];
            AgeTB.Text = (DateTime.Now.Year - coureurActuel.DateNaissance.Year).ToString();
            LicenceTB.Text = coureurActuel.NoLicenceFFA;
        }

        private void TempsMTB_KeyUp(object sender, KeyEventArgs e)
        {
            ValiderBtn.Enabled = TempsMTB.MaskFull && NoDossardMTB.MaskFull;
        }

        private void NoDossardMTB_KeyUp(object sender, KeyEventArgs e)
        {
            ValiderBtn.Enabled = TempsMTB.MaskFull && NoDossardMTB.MaskFull;
        }
    }
}
