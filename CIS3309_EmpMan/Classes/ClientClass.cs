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
    //CLient class which inherits Person Class
    public class ClientClass : PersonClass
    {
        //Attribute of the client class
        private string HiddenClientType;

        //Unparameterized constructor
        public ClientClass()
        {
            HiddenClientType = "";
        }
        //Parameterized constructor
        public ClientClass(string name, string birthdate, string id, string type) : base(name, birthdate, id)
        {
            HiddenClientType = type;
        }  // end Manager parametierized constructor


        // Accessor/mutator for salary
        public string clientType
        {
            get
            {
                return HiddenClientType;
            }  // end get
            set  //(Decimal value)
            {
                HiddenClientType = value;
            }  // end get
        }  // end Property

        // Save data from form to object
        public override void Save(frmEmpMan f)
        {
            base.Save(f);
            clientType = f.txtControlClientType.Text;
        }  // end Save


        // Display data in object on form
        public override void Display(frmEmpMan f)
        {
            base.Display(f);
            f.txtControlClientType.Text = clientType;
        }  // end Display


        // This toString function overrides the Employee toString
        //     function.  The base refers to the Employee because this class
        //     inherits Employee by definition.
        public override string ToString()
        {
            string s = base.ToString() + "\n";
            s += "Client Type:     " + HiddenClientType.ToString() + "\n";
            return s;
        }  // end ToString
    }
}
