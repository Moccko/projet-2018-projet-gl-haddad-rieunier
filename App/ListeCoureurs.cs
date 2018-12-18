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
    public partial class ListeCoureurs : Form
    {
        private ICoureurRepository _coureurRepository;
        private Coureur _coureur_actuel;
        private List<Coureur> _coureurs;

        public ListeCoureurs()
        {
            InitializeComponent();
            _coureurRepository = StubCoureurRepository.Instance;
            _coureurs = _coureurRepository.GetAll();

            CoureursLB.Items.AddRange(_coureurs.ToArray());
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
            CoureursLB.Items.Clear();
            string recherche = RechercheCoureurPTB.Text;
            CoureursLB.Items.AddRange(_coureurs.Where(c => c.Nom.ContientAuMoins(recherche) || c.Prenom.ContientAuMoins(recherche) || c.NoLicenceFFA.ContientAuMoins(recherche)).ToArray());
        }

        private void RechercheParticipationPTB_KeyUp(object sender, KeyEventArgs e)
        {
            string recherche = RechercheParticipationPTB.Text;
            ParticipationsDGV.DataSource = _coureur_actuel.Participations.Where(p => p.Course.Nom.ContientAuMoins(recherche) || p.Course.Annee.ToString().ContientAuMoins(recherche)).ToList();
        }

        private void CoureursLB_SelectedIndexChanged(object sender, EventArgs e)
        {
            _coureur_actuel = _coureurs[CoureursLB.SelectedIndex];
            PrenomTB.Text = _coureur_actuel.Prenom;
            NomTB.Text = _coureur_actuel.Nom;
            DateNaissanceMTB.Text = _coureur_actuel.DateNaissance.ToString("dd/MM/yyyy");
            LicenceTB.Text = _coureur_actuel.NoLicenceFFA;
            CourrielTB.Text = _coureur_actuel.Courriel;
            ParticipationsDGV.DataSource = _coureur_actuel.Participations;
        }

        private void CreerCoureurBtn_Click(object sender, EventArgs e)
        {
            CreerCoureur form = new CreerCoureur();
            if (form.ShowDialog() == DialogResult.OK)
            {
                _coureurRepository.Save(form.Coureur);
                _coureurs = _coureurRepository.GetAll();
                int index = CoureursLB.SelectedIndex;
                CoureursLB.Items.Clear();
                CoureursLB.Items.AddRange(_coureurs.ToArray());
                CoureursLB.SelectedIndex = index;
            }
        }

        private void ImporterCoureursBtn_Click(object sender, EventArgs e)
        {
            ImporterCoureurs form = new ImporterCoureurs();
            if (form.ShowDialog() == DialogResult.Cancel)
            {
                int index = CoureursLB.SelectedIndex;
                _coureurs = _coureurRepository.GetAll();
                CoureursLB.Items.Clear();
                CoureursLB.Items.AddRange(_coureurs.Select(course => course.ToString()).ToArray());
                CoureursLB.SelectedIndex = 0;
                CoureursLB.SelectedIndex = index;
                EnregistrerBtn.Enabled = false;
            }
        }
    }
}
