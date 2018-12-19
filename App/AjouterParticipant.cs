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
    public partial class AjouterParticipant : Form
    {
        private bool _is_course;
        private Coureur[] _coureurs;
        private Course[] _courses;
        private Course _course;
        private Coureur _coureur;

        private IParticipationRepository _participation_repository = ParticipationRepository.Instance;

        /// <summary>
        /// Formulaire d'ajout de participation à une course
        /// </summary>
        /// <param name="c">Course à laquelle sera ajoutée le participant</param>
        public AjouterParticipant(Course c)
        {
            InitializeComponent();
            //ICoureurRepository coureurRepository = StubCoureurRepository.Instance;
            ICoureurRepository coureurRepository = CoureurRepository.Instance;
            // On récupère la liste des coureurs qu'on trie par Nom, Prenom ascendant
            _coureurs = coureurRepository.GetAll().OrderBy(x => x.Nom).ThenBy(x => x.Prenom).ToArray();
            CourseTB.Text = c.ToString();
            CoureurCB.Items.AddRange(_coureurs);
            CoureurCB.DataSource = _coureurs;
            if (CoureurCB.Items.Count > 0)
                CoureurCB.SelectedIndex = 0;
            _course = c;
            _is_course = true;
        }
        /// <summary>
        /// Formulaire d'ajout de participation à un coureur
        /// </summary>
        /// <param name="c">Coureur qui se verra ajouter une participation</param>
        public AjouterParticipant(Coureur c)
        {
            InitializeComponent();
            //ICoureurRepository coureurRepository = StubCoureurRepository.Instance;
            ICourseRepository courseRepository = CourseRepository.Instance;
            // On récupère la liste des coureurs qu'on trie par Nom, Prenom ascendant
            _courses = courseRepository.GetAll().OrderBy(x => x.Nom).ToArray();
            CourseTB.Text = c.ToString();
            CoureurCB.DataSource = _courses;
            if (CoureurCB.Items.Count > 0)
                CoureurCB.SelectedIndex = 0;
            _coureur = c;
            _is_course = false;
        }

        private void TempsMTB_KeyUp(object sender, KeyEventArgs e)
        {
            ValiderBtn.Enabled = TempsMTB.MaskFull && NoDossardMTB.MaskFull;
        }

        private void NoDossardMTB_KeyUp(object sender, KeyEventArgs e)
        {
            ValiderBtn.Enabled = TempsMTB.MaskFull && NoDossardMTB.MaskFull;
        }

        private void ValiderBtn_Click(object sender, EventArgs e)
        {
            if (_is_course)
            {
                Coureur coureurActuel = (Coureur)CoureurCB.SelectedItem;
                try
                {
                    _participation_repository.Save(new Participation(_course, coureurActuel, TempsMTB.Text, Convert.ToInt32(NoDossardMTB.Text)));
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Impossible d'ajouter cette participation, veuillez vérifier la valeur des paramètres entrés.\nPlus d'infos : {ex}");
                }
            }
            else
            {
                Course courseActuelle = (Course)CoureurCB.SelectedItem;
                try
                {
                    _participation_repository.Save(new Participation(courseActuelle, _coureur, TempsMTB.Text, Convert.ToInt32(NoDossardMTB.Text)));
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Impossible d'ajouter cette participation, veuillez vérifier la valeur des paramètres entrés.\nPlus d'infos : {ex}");
                }
            }

        }
    }
}
