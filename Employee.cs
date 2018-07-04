using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Employee
    {
        //Name of Employee
        public string Name { get; set; }
        //Title of Employee
        public string Title { get; set; }

        public static Employee GetEmployee()
        {

            var emp = new Employee
            {
                Name = "John Doe",
                Title = "Director of Engineering"
            };
            return emp;
        }
    }
}
        
    

