using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirlinesBooking.Domain.Model
{
    internal class User: EntityBase
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Account { get; set; }
        public string Password { get; set; }
    }
}
