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
            AnneeMTB.Text = _course_actuelle.Annee.ToString();
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
                _courseRepository.Save(new Course(creerCourse.NomCourse, creerCourse.AnneeCourse));
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

            }
        }

        private void SupprimerParticipantBtn_Click(object sender, EventArgs e)
        {

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

        private void RechercheParticipantTB_Enter(object sender, EventArgs e)
        {
            RechercheParticipantTB.Text = "";
        }

        private void RechercheParticipantTB_Leave(object sender, EventArgs e)
        {
            if (RechercheParticipantTB.Text == "")
                RechercheParticipantTB.Text = "Rechercher un participant";
        }

        private void RechercheParticipantTB_KeyUp(object sender, KeyEventArgs e)
        {
            ParticipantsDGV.DataSource = _course_actuelle.Participations.Where(p => p.Coureur.Nom.ContientAuMoins(RechercheParticipantTB.Text) || p.Coureur.Prenom.ContientAuMoins(RechercheParticipantTB.Text) || p.NumeroDeDossard.ToString().ToLower().ContientAuMoins(RechercheParticipantTB.Text)).ToList();
        }

        private void RechercheCourseTB_Enter(object sender, EventArgs e)
        {
            RechercheCourseTB.Text = "";
        }

        private void RechercheCourseTB_Leave(object sender, EventArgs e)
        {
            if (RechercheCourseTB.Text == "")
                RechercheCourseTB.Text = "Rechercher une course";
        }

        private void RechercheCourseTB_KeyUp(object sender, KeyEventArgs e)
        {
            CoursesLB.Items.Clear();
            CoursesLB.Items.AddRange(_courses.Where(c => c.Nom.ContientAuMoins(RechercheCourseTB.Text) || c.Annee.ToString().ContientAuMoins(RechercheCourseTB.Text)).ToArray());
            if (CoursesLB.Items.Count > 0)
                CoursesLB.SelectedIndex = 0;
        }
    }
}
