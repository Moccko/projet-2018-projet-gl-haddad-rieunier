using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;

namespace DAL
{
    public class UtilisateurRepository : Repository, IUtilisateurRepository
    {
        private static UtilisateurRepository _instance = null;
        public static UtilisateurRepository Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new UtilisateurRepository();
                return _instance;
            }
        }

        private UtilisateurRepository() { }

        public List<Utilisateur> GetAll()
        {
            return Session.Query<Utilisateur>().ToList();
        }

        public void Save(Utilisateur u)
        {
            Session.SaveOrUpdate(u);
            Session.Flush();
        }

        public void Delete(Utilisateur u)
        {
            Session.Delete(u);
            Session.Flush();
        }

        public Utilisateur Exists(string c, string m)
        {
            return Session.Query<Utilisateur>().Where(u => u.Courriel == c && u.MotDePasse == m).FirstOrDefault();
        }
    }
}
