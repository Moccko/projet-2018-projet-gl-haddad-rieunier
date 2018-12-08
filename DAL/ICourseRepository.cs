using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public interface ICourseRepository
    {
        List<Course> GetAll();
        void Save(Course c);
        void Delete(Course c);
    }
}
