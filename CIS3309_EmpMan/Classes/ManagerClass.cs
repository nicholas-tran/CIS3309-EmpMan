//Nicholas Tran && Jimmy Pham
//CIS 3309
//Frank Friedman
//EmpMan Final Project
//4/30/2018
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Runtime.Serialization.Formatters.Binary;

namespace CIS3309_EmpMan
{
    [Serializable()]
    //Manager class inherits from employee class
    public class ManagerClass : EmployeeClass
    {
        private decimal HiddenManagerSalary;
        private decimal HiddenManagerBonus;

        public ManagerClass()
        {
            HiddenManagerSalary = 0.0m;
            HiddenManagerBonus = 0.0m;
        }
        // Parameterized constructor (not used)
        public ManagerClass(string name, string birthdate, string id, string jt, Decimal salary, Decimal bonus) : base(name, birthdate, id, jt)
        {
            HiddenManagerSalary = salary;
            HiddenManagerBonus = bonus;
        }  // end Manager parametierized constructor


        // Accessor/mutator for salary
        public Decimal managerSalary
        {
            get
            {
                return HiddenManagerSalary;
            }  // end get
            set  //(Decimal value)
            {
                HiddenManagerSalary = value;
            }  // end get
        }  // end Property


        // Accessor/mutator for bonus
        public Decimal managerBonus
        {
            get
            {
                return HiddenManagerBonus;
            }  // end get
            set  //(Decimal value)
            {
                HiddenManagerBonus = value;
            }  // end get
        }  // end Property
        // Save data from form to object
        public override void Save(frmEmpMan f)
        {
            base.Save(f);
            managerSalary = Convert.ToDecimal(f.txtControlManagerSalary.Text);
            managerBonus = Convert.ToDecimal(f.txtControlManagerBonus.Text);
        }  // end Save


        // Display data in object on form
        public override void Display(frmEmpMan f)
        {
            base.Display(f);
            f.txtControlManagerSalary.Text = managerSalary.ToString();
            f.txtControlManagerBonus.Text = managerBonus.ToString();
        }  // end Display


        // This toString function overrides the Employee toString
        //     function.  The base refers to the Employee because this class
        //     inherits Employee by definition.
        public override string ToString()
        {
            string s = base.ToString() + "\n";
            s += "ManagerSalary:     " + HiddenManagerSalary.ToString() + "\n";
            s += "ManagerBonus:      " + HiddenManagerBonus.ToString();
            return s;
        }  // end ToString
    }
}
