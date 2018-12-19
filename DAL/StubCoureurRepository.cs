using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;

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

            _coureurs.Add(new Coureur("Roman", "Rieunier", 'M', new DateTime(1997, 9, 22), "rrieunier@ensc.fr", "6149586E"));
            _coureurs.Add(new Coureur("Rime", "Haddad", 'F', new DateTime(1996, 6, 19), "rhaddad@ensc.fr", "1950534A"));
            _coureurs.Add(new Coureur("Lucas", "Dutournier", 'M', new DateTime(1997, 3, 17), "ldutournier@ensc.fr", "5338940L"));
            _coureurs.Add(new Coureur("Antoine", "Loizel", 'M', new DateTime(1996, 12, 14), "nhaddad@ensc.fr", "7088404P"));
        }

        public List<Coureur> GetAll()
        {
            return _coureurs.OrderBy(c => c.Nom).ThenBy(c => c.Prenom).ToList();
        }

        public void Save(Coureur c)
        {
            _coureurs.Add(c);
        }

        public void Save(List<Coureur> l)
        {
            _coureurs.AddRange(l);
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
            return _coureurs.Where(c => c.LicenceFFA == licence).FirstOrDefault();
        }
    }
}
