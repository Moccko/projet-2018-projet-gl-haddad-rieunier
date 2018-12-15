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
        List<Coureur> GetByName(string nom);
        List<Coureur> GetByFirstName(string prenom);
        Coureur GetByLicense(string licence);
        void Save(Coureur c);
        void Delete(Coureur c);
    }
}
