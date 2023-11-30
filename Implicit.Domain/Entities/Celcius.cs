using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Implicit.Domain.Entities
{
    public class Celcius
    {
        public int Degree { get; set; }

        public Celcius(int celciusDegree)
        {
            Degree = celciusDegree;
        }

        public static implicit operator Kelvin(Celcius celcius)
        {
            return new Kelvin(celcius.Degree + 273);
        }
    }
}
