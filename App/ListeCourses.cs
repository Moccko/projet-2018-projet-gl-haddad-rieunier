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
using System.Reflection;
using Domain;

namespace App
{
    public partial class ListeCourses : Form
    {
        private ICourseRepository _courseRepository;
        private IParticipationRepository _participation_repository;
        private List<Course> _courses;
        private Course _course_actuelle;

        public ListeCourses()
        {
            InitializeComponent();
            //_courseRepository = StubCourseRepository.Instance;
            _courseRepository = CourseRepository.Instance;
            //_participation_repository = StubParticipationRepository.Instance;
            _participation_repository = ParticipationRepository.Instance;
            _courses = _courseRepository.GetAll();
            CoursesLB.DataSource = _courses.ToList();
            if (CoursesLB.Items.Count > 0)
                CoursesLB.SelectedIndex = 0;
            if (!UtilisateurCourant.EstConnecte())
            {
                AjouterParticipantBtn.Enabled = false;
                SupprimerParticipantBtn.Enabled = false;
                CreerCourseBtn.Enabled = false;
                SupprimerCourseBtn.Enabled = false;
                ImporterCourseBtn.Enabled = false;
                EnregistrerBtn.Enabled = false;
            }
        }

        private void CoursesLB_SelectedIndexChanged(object sender, EventArgs e)
        {
            //_course_actuelle = ((IList<Course>)CoursesLB.DataSource)[CoursesLB.SelectedIndex];
            _course_actuelle = (Course)CoursesLB.SelectedItem;
            NomTB.Text = _course_actuelle.Nom;
            DateMTB.Text = _course_actuelle.Date.ToString("dd/MM/yyyy");
            ParticipantsDGV.DataSource = _participation_repository.GetByCourse(_course_actuelle);
            EnregistrerBtn.Enabled = false;
        }

        private void NomTB_TextChanged(object sender, EventArgs e)
        {
            EnregistrerBtn.Enabled = true;
        }

        private void AnneeMTB_TextChanged(object sender, EventArgs e)
        {
            EnregistrerBtn.Enabled = true;
        }

        private void ParticipantsDGV_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            EnregistrerBtn.Enabled = true;
        }

        private void EnregistrerBtn_Click(object sender, EventArgs e)
        {
            _courseRepository.Save(_course_actuelle);
        }

        private void CreerCourseBtn_Click(object sender, EventArgs e)
        {
            CreerCourse creerCourse = new CreerCourse();
            if (creerCourse.ShowDialog() == DialogResult.OK)
            {
                _courseRepository.Save(new Course(creerCourse.NomCourse, creerCourse.DateCourse));
                _courses = _courseRepository.GetAll();
                CoursesLB.DataSource = _courses.ToArray();
                CoursesLB.SelectedIndex = 0;
            }
        }

        private void AjouterParticipantBtn_Click(object sender, EventArgs e)
        {
            AjouterParticipant form = new AjouterParticipant(_course_actuelle);
            DialogResult dr = form.ShowDialog();
            if (dr == DialogResult.OK || dr == DialogResult.Cancel)
            {
                ParticipantsDGV.DataSource = _participation_repository.GetByCourse(_course_actuelle).ToList();
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

        private void ImporterCourseBtn_Click(object sender, EventArgs e)
        {
            ImporterParticipations form = new ImporterParticipations(_course_actuelle);
            if (form.ShowDialog() == DialogResult.Cancel)
            {
                int index = CoursesLB.SelectedIndex;
                _courses = _courseRepository.GetAll();
                CoursesLB.DataSource = _courses.ToList();
                CoursesLB.SelectedIndex = 0;
                CoursesLB.SelectedIndex = index;
                EnregistrerBtn.Enabled = false;
            }
        }

        private void RechercheCoursePTB_KeyUp(object sender, KeyEventArgs e)
        {
            string recherche = RechercheCoursePTB.Text;
            CoursesLB.DataSource = _courses.Where(c => c.Nom.ContientAuMoins(recherche) || c.Date.ToString().ContientAuMoins(recherche)).ToList();
            if (CoursesLB.Items.Count > 0)
                CoursesLB.SelectedIndex = 0;
        }

        private void RechercheParticipantPTB_KeyUp(object sender, KeyEventArgs e)
        {
            string recherche = RechercheParticipantPTB.Text;
            ParticipantsDGV.DataSource = _participation_repository.GetByCourse(_course_actuelle).Where(p => p.Coureur.Nom.ContientAuMoins(recherche) || p.Coureur.Prenom.ContientAuMoins(recherche) || p.NumeroDossard.ToString().ContientAuMoins(recherche)).ToList();
        }

        private void DateMTB_Enter(object sender, EventArgs e)
        {
            DateCal.Visible = true;
        }

        private void DateMTB_Leave(object sender, EventArgs e)
        {
            if (!DateCal.Focused)
                DateCal.Visible = false;
        }

        private void DateMTB_KeyUp(object sender, KeyEventArgs e)
        {
            if (DateMTB.MaskFull)
            {
                string[] dateStr = DateMTB.Text.Split('/');
                DateTime date = new DateTime(Convert.ToInt32(dateStr[2]), Convert.ToInt32(dateStr[1]), Convert.ToInt32(dateStr[0]));
                DateCal.SetSelectionRange(date, date);
            }
        }

        private void DateCal_DateChanged(object sender, DateRangeEventArgs e)
        {
            DateTime date = DateCal.SelectionRange.Start;
            DateMTB.Text = date.ToString("dd/MM/yyyy");
        }

        private void DateCal_Leave(object sender, EventArgs e)
        {
            if (!DateMTB.Focused)
                DateCal.Visible = false;
        }

        private void ClassementGlobalBtn_Click(object sender, EventArgs e)
        {
            ClassementGlobal form = new ClassementGlobal(_course_actuelle);
            if (form.ShowDialog() == DialogResult.Cancel) { }
        }

        private void ClassementTrancheAgeBtn_Click(object sender, EventArgs e)
        {
            ClassementTrancheAge form = new ClassementTrancheAge(_course_actuelle);
            if (form.ShowDialog() == DialogResult.Cancel) { }
        }

        private void ConnecterBtn_Click(object sender, EventArgs e)
        {
            Connexion form = new Connexion();
            if (form.ShowDialog() == DialogResult.OK)
            {
                AjouterParticipantBtn.Enabled = true;
                SupprimerParticipantBtn.Enabled = true;
                CreerCourseBtn.Enabled = true;
                SupprimerCourseBtn.Enabled = true;
                ImporterCourseBtn.Enabled = true;
                EnregistrerBtn.Enabled = true;
                AvertissementConnexionLb.Visible = false;
                ConnecterBtn.Visible = false;
            }
        }
    }
}
