using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExploreCSharp.LINQ
{
    public class ProjectionOperator
    {
        public void Usage()
        {
            List<Employee> employees = new List<Employee>();


            IEnumerable<string> Data = employees.Select(x => x.FirstName);//Select method takes function as parameter. Function 
                                                                          //takes Employee instance as input and string as output

            //IEnumerable<TempModel> CustomData = employees.Select(x => new { FirstName = x.FirstName, BirthYear = x.YearOfBirth });//Returns an anonymous type that returns
            //FirstName and YearOfBirth property

            //Above statement will throw error. Cannot convert anonymous type to TempModel
            //var type can be used for anonymous function
            var CustomData = employees.Select(x => new { FirstName = x.FirstName, BirthYear = x.YearOfBirth });



        }
    }

    public class TempModel
    {
        public string FirstName;
        public int BirthYear;
    }


    public class Employee
    {
        public string FirstName;
        public string LastName;
        public string Designation;
        public int YearOfBirth;
        public Employee()
        {

        }
    }
}
