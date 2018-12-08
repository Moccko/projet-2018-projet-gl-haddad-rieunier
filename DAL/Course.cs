using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    class Course
    {
        public virtual string Nom { get; set; }
        public virtual int Annee { get; set; }
        public virtual List<Participation> Participations { get; set; }

        public Course() { }

        public Course(string nom, int annee, List<Participation> participations)
        {
            Nom = nom;
            Annee = annee;
            Participations = participations;
        }
    }
}
