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
using Domain;

namespace App
{
    public partial class ListeCoureurs : Form
    {
        private IParticipationRepository _participation_repository;
        private ICoureurRepository _coureur_repository;
        private Coureur _coureur_actuel;
        private List<Coureur> _coureurs;

        public ListeCoureurs()
        {
            InitializeComponent();
            //_coureurRepository = StubCoureurRepository.Instance;
            _coureur_repository = CoureurRepository.Instance;

            _participation_repository = ParticipationRepository.Instance;

            _coureurs = _coureur_repository.GetAll();

            CoureursLB.DataSource = _coureurs.ToList();
            if (_coureurs.Count > 0)
                CoureursLB.SelectedIndex = 0;
        }

        private void DateNaissanceMTB_Enter(object sender, EventArgs e)
        {
            DateNaissanceCal.Visible = true;
        }

        private void DateNaissanceMTB_Leave(object sender, EventArgs e)
        {
            if (!DateNaissanceCal.Focused)
                DateNaissanceCal.Visible = false;
        }

        private void DateNaissanceMTB_KeyUp(object sender, KeyEventArgs e)
        {
            if (DateNaissanceMTB.MaskFull)
            {
                string[] dateStr = DateNaissanceMTB.Text.Split('/');
                DateTime date = new DateTime(Convert.ToInt32(dateStr[2]), Convert.ToInt32(dateStr[1]), Convert.ToInt32(dateStr[0]));
                DateNaissanceCal.SetSelectionRange(date, date);
            }
        }

        private void DateNaissanceCal_DateChanged(object sender, DateRangeEventArgs e)
        {
            DateTime date = DateNaissanceCal.SelectionRange.Start;
            DateNaissanceMTB.Text = date.ToString("dd/MM/yyyy");
        }

        private void DateNaissanceCal_Leave(object sender, EventArgs e)
        {
            if (!DateNaissanceMTB.Focused)
                DateNaissanceCal.Visible = false;
        }

        private void RechercheCoureurPTB_KeyUp(object sender, KeyEventArgs e)
        {
            string recherche = RechercheCoureurPTB.Text;
            CoureursLB.DataSource = _coureurs.Where(c => c.Nom.ContientAuMoins(recherche) || c.Prenom.ContientAuMoins(recherche) || c.LicenceFFA.ContientAuMoins(recherche)).ToList();
        }

        private void RechercheParticipationPTB_KeyUp(object sender, KeyEventArgs e)
        {
            string recherche = RechercheParticipationPTB.Text;
            ParticipationsDGV.DataSource = _participation_repository.GetByCoureur(_coureur_actuel).Where(p => p.Course.Nom.ContientAuMoins(recherche) || p.Course.Date.ToString().ContientAuMoins(recherche)).ToList();
        }

        private void CoureursLB_SelectedIndexChanged(object sender, EventArgs e)
        {
            _coureur_actuel = (Coureur)CoureursLB.SelectedItem;
            PrenomTB.Text = _coureur_actuel.Prenom;
            NomTB.Text = _coureur_actuel.Nom;
            DateNaissanceMTB.Text = _coureur_actuel.DateNaissance.ToString("dd/MM/yyyy");
            LicenceTB.Text = _coureur_actuel.LicenceFFA;
            CourrielTB.Text = _coureur_actuel.Courriel;
            ParticipationsDGV.DataSource = _participation_repository.GetByCoureur(_coureur_actuel);
        }

        private void CreerCoureurBtn_Click(object sender, EventArgs e)
        {
            CreerCoureur form = new CreerCoureur();
            if (form.ShowDialog() == DialogResult.OK)
            {
                _coureur_repository.Save(form.Coureur);
                _coureurs = _coureur_repository.GetAll();
                int index = CoureursLB.SelectedIndex;
                CoureursLB.DataSource = _coureurs.ToList();
                CoureursLB.SelectedIndex = index;
            }
        }

        private void ImporterCoureursBtn_Click(object sender, EventArgs e)
        {
            ImporterCoureurs form = new ImporterCoureurs();
            if (form.ShowDialog() == DialogResult.Cancel)
            {
                int index = CoureursLB.SelectedIndex;
                _coureurs = _coureur_repository.GetAll();
                CoureursLB.DataSource = _coureurs.ToList();
                CoureursLB.SelectedIndex = 0;
                CoureursLB.SelectedIndex = index;
                EnregistrerBtn.Enabled = false;
            }
        }

        private void AjouterParticipantBtn_Click(object sender, EventArgs e)
        {
            AjouterParticipant form = new AjouterParticipant(_coureur_actuel);
            DialogResult dr = form.ShowDialog();
            if (dr == DialogResult.OK || dr == DialogResult.Cancel)
            {
                ParticipationsDGV.DataSource = _participation_repository.GetByCoureur(_coureur_actuel).ToList();
            }
        }

        private void SupprimerParticipantBtn_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Êtes-vous sûr de vouloir supprimer ce participant ?", "Avertissement", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                // Sélectionner et supprimer
            }
        }
    }
}
