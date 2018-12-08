using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class StubCoureurRepository : Repository, ICoureurRepository
    {
        private List<Coureur> _coureurs;

        public StubCoureurRepository()
        {
            _coureurs = new List<Coureur>();
            _coureurs.Add(new Coureur(1997, "rrieunier@ensc.fr", "Rieunier", "Roman", 'M', "vev534erv", new List<Participation>()));
            _coureurs.Add(new Coureur(1996, "rhaddad@ensc.fr", "Haddad", "Rime", 'F', "gsr354tg", new List<Participation>()));
            _coureurs.Add(new Coureur(2001, "chaddad@ensc.fr", "Haddad", "Chirine", 'F', "rtger345r", new List<Participation>()));
            _coureurs.Add(new Coureur(1996, "nhaddad@ensc.fr", "Haddad", "Nour", 'F', "gr5tg5r6", new List<Participation>()));
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
    }
}
