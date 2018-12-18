using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public interface IParticipationRepository
    {
        List<Participation> GetAll();
        void Save(Participation p);
        void Save(List<Participation> l);
        void Delete(Participation p);
        List<Participation> GetByCoureur(Coureur c);
        List<Participation> GetByCourse(Course c);
        Participation[] GetClassement(Course c);
        Participation[] GetClassement(Course c, int[] tAge);
    }
}
