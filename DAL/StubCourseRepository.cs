using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class StubCourseRepository : Repository, ICourseRepository
    {
        private List<Course> _courses;

        public StubCourseRepository()
        {
            _courses = new List<Course>();
            _courses.Add(new DAL.Course("Rallye des apparts", 2017, new List<Participation>()));
            _courses.Add(new DAL.Course("Rallye des apparts", 2018, new List<Participation>()));
            _courses.Add(new DAL.Course("Marathon de Bordeaux", 2018, new List<Participation>()));
        }

        public List<Course> GetAll()
        {
            return _courses;
        }

        public void Save(Course c)
        {
            _courses.Add(c);
        }

        public void Delete(Course c)
        {
            _courses.Remove(c);
        }
    }
}
