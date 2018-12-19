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
    public class ImportParticipations
    {
        private ICourseRepository _course_repository;
        private ICoureurRepository _coureur_repository;
        private IParticipationRepository _participation_repository;
        private Course _course;

        public ImportParticipations(Course c)
        {
            //_course_repository = StubCourseRepository.Instance;
            _course_repository = CourseRepository.Instance;
            //_participation_repository = StubParticipationRepository.Instance;
            _participation_repository = ParticipationRepository.Instance;
            //_coureur_repository = StubCoureurRepository.Instance;
            _coureur_repository = CoureurRepository.Instance;
            _course = c;
        }

        public void Import(string file, out int nbImportes, out int total)
        {
            nbImportes = 0;
            total = 0;

            List<Participation> nouvellesParticipations = new List<Participation>();
            string csv = File.ReadAllText(file);

            foreach (ICsvLine line in CsvReader.ReadFromText(csv))
            {
                string licence = line["licence"];

                Coureur coureur = _coureur_repository.GetByLicense(licence);

                // Au cas où la participation serait invalide
                try
                {
                    _participation_repository.Save(new Participation(_course, coureur, line["temps"], Convert.ToInt32(line["dossard"])));
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
            _participation_repository.Save(nouvellesParticipations);
        }
    }
}
