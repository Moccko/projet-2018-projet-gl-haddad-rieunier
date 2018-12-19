using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;

namespace DAL
{
    public interface ICoureurRepository
    {
        List<Coureur> GetAll();
        List<Coureur> GetByName(string nom);
        List<Coureur> GetByFirstName(string prenom);
        Coureur GetByLicense(string licence);
        void Save(Coureur c);
        void Save(List<Coureur> l);
        void Delete(Coureur c);
    }
}
