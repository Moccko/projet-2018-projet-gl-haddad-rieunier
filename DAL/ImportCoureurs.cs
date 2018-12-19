using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Csv;
using System.IO;
using Domain;

namespace DAL
{
    public class ImportCoureurs
    {
        private ICoureurRepository _coureur_repository;

        public ImportCoureurs()
        {
            //_coureur_repository = StubCoureurRepository.Instance;
            _coureur_repository = CoureurRepository.Instance;
        }

        public void Import(string file, out int nbImportes, out int total)
        {
            nbImportes = 0;
            total = 0;

            List<Coureur> nouveauxCoureurs = new List<Coureur>();
            string csv = File.ReadAllText(file);
            foreach (ICsvLine line in CsvReader.ReadFromText(csv))
            {
                Console.WriteLine($"{line["prenom"]} {line["datenaissance"]} {line["nom"]}");
                // Au cas où une conversion en entier ou l'accès au rang 0 du string 'sexe' serait impossible
                try
                {
                    int[] dateStr = line["datenaissance"].Split('/').Select(nStr => Convert.ToInt32(nStr)).ToArray();
                    DateTime dateNaissance = new DateTime(dateStr[2], dateStr[1], dateStr[0]);
                    _coureur_repository.Save(new Coureur(line["prenom"], line["nom"], line["sexe"][0], dateNaissance, line["courriel"], line["licence"]));
                    nbImportes++;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                }
                finally
                {
                    total++;
                }
            }
        }
    }
}
