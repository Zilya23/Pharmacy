using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pharmacy
{
    public class Pharm
    {
        public int ID { get; set; }
        public string Address { get; set; }

        public List<Pharm> GetPharms()
        {
            return new List<Pharm>()
            {
                new Pharm { ID = 1, Address = "Зорге 66"},
                new Pharm { ID = 2, Address = "Мавлютова 3"},
                new Pharm { ID = 3, Address = "Юлиуса Фучика 67"}
            };
        }
    }
}
