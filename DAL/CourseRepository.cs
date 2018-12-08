using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class CourseRepository : Repository, ICourseRepository
    {
        public List<Course> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Save(Course c)
        {
            throw new NotImplementedException();
        }

        public void Delete(Course c)
        {
            throw new NotImplementedException();
        }
    }
}
