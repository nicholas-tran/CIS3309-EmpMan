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
    //Person List class responsible for holding the list of person objects
    public class PersonListClass
    {
        List<PersonClass> PersonList = new List<PersonClass>();

        //Unparameterized Constructor
        public PersonListClass()
        {
            PersonList = new List<PersonClass>();
        }

        //List of the person objects in the list
        public List<PersonClass> getPersonList()
        {
            return PersonList;
        }

        //List string of the person objects
        public string ListString()
        {
            string objectString = "";
            for(int i = 0; i < PersonList.Count; i++)
            {
                objectString += PersonList.ElementAt(i).ToString() + "\n";
            }
            return objectString;
        }
    }
}
