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

    //Person class is the base clase
    [Serializable()]
    public abstract class PersonClass
    {
        private string HiddenPersonName;
        private DateTime HiddenPersonBirthDate;
        private string HiddenPersonID;

        //Non Parameterized constructor
        public PersonClass()
        {
            HiddenPersonName = "";
            HiddenPersonBirthDate = DateTime.Today;
            HiddenPersonID = "";
        }

        //Parameterized constructor
        public PersonClass(string name, string birthdate, string id)
        {
            HiddenPersonName = name;
            HiddenPersonBirthDate = Convert.ToDateTime(birthdate);
            HiddenPersonID = id;
        }  // end Person parameterized constructor


        // Accessor/mutator for name
        public string personName
        {
            get
            {
                return HiddenPersonName;
            }  // end get
            set   // (string value)
            {
                HiddenPersonName = value;
            }  // end get
        }  // end Property


        // Accessor/mutator for birth date
        public DateTime personBirthDate
        {
            get
            {
                return HiddenPersonBirthDate;
            }  // end get
            set   // (DateTime value)
            {
                HiddenPersonBirthDate = value;
            }  // end get
        }  // end Property


        // Accessor/mutator for id
        public string personID
        {
            get
            {
                return HiddenPersonID;
            } //  end get
            set   // (string value)
            {
                HiddenPersonID = value;
            }  // end get
        }  // End Property


        // Save data from form to object
        public virtual void Save(frmEmpMan f)
        {
            personName = f.txtControlPersonName.Text;
            personBirthDate = DateTime.Parse(f.txtControlPersonBirthDate.Text);
            personID = f.txtControlPersonID.Text;
        }  // end Save


        // Display data in object on form
        public virtual void Display(frmEmpMan f)
        {
            f.txtControlPersonName.Text = personName;
            f.txtControlPersonBirthDate.Text = personBirthDate.ToShortDateString();
            f.txtControlPersonID.Text = personID;
        }  // end Display


        // This toString function overrides the Object toString
        // function.  The base refers to Object because this class
        // inherits Object by default.
        public override string ToString()
        {
            string s = "ObjectType       : " + base.ToString() + "\n";
            s += "PersonName     : " + HiddenPersonName + "\n";
            s += "PersonBirthDate: " + HiddenPersonBirthDate.ToShortDateString() + "\n";
            s += "PersonID       :" + HiddenPersonID;
            return s;
        }  // end ToString

    }
}
