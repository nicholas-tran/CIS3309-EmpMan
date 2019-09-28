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

    // Worker class which inherits from the employee class
    public class WorkerClass : EmployeeClass
    {
        private decimal hiddenEmployeeHourlyPay;

        public WorkerClass()
        {
            hiddenEmployeeHourlyPay = 0.0m;
        }
        public WorkerClass(string name, string birthdate, string id, string jt, Decimal hourly) : base(name, birthdate, id, jt)
        {
            hiddenEmployeeHourlyPay = hourly;
        }  // end Manager parametierized constructor


        // Accessor/mutator for salary
        public Decimal employeeHourlyPay
        {
            get
            {
                return hiddenEmployeeHourlyPay;
            }  // end get
            set  //(Decimal value)
            {
                hiddenEmployeeHourlyPay = value;
            }  // end get
        }  // end Property

        // Save data from form to object
        public override void Save(frmEmpMan f)
        {
            base.Save(f);
            employeeHourlyPay = Convert.ToDecimal(f.txtControlWorkerHourlyPay.Text);
        }  // end Save


        // Display data in object on form
        public override void Display(frmEmpMan f)
        {
            base.Display(f);
            f.txtControlWorkerHourlyPay.Text = employeeHourlyPay.ToString();
        }  // end Display


        // This toString function overrides the Employee toString
        //     function.  The base refers to the Employee because this class
        //     inherits Employee by definition.
        public override string ToString()
        {
            string s = base.ToString() + "\n";
            s += "ManagerSalary:     " + hiddenEmployeeHourlyPay.ToString() + "\n";
            return s;
        }  // end ToString
    }
}

