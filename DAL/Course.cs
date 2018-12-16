using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Course
    {
        public virtual string Nom { get; set; }
        public virtual DateTime Annee { get; set; }
        public virtual List<Participation> Participations { get { return StubParticipationRepository.Instance.GetByCourse(this).ToList(); } }

        public Course() { }

        public Course(string nom, DateTime annee)
        {
            Nom = nom;
            Annee = annee;
        }

        public override string ToString()
        {
            return $"{Nom}, {Annee}";
        }
    }
}
