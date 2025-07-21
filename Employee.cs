using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    struct Employee
    {
        #region attributes

        private int Id;
        private string Name;
        private decimal Salary;

        #endregion


        // applay encapsulation
        //       1. all atributes should be private
        //          1. use Setters and Getters
        //          2. use properties

        #region applay encapsulation using setters and getters

        public string getName()
        {
            return Name;
        }
        public void SetName(string name)
        {
            Name = name.Length > 10 ? name.Substring(0 , 10) : name;
        }

        #endregion

        #region constructor

        // public employee() => manually
        // CTOR + tab
        // from attributes

        public Employee(int id, string name, decimal salary)
        {
            Id = id;
            Name = name;
            Salary = salary;
        }


        #endregion


        #region methods

        public override string ToString()
        {
            return $"Employee:ID: {Id},\nName: {Name},\nSalary: {Salary:C}\n";
        }

        #endregion

    }
}
