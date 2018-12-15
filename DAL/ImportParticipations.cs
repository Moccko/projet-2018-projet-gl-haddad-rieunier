using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Csv;
using System.IO;

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
            _course_repository = StubCourseRepository.Instance;
            _participation_repository = StubParticipationRepository.Instance;
            _coureur_repository = StubCoureurRepository.Instance;
            _course = c;
        }

        public int Import(string file)
        {
            List<Participation> nouvellesParticipations = new List<Participation>();
            string csv = File.ReadAllText(file);
            foreach (ICsvLine line in CsvReader.ReadFromText(csv))
            {
                string licence = line["licence"];

                Coureur coureur = _coureur_repository.GetByLicense(licence);
                if (coureur == null)
                {
                    return 0;
                }

                nouvellesParticipations.Add(new Participation(_course, coureur, Convert.ToInt32(line["dossard"]), line["temps"]));
            }
            _participation_repository.Save(nouvellesParticipations);

            return nouvellesParticipations.Count();
        }
    }
}
