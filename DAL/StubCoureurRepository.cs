using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    /// <summary>
    /// Classe de gestion de données tests sur les coureurs
    /// Implémente le pattern singleton pour pouvoir conserver les données à travers les formulaires
    /// </summary>
    public class StubCoureurRepository : Repository, ICoureurRepository
    {
        private static StubCoureurRepository _instance = null;

        public static StubCoureurRepository Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new StubCoureurRepository();
                }
                return _instance;
            }
        }

        private List<Coureur> _coureurs;

        private StubCoureurRepository()
        {
            _coureurs = new List<Coureur>();
            _coureurs.Add(new Coureur(1997, "rrieunier@ensc.fr", "Rieunier", "Roman", 'M', "187445", new List<Participation>()));
            _coureurs.Add(new Coureur(1996, "rhaddad@ensc.fr", "Haddad", "Rime", 'F', "751667", new List<Participation>()));
            _coureurs.Add(new Coureur(2001, "chaddad@ensc.fr", "Haddad", "Chirine", 'F', "456769", new List<Participation>()));
            _coureurs.Add(new Coureur(1996, "nhaddad@ensc.fr", "Haddad", "Nour", 'F', "649372", new List<Participation>()));
        }

        public List<Coureur> GetAll()
        {
            return _coureurs;
        }

        public void Save(Coureur c)
        {
            _coureurs.Add(c);
        }

        public void Delete(Coureur c)
        {
            _coureurs.Remove(c);
        }

        public List<Coureur> GetByName(string nom)
        {
            return _coureurs.Where(c => c.Nom == nom).ToList();
        }

        public List<Coureur> GetByFirstName(string prenom)
        {
            return _coureurs.Where(c => c.Prenom == prenom).ToList();
        }

        public Coureur GetByLicense(string licence)
        {
            return _coureurs.Where(c => c.NoLicenceFFA == licence).FirstOrDefault();
        }
    }
}
