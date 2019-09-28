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
using System.Text.RegularExpressions;

namespace CIS3309_EmpMan
{
    // Validator class is responsible for validating data entered into the text boxes
    class ValidatorClass
    {
        // Validates if only english characters were used 
        public bool IsValidEnglishCharacters(string name)
        {
            bool validName = Regex.IsMatch(name, @"^[a-zA-Z\s?]+$");

            if (validName == false)
            {
                return false;
            }
            return true;

        }//end IsValidName

        // Validates for numbers only
        public bool IsValidID(string userID)
        {
            bool validID = Regex.IsMatch(userID, @"^[0-9]+$");
            if (validID == false)
            {
                return false;
            }
            return true;
        }


        //Validates date entered
        //Date is valid only for years over 1900 and before the current date
        public bool IsValidDate(string date)
        {
            DateTime currentDate;
            try
            {
                currentDate = Convert.ToDateTime(date);
            }
            catch
            {
                return false;
            }

            if (currentDate.Year >= 1900 && currentDate <= DateTime.Today)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        // Validates for currency
        public bool IsValidCurrency(string currency)
        {
            Decimal money;
            try 
            {
                money = Convert.ToDecimal(currency);
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
