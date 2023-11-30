using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Implicit.Domain.Entities
{
    public class Kelvin
    {
        public int Degree { get; set; }
        public Kelvin(int kelvinDegree)
        {
            Degree = kelvinDegree;
        }
    }
}
