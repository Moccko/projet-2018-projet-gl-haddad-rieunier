using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;

namespace DAL
{
    public class StubUtilisateurRepository : Repository, IUtilisateurRepository
    {
        private static StubUtilisateurRepository _instance = null;

        public static StubUtilisateurRepository Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new StubUtilisateurRepository();
                return _instance;
            }
        }

        private List<Utilisateur> _utilisateurs;

        private StubUtilisateurRepository()
        {
            _utilisateurs = new List<Utilisateur>();
            _utilisateurs.Add(new Utilisateur("Roman", "Rieunier", "rider", "rrieunier@ensc.fr"));
            _utilisateurs.Add(new Utilisateur("Baptiste", "Pesquet", "visualstudio", "bpesquet@ensc.fr"));
            _utilisateurs.Add(new Utilisateur("Rime", "Haddad", "jenerentrepasdansceconflit", "rhaddad@ensc.fr"));
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

