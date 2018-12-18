﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Coureur
    {
        public virtual string Prenom { get; set; }
        public virtual string Nom { get; set; }
        public virtual char Sexe { get; set; }
        public virtual DateTime DateNaissance { get; set; }
        public virtual string Courriel { get; set; }
        public virtual string NoLicenceFFA { get; set; }
        public int Age
        {
            get
            {
                return Convert.ToInt32(DateTime.Now.Subtract(DateNaissance).TotalDays) / 365;
            }
        }
        public List<Participation> Participations { get { return StubParticipationRepository.Instance.GetByCoureur(this).ToList(); } }

        public Coureur() { }

        public Coureur(string prenom, string nom, char sexe, DateTime naissance, string courriel, string noLicenceFFA)
        {
            Prenom = prenom;
            Nom = nom;
            Sexe = sexe;
            DateNaissance = naissance;
            Courriel = courriel;
            NoLicenceFFA = noLicenceFFA;
        }

        public override string ToString()
        {
            return $"{Prenom} {Nom.ToUpper()}";
        }
    }
}
