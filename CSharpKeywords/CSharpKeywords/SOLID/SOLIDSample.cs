using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpRef.SOLID
{
    public class SOLIDSample
    {
        public void TriggerL()
        {
            dynamic ContractEmp = new PermanentEmployee(1, "");
            ContractEmp.GetMinimumSalary();
        }
    }

    #region L - Liskov substitution Principle
    public interface IEmployeeBonus
    {
        public decimal CalculateBonus();
    }
    public interface IEmployee
    {
        int ID { get; set; }
        string Name { get; set; }
        public decimal GetMinimumSalary();
    }
    public abstract class Employee : IEmployee, IEmployeeBonus
    {
        public int ID { get; set; }
        public string Name { get; set; }

        public Employee(int id, string name)
        {
            ID = id;
            Name = name;
        }

        public abstract decimal CalculateBonus();
        public abstract decimal GetMinimumSalary();
    }
    public class PermanentEmployee : Employee
    {
        public PermanentEmployee(int id, string name) : base(id, name)
        {

        }
        public override decimal CalculateBonus()
        {
            return 100;
        }

        public override decimal GetMinimumSalary()
        {
            return 1000;
        }
    }
    public class ContractEmployee : IEmployee
    {
        public int ID { get; set; }
        public string Name { get; set; }

        public decimal GetMinimumSalary()
        {
            return 10;
        }
    }



    #endregion



}
