using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class StubUtilisateurRepository: Repository, IUtilisateurRepository
    {
        private List<Utilisateur> _utilisateurs;

        public StubUtilisateurRepository()
        {
            _utilisateurs = new List<Utilisateur>();
            _utilisateurs.Add(new Utilisateur("rrieunier","rider","rrieunier@ensc.fr"));
            _utilisateurs.Add(new Utilisateur("bpesquet","visualstudio","rhaddad@ensc.fr"));
            _utilisateurs.Add(new Utilisateur("rhaddad", "jenerentrepasdansceconflit", "rhaddad@ensc.fr"));
        }

        public List<Utilisateur> GetAll()
        {
            return _utilisateurs;
        }

        public void Save(Utilisateur u)
        {
            _utilisateurs.Add(u);
        }

        public void Delete(Utilisateur u)
        {
            _utilisateurs.Remove(u);
        }
    }
}

