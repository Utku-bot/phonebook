using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phonebook.Entities
{
    public class DirectoryRegistration
    {
        public Guid ID { get; set; }
        public string Name { get; set; }

        public string Surname { get; set; }
        public string PhoneNumber1 { get; set; }

        public string PhoneNumber2 { get; set; }

        public string PhoneNumber3 { get; set; }
        public string Address { get; set; }
        public string EmailAddress { get; set; }

        public string Webpage { get; set; }

        public string Description { get; set; }

        public override string ToString()
        {
            return $"{Name} {Surname}";
        }



    }
}
