using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicroSoftEmployees
{
    class Array
    {
        static void Main()
        {

            // Array - Does not require specific namespace 
            // 1.Type - Safety [We create array with same datatype (e.g.,integer, string)


            //General Type  - 1  - By mentioning size of array, mentioning new keyword and adding each element by using its index value
            string[] employeenames = new string[5];   //This array is storing string datatypes values
            employeenames[0] = "Conrad";
            employeenames[1] = "Isabel";
            employeenames[2] = "Jermiah";
            employeenames[3] = "Steven";
            employeenames[4] = "Taylor";

            //Type - 2  - Without mentioning the size od array and adding directly list of items in the braces
            // string[] employeenames1 = new string[] { "Conrad", "Isabel", "Jermiah", "Steven", "Taylor" };
            

            //Type - 3 - Without mentioning the size of array and not mentioning the new keyword
            //string[] employeenames = { "Conrad", "Isabel", "Jermiah", "Steven", "Taylor" };


            // 2. Array Fixed Size
            //General Type  - 1  - By mentioning size of array, mentioning new keyword and adding each element by using its index value
            string[] employeename = new string[5];   //This array is storing string datatypes values
            employeename[0] = "Conrad";    //Here 0th index stores "Conrad" where conrad is the value
            employeename[1] = "Isabel";
            employeename[2] = "Jermiah";
            employeename[3] = "Steven";
            employeename[4] = "Taylor";


            // 3.  Boxing  [As List allows only single datatype, we directly assign the index value to the new local variable
            //              Eg.. string TeamLead is assigned to employeename[0] which is of string type]
            // string TeamLead = "Conrad";
            string TeamLead = employeenames[0];
            Console.WriteLine($"{employeename[0]}: Before Position Is TASE and After Promoted To TeamLead :{TeamLead}");

            // 4. Looping

            //Printing all the employeenames

            foreach (var emplyees in employeenames)
            {
                //for (int employees = 0; employees < emplyees.Length - 1; employees++)
                //{
                //    //int employeeid = 1001;
                //    //int addingemployeeid = employeeid++;
                //    Console.WriteLine($"Employee ID is: {emplyees}");
                //}

                //Console.WriteLine($"Miscrosoft Employee List: {emplyees}");

                Console.WriteLine($"Employees in Microsoft: {emplyees}");
            }

            //5. It Doesn't allow multidatatypes (int[] this allows only interger, but not bool or string etc)

            //string[] employee = new string[10];
            //employee[5] = 10;
            //employee[6] = false;


        }
    }
}


//using System;


//namespace ArraysCode
//{
//    //Type Safety

//    class ArrayExample
//    {
//        static void Main()
//        {

//            // 1. TypesSafety
//            int[] arr = new int[2];  // Array with Int
//            arr[0] = 10;  //as the Integer
//            arr[1] = 20;


//            //2. Array Fixed Size.
//            int[] arr1 = new int[2];  // Array with Int
//            arr[0] = 10;
//            arr[1] = 20;
//            //arr[2] = 30;  //Index Out of Range Exception


//            //No Boxing
//            int Third = arr[0];  //10


//            //4.Multidata Types not possible
//            int[] arr2 = new int[2];
//            //arr2[0] = false;
//            //arr2[1] = "Hello";


//            //5.Looping
//            int[] arr3 = new int[4];
//            arr3[0] = 10;
//            arr3[1] = 20;
//            arr3[2] = 30;
//            arr3[3] = 40;

//            foreach (int x in arr3)
//            {
//                Console.WriteLine(x);
//            }

//        }
//    }

//}







//using System;
//using System.Linq;
//class Arrays
//{
//    static void Main()
//    {
//        //int[] noofItems = new int[2];
//        //noofItems[0] = 100;
//        ///*noofItems[1] = 200;
//        //noofItems[2] = 300;
//        //noofItems[3] = 400;
//        //noofItems[4] = 500;*/

//        //Console.WriteLine($"0th Index Value in Array is : {noofItems[0]}");
//        //Console.WriteLine($"1st Index Value of Array is : {noofItems[1]} ");

//        ////without mentioning the size like int[2]
//        //int[] noofItems1 = new int[] { 10, 20 };
//        //noofItems1[0] = 15; //replacing the value of 10 with 15
//        //Console.WriteLine(noofItems1[0]);



//        ////without new int[], assigning values in array
//        //int[] noofItems2 = { 1, 2, 3, 4, 5 };
//        //Console.WriteLine(noofItems2[4]);

//        //string[] namesList = { "Divya", "Kavya", "Vignesh" };
//        //Console.WriteLine($"2nd Index Value : {namesList[2]}");
//        //Console.WriteLine($"1st Index Value : {namesList[1]}");
//        //Console.WriteLine($"0th Index Value : {namesList[0]}");
//        //Console.WriteLine($"List Names: {namesList}");






//        ////Loop
//        ///*Foreach loop, should use "in" keyword 
//        // foreach (datatype int/var variableName in CollectionName)
//        //{
//        //    //code to execute the foreach loop
//        //}
//        // */

//        //int[] currency = { 20, 100, 50 };
//        //foreach (int currencyNotes in currency)
//        //{
//        //    Console.WriteLine($"Printing Every Currency Notes: {currencyNotes}");
//        //}

//        ////Adding 5 to the above currency

//        //foreach (int currencyNotes in currency)
//        //{
//        //    int addingCoin = 10;
//        //    int updatedCurrency = currencyNotes + addingCoin;
//        //    Console.WriteLine($"Printing Updated Currency Note: {updatedCurrency}");
//        //}

//        ////For string

//        //string[] nameOfEmployee = { "A", "B", "C" };
//        //foreach (string employeeNames in nameOfEmployee)
//        //{
//        //    Console.WriteLine($"Employee Name in the List: {employeeNames}");
//        //}

//        ////adding string names

//        //nameOfEmployee[0] = "Arun";
//        //nameOfEmployee[1] = "Bandike";
//        //nameOfEmployee[2] = "Chandu";
//        //Console.WriteLine(nameOfEmployee[0]);
//        //Console.WriteLine(nameOfEmployee[1]);
//        //Console.WriteLine(nameOfEmployee[2]);

//        //foreach (string employeenames in nameofemployee)
//        //{
//        //    string updatingname = "a";
//        //    string addingnames = nameofemployee + updatingname;
//        //    console.writeline($"employee names in the list: {addingnames}");
//        //}

//        string[] employeeDetails = { "John", "Robert", "Chandra", "Kumar" };
//        Console.WriteLine($"3rd Index Value: {employeeDetails[3]}");

//        if (employeeDetails[1] == employeeDetails[2])
//        {
//            Console.WriteLine($"{employeeDetails[1]} and {employeeDetails[2]} are  same");
//        }
//        else
//        {
//            Console.WriteLine($"{employeeDetails[1]} and {employeeDetails[2]} are not same");
//        }
//        //Check weather Second and Third employee Equals or not from the Array

//        foreach (string employeeName in employeeDetails)
//        {

//            if (employeeName.StartsWith("J"))
//            {
//                Console.WriteLine($"Name Starts woth \"J\" : {employeeName}");
//            }
//        }


//    }
//}
