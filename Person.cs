using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_project
{
    class Person
    {
        string FirstName;
        string MiddleInitial;
        string LastName;
        public string BirthDate;
        public string Address;

        public Person(string firstName, string lastName, string address, string middleInitial = "")
        {
            this.FirstName = firstName;
            this.MiddleInitial = middleInitial;
            this.LastName = lastName;
            this.Address = address;
        }
        public string GetFullName()
        {
            string fullName;
            char[] fName = FirstName.ToCharArray();
            fName[0] = char.ToUpper(fName[0]);
            for (int counter = 1; counter < fName.Length; counter++)
            {
                fName[counter] = char.ToLower(fName[counter]);
                if (fName[counter-1] == ' ')
                {
                    if (char.IsLower(fName[counter]))
                    {
                        fName[counter] = char.ToUpper(fName[counter]);
                    }
                }
            }
            char[] lName = LastName.ToCharArray();
            lName[0] = char.ToUpper(lName[0]);
            for (int counter = 1; counter < lName.Length; counter++)
            {
                lName[counter] = char.ToLower(lName[counter]);
                if (lName[counter - 1] == ' ')
                {
                    if (char.IsLower(lName[counter]))
                    {
                        lName[counter] = char.ToUpper(lName[counter]);
                    }
                }
            }
            if (string.IsNullOrEmpty(MiddleInitial))
            {
                fullName = new string(fName) + " " + new string(lName);
                return fullName;
            }
            else
            {
                char[] midIni = MiddleInitial.ToCharArray();
                midIni[0] = char.ToUpper(midIni[0]);
                fullName = new string(fName) + " " + new string(midIni) + ". " + new string(lName);
                return fullName;
            }
            
        }

        public int GetAge()
        {
            return Calculations.CalculateAge(BirthDate);
        }
    }
}
