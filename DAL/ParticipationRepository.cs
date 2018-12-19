using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;

namespace DAL
{
    public class ParticipationRepository : Repository, IParticipationRepository
    {
        private static ParticipationRepository _instance = null;
        public static ParticipationRepository Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new ParticipationRepository();
                return _instance;
            }
        }

        private ParticipationRepository() { }

        public List<Participation> GetAll()
        {
            return Session.Query<Participation>().ToList();
        }

        public void Save(Participation p)
        {
            Session.SaveOrUpdate(p);
            Session.Flush();
        }

        public void Save(List<Participation> l)
        {
            l.ForEach(p => Session.SaveOrUpdate(p));
            Session.Flush();
        }

        public void Delete(Participation p)
        {
            Session.Delete(p);
            Session.Flush();
        }

        public List<Participation> GetByCoureur(Coureur c)
        {
            return Session.Query<Participation>().Where(p => p.Coureur == c).ToList();
        }

        public List<Participation> GetByCourse(Course c)
        {
            return Session.Query<Participation>().Where(p => p.Course == c).ToList();
        }

        public Participation[] GetClassement(Course c)
        {
            return GetByCourse(c).OrderBy(p => p.Temps).ToArray();
        }

        public Participation[] GetClassement(Course c, int[] tAge)
        {
            return GetByCourse(c).ToList().Where(p => p.Coureur.Age() >= tAge[0] && p.Coureur.Age() < tAge[1]).OrderBy(p => p.Temps).ToArray();
        }
    }
}
