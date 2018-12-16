using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    /// <summary>
    /// Classe de gestion de données tests sur les courses
    /// Implémente le pattern singleton pour pouvoir conserver les données à travers les formulaires
    /// </summary>
    public class StubCourseRepository : Repository, ICourseRepository
    {
        private static StubCourseRepository _instance = null;

        public static StubCourseRepository Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new StubCourseRepository();
                }
                return _instance;
            }
        }

        private List<Course> _courses;

        private StubCourseRepository()
        {
            _courses = new List<Course>();
            List<Coureur> coureurs = StubCoureurRepository.Instance.GetAll();
            _courses.Add(new Course("Rallye des apparts", new DateTime(2017, 12, 8)));
            _courses.Add(new Course("Rallye des apparts", new DateTime(2018, 12, 7)));
            _courses.Add(new Course("Marathon de Bordeaux", new DateTime(2018, 3, 24)));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public List<Course> GetAll()
        {
            return _courses;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="c"></param>
        public void Save(Course c)
        {
            _courses.Add(c);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="c"></param>
        public void Delete(Course c)
        {
            _courses.Remove(c);
        }
    }
}
