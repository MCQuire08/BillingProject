using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class SuperHero
    {
        public string Id { get; set; }

        public required string Name { get; set; }

        public string LastName { get; set; }

        public string FirstName { get; set; }

        public string Place { get; set; }
    }
}
