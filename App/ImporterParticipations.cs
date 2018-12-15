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
    public partial class ImporterParticipations : Form
    {
        private Course _course;
        public ImporterParticipations(Course c)
        {
            InitializeComponent();
            _course = c;
        }

        private void SelectionnerCsvBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Fichiers CSV (*.csv)|*.csv";
            if (open.ShowDialog() == DialogResult.OK)
            {
                SelectionnerCsvBtn.Text = open.FileName;
                ValiderBtn.Enabled = true;
            }
        }

        private void ValiderBtn_Click(object sender, EventArgs e)
        {
            ImportParticipations import = new ImportParticipations(_course);
            int nbImportes = import.Import(SelectionnerCsvBtn.Text);
            MessageBox.Show(nbImportes > 0 ? $"Vous avez bien importé {nbImportes} participations." : "Erreur lors de l'importation du fichier, veuillez réessayer, ou pas.");
        }
    }
}
