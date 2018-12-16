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

namespace App
{
    public partial class ListeCourses : Form
    {
        private ICourseRepository _courseRepository;
        private List<Course> _courses;
        private Course _course_actuelle;
        private IParticipationRepository _participation_repository;

        public ListeCourses()
        {
            InitializeComponent();
            _courseRepository = StubCourseRepository.Instance;
            _participation_repository = StubParticipationRepository.Instance;
            _courses = _courseRepository.GetAll();
            CoursesLB.Items.AddRange(_courses.Select(course => course.ToString()).ToArray());
            CoursesLB.SelectedIndex = 0;
        }

        private void CoursesLB_SelectedIndexChanged(object sender, EventArgs e)
        {
            _course_actuelle = _courses[CoursesLB.SelectedIndex];
            NomTB.Text = _course_actuelle.Nom;
            DateMTB.Text = _course_actuelle.Annee.ToString("dd/MM/yyyy");
            ParticipantsDGV.DataSource = _course_actuelle.Participations;
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
                CoursesLB.Items.Clear();
                CoursesLB.Items.AddRange(_courses.Select(course => course.ToString()).ToArray());
                CoursesLB.SelectedIndex = 0;
            }
        }

        private void AjouterParticipantBtn_Click(object sender, EventArgs e)
        {
            AjouterParticipant form = new AjouterParticipant(CoursesLB.SelectedItem.ToString());
            if (form.ShowDialog() == DialogResult.OK)
            {
                _participation_repository.Save(new Participation(_course_actuelle, form.Coureur, form.NoDossard, form.Temps));
                ParticipantsDGV.DataSource = _participation_repository.GetByCourse(_course_actuelle).ToList();
            }
        }

        private void SupprimerParticipantBtn_Click(object sender, EventArgs e)
        {

            //_participation_repository.Save(new Participation(_course_actuelle, form.Coureur, form.NoDossard, form.Temps));
        }

        private void ImporterCourseBtn_Click(object sender, EventArgs e)
        {
            ImporterParticipations form = new ImporterParticipations(_course_actuelle);
            if (form.ShowDialog() == DialogResult.Cancel)
            {
                int index = CoursesLB.SelectedIndex;
                _courses = _courseRepository.GetAll();
                CoursesLB.Items.Clear();
                CoursesLB.Items.AddRange(_courses.Select(course => course.ToString()).ToArray());
                CoursesLB.SelectedIndex = 0;
                CoursesLB.SelectedIndex = index;
                EnregistrerBtn.Enabled = false;
            }
        }

        private void RechercheCoursePTB_KeyUp(object sender, KeyEventArgs e)
        {
            string recherche = RechercheCoursePTB.Text;
            CoursesLB.Items.Clear();
            CoursesLB.Items.AddRange(_courses.Where(c => c.Nom.ContientAuMoins(recherche) || c.Annee.ToString().ContientAuMoins(recherche)).ToArray());
            if (CoursesLB.Items.Count > 0)
                CoursesLB.SelectedIndex = 0;
        }

        private void RechercheParticipantPTB_KeyUp(object sender, KeyEventArgs e)
        {
            string recherche = RechercheParticipantPTB.Text;
            ParticipantsDGV.DataSource = _course_actuelle.Participations.Where(p => p.Coureur.Nom.ContientAuMoins(recherche) || p.Coureur.Prenom.ContientAuMoins(recherche) || p.NumeroDeDossard.ToString().ContientAuMoins(recherche)).ToList();
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
    }
}
