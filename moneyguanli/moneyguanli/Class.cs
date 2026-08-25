using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class
{
    internal class Lei
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Bumen { get; set; }
        public double Salary { get; set; }

        public Lei(int id, string name, string bumen, double salary)
        {
            Id = id;
            Name = name;
            Bumen = bumen;
            Salary = salary;
        }
    }
}