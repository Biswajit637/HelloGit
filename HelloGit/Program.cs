using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EMS;

namespace HelloGit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello !!");
            Console.WriteLine("Today is 27-09-2022");
            Emp emp = new Emp { Id = 10, Name = "Bitu", Salary = 55000 };
            Console.WriteLine($"{emp.Id} {emp.Name} {emp.Salary}");

        }
    }
}
