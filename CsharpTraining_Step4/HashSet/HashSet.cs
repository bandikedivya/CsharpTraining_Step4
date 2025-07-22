using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistrationHashSet
{
    class AccountRegistration
    {

        // HashSet -- Uses System.Collections.Generic; namespace
        // Syntax:
        // HashSet<T> hashset = new HashSet<T>();
        static void Main()
        {
            HashSet<string> RegDetails = new HashSet<string>();
            RegDetails.Add("divya@gmail.com");
            RegDetails.Add("divya@gmail.com"); //Prints only once as HashSet Doesn't allows duplicates(repeated values)
            RegDetails.Add("Divya");
            RegDetails.Add("+918309456975");

            //Printing details
            foreach (string details in RegDetails)
            {
                Console.WriteLine(details);
            }

            Console.WriteLine();


            //Fetching using Contains Method
            if (RegDetails.Contains("+918309456975"))
            {
                Console.WriteLine($"{"+918309456975"} Number Has Been Added");
            }
            else
            {
                Console.WriteLine("Number is not yet Added");
            }










        }
    }
}
