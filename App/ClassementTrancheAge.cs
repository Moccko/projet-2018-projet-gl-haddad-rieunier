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
    public partial class ClassementTrancheAge : Form
    {
        ColumnHeader _place = new ColumnHeader() { Text = "Place", Width = 40 };
        ColumnHeader _prenom = new ColumnHeader() { Text = "Prénom", Width = 100 };
        ColumnHeader _nom = new ColumnHeader() { Text = "Nom", Width = 100 };
        ColumnHeader _temps = new ColumnHeader() { Text = "Temps" };
        ColumnHeader _age = new ColumnHeader() { Text = "Âge" };

        private ColumnHeader[] ClassementColonnes()
        {
            return new ColumnHeader[]
            {
                (ColumnHeader)(_place.Clone()),
                (ColumnHeader)(_prenom.Clone()),
                (ColumnHeader)(_nom.Clone()),
                (ColumnHeader)(_temps.Clone()),
                (ColumnHeader)(_age.Clone()),
            };
        }

        private ColumnHeader[] classementColonnes = {
        };

        public ClassementTrancheAge(Course c)
        {
            InitializeComponent();

            for (int age = 10; age < 100; age += 10)
            {
                int[] tranche = { age, age + 10 };
                Participation[] participations = StubParticipationRepository.Instance.GetClassement(c, tranche);
                if (participations.Length > 0)
                {
                    TabPage tab = new TabPage($"{age}-{age + 9} ans");
                    ListView classement = new ListView();
                    classement.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                    | System.Windows.Forms.AnchorStyles.Left)
                    | System.Windows.Forms.AnchorStyles.Right)));
                    classement.Columns.AddRange(ClassementColonnes());
                    //classement.Location = new System.Drawing.Point(15, 137);
                    classement.Name = "ClassementLV";
                    classement.Size = new System.Drawing.Size(364, 322);
                    classement.TabIndex = 3;
                    classement.UseCompatibleStateImageBehavior = false;
                    classement.View = System.Windows.Forms.View.Details;

                    for (int i = 0; i < participations.Length; i++)
                    {
                        Participation p = participations[i];
                        string[] ligne = { (i + 1).ToString(), p.Coureur.Prenom, p.Coureur.Nom, p.Temps, $"{p.Coureur.Age} ans" };
                        classement.Items.Add(new ListViewItem(ligne));
                    }

                    tab.Controls.Add(classement);
                    TranchesAgeTC.TabPages.Add(tab);
                }
            }
        }
    }
}
