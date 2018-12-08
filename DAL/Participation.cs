using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    class Participation
    {
        public virtual Course Course { get; set; }
        public virtual Coureur Coureur { get; set; }
        public virtual double AllureMoyenne { get; set; }
        public virtual int NumeroDeDossard { get; set; }
        public virtual string Temps { get; set; }
        public virtual double VitesseMoyenne { get; set; }

        public Participation() { }

        public Participation(Course course, Coureur coureur, double allureMoyenne, int numeroDeDossard, string temps, double vitesseMoyenne)
        {
            Course = course;
            Coureur = coureur;
            AllureMoyenne = allureMoyenne;
            NumeroDeDossard = numeroDeDossard;
            Temps = temps;
            VitesseMoyenne = vitesseMoyenne;
        }
    }
}