using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using DAL;
using Domain;

namespace App
{
    public partial class CreerCoureur : Form
    {
        public Coureur Coureur
        {
            get
            {
                return new Coureur(PrenomTB.Text, NomTB.Text, SexeCB.Text == "Homme" ? 'M' : 'F', DateCal.SelectionStart, CourrielTB.Text, NoLicenceMTB.Text);
            }
        }

        public DateTime DateCoureur { get { return DateCal.SelectionStart; } }

        public CreerCoureur()
        {
            InitializeComponent();
            SexeCB.SelectedIndex = 0;
        }

        private void NomTB_TextChanged(object sender, EventArgs e)
        {
            ValiderBtn.Enabled = PrenomTB.TextLength > 0 && DateMTB.MaskCompleted;
        }

        private void AnneeMTB_TextChanged(object sender, EventArgs e)
        {
            ValiderBtn.Enabled = DateMTB.MaskCompleted && PrenomTB.TextLength > 0;
        }

        private void DateMTB_KeyUp(object sender, KeyEventArgs e)
        {
            if (DateMTB.MaskFull)
            {
                string[] dateStr = DateMTB.Text.Split('/');
                DateTime date = new DateTime(Convert.ToInt32(dateStr[2]), Convert.ToInt32(dateStr[1]), Convert.ToInt32(dateStr[0]));
                Console.WriteLine(date);
                DateCal.SetSelectionRange(date, date);
            }
            ValiderBtn_Enable();
        }

        private void DateCal_DateChanged(object sender, DateRangeEventArgs e)
        {
            DateTime date = DateCal.SelectionRange.Start;
            DateMTB.Text = date.ToString("dd/MM/yyyy");
            ValiderBtn_Enable();
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

        private void DateCal_Leave(object sender, EventArgs e)
        {
            if (!DateMTB.Focused)
                DateCal.Visible = false;
        }

        private void ValiderBtn_Enable(object sender = null, KeyEventArgs e = null)
        {
            Regex email = new Regex(@"^\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*$");
            ValiderBtn.Enabled = PrenomTB.TextLength > 0 && NomTB.TextLength > 0 && DateMTB.MaskFull && email.IsMatch(CourrielTB.Text) && NoLicenceMTB.MaskFull;
        }

    }
}
