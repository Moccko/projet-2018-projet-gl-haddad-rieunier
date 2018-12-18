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
    public partial class ClassementGlobal : Form
    {
        public ClassementGlobal(Course c)
        {
            InitializeComponent();
            CourseLb.Text = c.Nom;
            DateLb.Text = c.Annee.ToString("dd/MM/yyyy");
            Participation[] participations = StubParticipationRepository.Instance.GetClassement(c);
            for (int i = 0; i < participations.Length; i++)
            {
                Participation p = participations[i];
                string[] ligne = { (i + 1).ToString(), p.Coureur.Prenom, p.Coureur.Nom, p.Temps, $"{p.Coureur.Age} ans" };
                ClassementLV.Items.Add(new ListViewItem(ligne));
            }
        }
    }
}
