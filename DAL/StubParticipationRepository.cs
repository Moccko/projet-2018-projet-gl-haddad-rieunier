using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class StubParticipationRepository : Repository, IParticipationRepository
    {
        private static StubParticipationRepository _instance = null;

        public static StubParticipationRepository Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new StubParticipationRepository();
                return _instance;
            }
        }

        private List<Participation> _participations;

        private StubParticipationRepository()
        {
            _participations = new List<Participation>();
            List<Course> courses = StubCourseRepository.Instance.GetAll();
            List<Coureur> coureurs = StubCoureurRepository.Instance.GetAll();
            _participations.Add(new Participation(courses[0], coureurs[0], 5, "1:48:53", 70, 90));
            _participations.Add(new Participation(courses[1], coureurs[1], 10, "1:23:24", 35, 120));
            _participations.Add(new Participation(courses[2], coureurs[2], 25, "1:45:13", 140, 60));
        }

        public List<Participation> GetAll()
        {
            return _participations;
        }

        public void Save(Participation p)
        {
            _participations.Add(p);
            p.Course.Participations.Add(p);
            p.Coureur.Participations.Add(p);
        }

        public void Save(List<Participation> l)
        {
            //_participations.AddRange(l);
            l.ForEach(p =>
            {
                Save(p);
            });
        }

        public void Delete(Participation p)
        {
            _participations.Remove(p);
        }
    }
}
