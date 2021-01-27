using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace emply_promotion_list
{
    public class Employeedetails
    {
        List<string> emp_name = new List<string>();
        string name;
        public void Add_employee_name()
        {
            do
            {
                name = Console.ReadLine();
                emp_name.Add(name);
            } while (!string.IsNullOrEmpty(name));
        }
        public void sort_list()
        {
            emp_name = emp_name.OrderBy(n => n).ToList();

        }
        public void Display()
        {
            foreach(string name in emp_name)
            {
                Console.WriteLine("{0}", name);
            }
        }
    }
}
