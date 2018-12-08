using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public interface ICoureurRepository
    {
        List<Coureur> GetAll();
        void Save(Coureur c);
        void Delete(Coureur c);
    }
}
