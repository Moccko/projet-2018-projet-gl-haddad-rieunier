using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Utilisateur
    {
        public virtual int Id { get; set; }
        public virtual string Prenom { get; set; }
        public virtual string Nom { get; set; }
        public virtual string MotDePasse { get; set; }
        public virtual string Courriel { get; set; }

        public Utilisateur() { }

        public Utilisateur(string prenom, string nom, string courriel, string motDePasse)
        {
            Prenom = prenom;
            Nom = nom;
            MotDePasse = motDePasse;
            Courriel = courriel;
        }
    }
}
