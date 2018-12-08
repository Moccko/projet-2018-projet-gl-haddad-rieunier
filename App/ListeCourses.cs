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

        public ListeCourses()
        {
            InitializeComponent();
            _courseRepository = new StubCourseRepository();
            CoursesDGV.DataSource = _courseRepository.GetAll();
        }
    }
}
