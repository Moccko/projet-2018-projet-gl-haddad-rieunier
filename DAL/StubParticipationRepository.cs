using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;

namespace DAL
{
    public class StubParticipationRepository : Repository, IParticipationRepository
    {
        private static StubParticipationRepository _instance = null;
        private Random Random;

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
            Random = new Random();
            List<Course> courses = StubCourseRepository.Instance.GetAll();
            List<Coureur> coureurs = StubCoureurRepository.Instance.GetAll();
            const int maxDossard = 10000;
            const int maxHoraire = 60;
            _participations.Add(new Participation(courses[0], coureurs[0], $"{Random.Next(2)}:{Random.Next(maxHoraire)}:{Random.Next(maxHoraire)}", Random.Next(maxDossard)));
            _participations.Add(new Participation(courses[0], coureurs[1], $"{Random.Next(2)}:{Random.Next(maxHoraire)}:{Random.Next(maxHoraire)}", Random.Next(maxDossard)));
            _participations.Add(new Participation(courses[1], coureurs[2], $"{Random.Next(2)}:{Random.Next(maxHoraire)}:{Random.Next(maxHoraire)}", Random.Next(maxDossard)));
            _participations.Add(new Participation(courses[2], coureurs[1], $"{Random.Next(2)}:{Random.Next(maxHoraire)}:{Random.Next(maxHoraire)}", Random.Next(maxDossard)));
        }

        public List<Participation> GetAll()
        {
            return _participations;
        }

        public void Save(Participation p)
        {
            _participations.Add(p);
        }

        public void Save(List<Participation> l)
        {
            _participations.AddRange(l);
        }

        public void Delete(Participation p)
        {
            _participations.Remove(p);
        }

        public List<Participation> GetByCoureur(Coureur c)
        {
            return GetAll().Where(p => p.Coureur == c).OrderBy(p => p.Course.Nom).ThenBy(p => p.Course.Date).ToList();
        }

        public List<Participation> GetByCourse(Course c)
        {
            return GetAll().Where(p => p.Course == c).OrderBy(p => p.Coureur.Nom).ThenBy(p => p.Coureur.Prenom).ToList();
        }

        public Participation[] GetClassement(Course c)
        {
            return GetByCourse(c).OrderBy(p => p.Temps).ToArray();
        }

        private int _age(Coureur c)
        {
            return Convert.ToInt32(DateTime.Now.Subtract(c.DateNaissance).TotalDays) / 365;
        }

        public Participation[] GetClassement(Course c, int[] tAge)
        {
            return GetClassement(c).Where(p => _age(p.Coureur) >= tAge[0] && _age(p.Coureur) < tAge[1]).ToArray();
        }
    }
}
