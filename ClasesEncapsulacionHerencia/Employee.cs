using System;
using System.Collections.Generic;
using System.Text;

namespace ClasesEncapsulacionHerencia
{
    public class Employee : Person
    {
        public int EmployeeId { get; set; }

        public override void GetData()
        {
            base.GetData();
            Console.WriteLine($"Employee Id: {EmployeeId}");
        }
    }
}
