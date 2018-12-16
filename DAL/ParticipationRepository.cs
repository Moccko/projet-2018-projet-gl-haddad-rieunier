using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ParticipationRepository : Repository, IParticipationRepository

    {
        public List<Participation> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Save(Participation p)
        {
            throw new NotImplementedException();
        }

        public void Save(List<Participation> l)
        {
            throw new NotImplementedException();
        }

        public void Delete(Participation p)
        {
            throw new NotImplementedException();
        }

        public List<Participation> GetByCoureur(Coureur c)
        {
            throw new NotImplementedException();
        }

        public List<Participation> GetByCourse(Course c)
        {
            throw new NotImplementedException();
        }
    }
}
