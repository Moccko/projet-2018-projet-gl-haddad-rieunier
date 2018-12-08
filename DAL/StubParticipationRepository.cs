using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class StubParticipationRepository : Repository, IParticipationRepository
    {

        private List<Participation> _participations;

        public StubParticipationRepository()
        {
            _participations = new List<Participation>();
            List<Course> courses = new StubCourseRepository().GetAll();
            List<Coureur> coureurs = new StubCoureurRepository().GetAll();
            _participations.Add(new Participation(courses[0], coureurs[0], 70, 5, "10'00\"", 90));
            _participations.Add(new Participation(courses[1], coureurs[1], 35, 10, "7'50\"", 120));
            _participations.Add(new Participation(courses[2], coureurs[2], 140, 25, "12'34\"", 60));
        }

        public List<Participation> GetAll()
        {
            return _participations;
        }

        public void Save(Participation p)
        {
            _participations.Add(p);
        }

        public void Delete(Participation p)
        {
            _participations.Remove(p);
        }
    }
}
