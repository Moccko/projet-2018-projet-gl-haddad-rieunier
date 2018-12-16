using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App
{
    public partial class CreerCourse : Form
    {
        public string NomCourse { get { return NomTB.Text; } }

        public DateTime DateCourse { get { return DateCal.SelectionStart; } }

        public CreerCourse()
        {
            InitializeComponent();
        }

        private void NomTB_TextChanged(object sender, EventArgs e)
        {
            ValiderBtn.Enabled = NomTB.TextLength > 0 && DateMTB.MaskCompleted;
        }

        private void AnneeMTB_TextChanged(object sender, EventArgs e)
        {
            ValiderBtn.Enabled = DateMTB.MaskCompleted && NomTB.TextLength > 0;
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
    }
}
