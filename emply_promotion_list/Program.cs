using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace emply_promotion_list
{
    class Program
    {
        static void Main(string[] args)
        {
            Employeedetails em = new Employeedetails();
            Console.WriteLine("Please enter the employee names in the order of their eligibility for promotion");
            em.Add_employee_name();
            Console.WriteLine("Promoted employee list:");
            em.sort_list();
            em.Display();
            Console.ReadKey();
        }
    }
}
