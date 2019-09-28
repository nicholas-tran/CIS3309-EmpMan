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
    //Abstract employee class which inherits from person class.
    public abstract class EmployeeClass : PersonClass
    {
        //Attribute of the employee class
        private string HiddenEmployeeJobTitle;

        //Un-parameterized constructor for employee class
        public EmployeeClass()
        {
            HiddenEmployeeJobTitle = "";
        }

        //Parameterized constructor for employee class
        public EmployeeClass(string name, string birthdate, string id, string title) : base(name, birthdate, id)
        {
            HiddenEmployeeJobTitle = title;
        }  // end Person parameterized constructor


        // Accessor/mutator for name
        public string EmployeeJobTitle
        {
            get
            {
                return HiddenEmployeeJobTitle;
            }  // end get
            set   // (string value)
            {
                HiddenEmployeeJobTitle = value;
            }  // end get
        }  // end Property

        // Save data from form to object
        public override void Save(frmEmpMan f)
        {
            personName = f.txtControlPersonName.Text;
            personBirthDate = DateTime.Parse(f.txtControlPersonBirthDate.Text);
            personID = f.txtControlPersonID.Text;
        }  // end Save


        // Display data in object on form
        public override void Display(frmEmpMan f)
        {
            f.txtControlEmployeeJobTitle.Text = EmployeeJobTitle;
        }  // end Display


        // This toString function overrides the Object toString
        // function.  The base refers to Object because this class
        // inherits Object by default.
        public override string ToString()
        {
            string s = "ObjectType       : " + base.ToString() + "\n";
            s += "PersonName     : " + HiddenEmployeeJobTitle + "\n";
            return s;
        }  // end ToString

    }//end employee class
}//end namespace
