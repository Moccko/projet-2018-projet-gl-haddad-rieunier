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
    public partial class ListeCourses : Form
    {
        private ICourseRepository _courseRepository;
        private List<Course> _courses;
        private Course _course_actuelle;
        public ListeCourses()
        {
            InitializeComponent();
            _courseRepository = new StubCourseRepository();
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

        }

        private void SupprimerParticipantBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
