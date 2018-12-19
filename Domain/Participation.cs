using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Participation
    {
        public virtual int Id { get; set; }
        public virtual Course Course { get; set; }
        public virtual Coureur Coureur { get; set; }
        public virtual string Temps { get; set; }
        public virtual int NumeroDossard { get; set; }
        public virtual TimeSpan AllureMoyenne { get; set; }
        public virtual double VitesseMoyenne { get; set; }

        public Participation() { }

        public Participation(Course course, Coureur coureur, string temps, int numeroDeDossard)
        {
            Course = course;
            Coureur = coureur;
            NumeroDossard = numeroDeDossard;
            Temps = temps;
        }
        //public override int GetHashCode()
        //{
        //    int hashCode = 0;
        //    hashCode = hashCode ^ Participation.GetHashCode() ^ UnitType.GetHashCode();
        //    return hashCode;
        //}

        //public override bool Equals(object obj)
        //{
        //    var toCompare = obj as RegimenUnittDb;
        //    if (toCompare == null)
        //    {
        //        return false;
        //    }
        //    return (this.GetHashCode() != toCompare.GetHashCode());
        //}
    }
}