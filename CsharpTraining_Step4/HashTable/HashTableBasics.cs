using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashTable
{
    class HashTableBasics
    {
        // Hash Table -- Uses System.Collections; namespace
        // Hash Table -- Should have unique key, it doesn't allow duplicate key
        //Syntax: 
        //HashTable hashtable = new HashTable();
        //HashTable is Key-Value Pair - Non-Generic type.

        static void Main()
        {
            Hashtable Stud1Details = new Hashtable();
            Stud1Details.Add("Name", "Conrad");
            Stud1Details.Add("Email Id", "condrad@gmail.com");
            Stud1Details.Add("Mobile Number", "+919876543210");
            Stud1Details.Add("Dept", "CSE");
            Stud1Details.Add("Made Project", true);
            Stud1Details.Add("Roll No", 101);


            //Stud1Details.Add("Name", "Jermiah");//Throws runtime error as the key names "Name" is already assigned to the value "Conrad"


            foreach (DictionaryEntry stud1details in Stud1Details)
            {
                Console.WriteLine($"{stud1details.Key} : {stud1details.Value}");

            }



            // Unboxing [As Hashtable is non generic which accepts multiple datatypes]
            string StudMblNum = (string)Stud1Details["Mobile Number"];
            Console.WriteLine($"Stud Mobile Number: {StudMblNum}");

            string StudDept = (string)Stud1Details["Dept"];
            Console.WriteLine($"Stud Department: {StudDept}");

            int StudRollNo = (int)Stud1Details["Roll No"];
            Console.WriteLine($"Stud Roll No: {StudRollNo}");


            // Updating
            // Boxing

            Stud1Details["Name"] = "Conrad Fisher";
            Console.WriteLine(Stud1Details["Name"]);

            //foreach (DictionaryEntry stud1details in Stud1Details)
            //{
            //    Console.WriteLine($"{stud1details.Key}: {stud1details.Value}");
            //}



            // Deleting or Removing 
            Stud1Details.Remove("Made Project");

            foreach (DictionaryEntry stud1details in Stud1Details)
            {
                Console.WriteLine($"{stud1details.Key}: {stud1details.Value}");
            }


            // Adding 

            Stud1Details.Add("Gender", "Male");

            foreach (DictionaryEntry stud1details in Stud1Details)
            {
                Console.WriteLine($"{stud1details.Key}: {stud1details.Value}");
            }


            //Fetching By Using Contains.Key()
            if(Stud1Details.ContainsKey("Dept"))
            {
                Console.WriteLine("Department is Available");

            }
            else
            {
                Console.WriteLine("Department is Not Available");
            }

            //Fetching By Using Contains.Value()
            if(Stud1Details.ContainsValue(101))
            {
                Console.WriteLine("Student Has Attented Class");

            }
            else
            {
                Console.WriteLine($"Student: {StudRollNo} From {StudDept} Has Not Attended Class");
            }






        }
    }
}
