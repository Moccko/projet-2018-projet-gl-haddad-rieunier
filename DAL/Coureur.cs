using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    class Coureur
    {
        public virtual int Annee { get; set; }
        public virtual string Courriel { get; set; }
        public virtual string Nom { get; set; }
        public virtual string Prenom { get; set; }
        public virtual char Sexe { get; set; }
        public virtual string NoLicenceFFA { get; set; }
        public virtual List<Participation> Participations { get; set; }

        public Coureur() { }

        public Coureur(int annee, string courriel, string nom, string prenom, char sexe, string noLicenceFFA, List<Participation> participations)
        {
            Annee = annee;
            Courriel = courriel;
            Nom = nom;
            Prenom = prenom;
            Sexe = sexe;
            NoLicenceFFA = noLicenceFFA;
            Participations = participations;
        }
    }
}
