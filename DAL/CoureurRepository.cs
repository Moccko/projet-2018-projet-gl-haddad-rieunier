using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;

namespace DAL
{
    public class CoureurRepository : Repository, ICoureurRepository
    {
        private static CoureurRepository _instance = null;
        public static CoureurRepository Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new CoureurRepository();
                return _instance;
            }
        }

        private CoureurRepository() { }

        public List<Coureur> GetAll()
        {
            return Session.Query<Coureur>().OrderBy(c => c.Nom).ThenBy(c => c.Prenom).ToList();
        }

        public void Save(Coureur c)
        {
            Session.SaveOrUpdate(c);
            Session.Flush();
        }

        public void Save(List<Coureur> l)
        {
            l.ForEach(c => Session.SaveOrUpdate(c));
            Session.Flush();
        }

        public void Delete(Coureur c)
        {
            Session.Delete(c);
            Session.Flush();
        }

        public List<Coureur> GetByName(string nom)
        {
            return Session.Query<Coureur>().Where(c => c.Nom == nom).ToList();
        }

        public List<Coureur> GetByFirstName(string prenom)
        {
            return Session.Query<Coureur>().Where(c => c.Prenom == prenom).ToList();
        }

        public Coureur GetByLicense(string licence)
        {
            return Session.Query<Coureur>().Where(c => c.LicenceFFA == licence).FirstOrDefault();
        }
    }
}
