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
    public partial class ImporterCoureurs : Form
    {
        public ImporterCoureurs()
        {
            InitializeComponent();
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
            ImportCoureurs import = new ImportCoureurs();
            int nbImportes = import.Import(SelectionnerCsvBtn.Text);
            MessageBox.Show(nbImportes > 0 ? $"Vous avez bien importé {nbImportes} coureurs." : "Erreur lors de l'importation du fichier, veuillez réessayer, ou pas.");
        }
    }
}
