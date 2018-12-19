using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;

namespace DAL
{
    public interface IUtilisateurRepository
    {
        List<Utilisateur> GetAll();
        void Save(Utilisateur u);
        void Delete(Utilisateur u);
        Utilisateur Exists(string c, string m);
    }
}
