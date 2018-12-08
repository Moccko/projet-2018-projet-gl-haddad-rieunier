using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Utilisateur
    {
        public virtual string NomUtilisateur { get; set; }
        public virtual string MotDePasse { get; set; }
        public virtual string Courriel { get; set; }

        public Utilisateur() { }

        public Utilisateur(string nomUtilisateur, string motDePasse, string courriel)
        {
            NomUtilisateur = nomUtilisateur;
            MotDePasse = motDePasse;
            Courriel = courriel;
        }
    }
}
