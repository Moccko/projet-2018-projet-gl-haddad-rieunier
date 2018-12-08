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
        void Delete(Participation p);
    }
}
