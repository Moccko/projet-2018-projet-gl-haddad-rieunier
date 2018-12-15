using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace App
{
    public static class UtilisateurCourant
    {
        private static Utilisateur _instance = null;

        private static IUtilisateurRepository _utilisateur_repository = new UtilisateurRepository();

        public static bool Connecter(string utilisateur, string mdp)
        {
            _instance = _utilisateur_repository.GetAll().Where(u => u.NomUtilisateur == utilisateur).Where(u => u.MotDePasse == mdp).FirstOrDefault();
            return EstConnecte();
        }

        public static bool EstConnecte()
        {
            return _instance == null;
        }

        public static void Deconnecter()
        {
            _instance = null;
        }
    }
}
