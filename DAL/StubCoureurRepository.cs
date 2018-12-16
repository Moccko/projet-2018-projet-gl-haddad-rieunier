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
            Random r = new Random();
            int maxLicence = 10000000;
            string alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            _coureurs.Add(new Coureur("Roman", "Rieunier", 'M', new DateTime(1997, 9, 22), "rrieunier@ensc.fr", $"{r.Next(maxLicence)}{alphabet[r.Next(alphabet.Length)]}"));
            _coureurs.Add(new Coureur("Rime", "Haddad", 'F', new DateTime(1996, 6, 19), "rhaddad@ensc.fr", $"{r.Next(maxLicence)}{alphabet[r.Next(alphabet.Length)]}"));
            _coureurs.Add(new Coureur("Lucas", "Dutournier", 'M', new DateTime(1997, 3, 17), "ldutournier@ensc.fr", $"{r.Next(maxLicence)}{alphabet[r.Next(alphabet.Length)]}"));
            _coureurs.Add(new Coureur("Antoine", "Loizel", 'M', new DateTime(1996, 12, 14), "nhaddad@ensc.fr", $"{r.Next(maxLicence)}{alphabet[r.Next(alphabet.Length)]}"));
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
