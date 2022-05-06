using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pharmacy
{
    public class Pharmacist
    {
        public int ID { get; set; }
        public string FullName { get; set; }
        public int Experience { get; set; }

        public List<Pharmacist> GetPharmacists()
        {
            return new List<Pharmacist>()
            {
                new Pharmacist { ID = 1, FullName = "Шагиахметова Зиля Рустемовна", Experience = 3},
                new Pharmacist { ID = 2, FullName = "Столярова Ляйсан Рустемовна", Experience = 4},
                new Pharmacist { ID = 3, FullName = "Артемьев Егор Артемович", Experience = 5}
            };
        }
    }
}
