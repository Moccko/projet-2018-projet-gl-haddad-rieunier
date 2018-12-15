using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class CoureurRepository : Repository, ICoureurRepository
    {
        public CoureurRepository()
        {

        }

        public List<Coureur> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Save(Coureur c)
        {
            throw new NotImplementedException();
        }

        public void Delete(Coureur c)
        {
            throw new NotImplementedException();
        }

        public List<Coureur> GetByName(string nom)
        {
            throw new NotImplementedException();
        }

        public List<Coureur> GetByFirstName(string prenom)
        {
            throw new NotImplementedException();
        }

        public Coureur GetByLicense(string licence)
        {
            throw new NotImplementedException();
        }
    }
}
