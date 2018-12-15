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
            Course c1 = new Course("Rallye des apparts", 2017);
            Participation p1 = new Participation(c1, coureurs[0], 8645, "1:45:21");
            Participation p2 = new Participation(c1, coureurs[1], 8646, "1:54:12");
            c1.Participations.Add(p1);
            c1.Participations.Add(p2);
            Course c2 = new Course("Rallye des apparts", 2018);
            Participation p3 = new Participation(c2, coureurs[2], 4589, "0:57:58");
            c2.Participations.Add(p3);
            Course c3 = new Course("Marathon de Bordeaux", 2018);
            Participation p4 = new Participation(c3, coureurs[1], 6578, "1:23:46");
            c3.Participations.Add(p4);
            _courses.Add(c1);
            _courses.Add(c2);
            _courses.Add(c3);
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
