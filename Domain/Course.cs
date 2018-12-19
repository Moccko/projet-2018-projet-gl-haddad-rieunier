using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Course
    {
        public virtual int Id { get; set; }
        public virtual string Nom { get; set; }
        public virtual DateTime Date { get; set; }
        //public virtual List<Participation> Participations { get { return StubParticipationRepository.Instance.GetByCourse(this).ToList(); } }

        public Course() { }

        public Course(string nom, DateTime annee)
        {
            Nom = nom;
            Date = annee;
        }

        public override string ToString()
        {
            return $"{Nom}, {Date.Year}";
        }
    }
}
