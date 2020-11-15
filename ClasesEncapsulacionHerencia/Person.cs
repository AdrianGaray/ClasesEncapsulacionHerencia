using System;
using System.Collections.Generic;
using System.Text;

namespace ClasesEncapsulacionHerencia
{
    public class Person
    {
        public string FullName { get; set; }
        public int Age { get; set; }
        public virtual void GetData()
        {
            Console.WriteLine($"Full Name: {FullName}");
            Console.WriteLine($"Age: {FullName}");
        }
    }
}
