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
    public partial class ListeCoureurs : Form
    {
        private ICoureurRepository _coureurRepository;
        public ListeCoureurs()
        {
            InitializeComponent();
            _coureurRepository = new StubCoureurRepository();

            CoureursDGV.DataSource = _coureurRepository.GetAll();
        }
    }
}
