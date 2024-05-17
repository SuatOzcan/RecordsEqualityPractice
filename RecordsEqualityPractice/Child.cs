using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecordsEqualityPractice
{
    internal class Child : Parent
    {
        public int Id { get; set; }
        public int Potential { get; set; }
        public Child(int id, int potential)
        {
            Id = id;
            Potential = potential;
        }
    }
}
