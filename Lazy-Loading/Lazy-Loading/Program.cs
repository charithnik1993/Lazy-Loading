using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lazy_Loading
{
    class Program
    {
		//modified by charith ranasinghe
        public class Employee
        {
           

            public int EmployeeID { get; set; }
            public string EmployeeName { get; set; }
            public List<string> EarlyDesignations = null;

            public List<string> deignations
            {
                get
                {
                    if(EarlyDesignations == null)
                    {
                        EarlyDesignations = GetEarlyDesignations(this.EmployeeID);
                    }
                    return EarlyDesignations;
                }
            }
            

            public Employee(int employeeID, string employeeName)
            {
                EmployeeID = employeeID;
                EmployeeName = employeeName;
               
            }

            public List<string> GetEarlyDesignations(int empID)
            {
                List<string> designation = new List<string>();
                designation.Add("Intern");
                designation.Add("Trainee Software Engineer");
                designation.Add("Software Engineer");

                return designation;
            }

        }


        static void Main(string[] args)
        {

            //Employee obj = new Employee(1,"Charith");

            //foreach(var a in obj.EarlyDesignations)
            //{
            //    Console.WriteLine(a);
            //    Console.ReadLine();
            //}

            IServerbale obj = new Explicit_Interface();
            var a = (Explicit_Interface)obj;
            a.Save();
            
           
        }
    }
}
