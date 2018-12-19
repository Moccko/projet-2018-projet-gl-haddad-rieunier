using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;

namespace DAL
{
    public class CourseRepository : Repository, ICourseRepository
    {
        private static CourseRepository _instance = null;
        public static CourseRepository Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new CourseRepository();
                return _instance;
            }
        }

        private CourseRepository() { }

        public List<Course> GetAll()
        {
            return Session.Query<Course>().OrderBy(c => c.Nom).ThenBy(c => c.Date).ToList();
        }

        public void Save(Course c)
        {
            Session.SaveOrUpdate(c);
            Session.Flush();
        }

        public void Delete(Course c)
        {
            Session.Delete(c);
            Session.Flush();
        }
    }
}
