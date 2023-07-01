using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula199
{
    public class Person
    {

        public string? Name { get; set; }
        public string? Email { get; set; }

        public override string ToString()
        {
            return $"Nome {Name} Email: {Email}";
        }
    }
}