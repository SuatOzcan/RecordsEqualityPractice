using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecordsEqualityPractice
{
    internal class Parent
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Parent(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public Parent() { }
    }
}
