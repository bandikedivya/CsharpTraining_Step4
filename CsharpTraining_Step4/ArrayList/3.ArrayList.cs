using System;
using System.Collections;


namespace SVCET
{
    class CSEStudentProject
    {
        //ArrayList - needs System.Collections namespace
        // ArrayList has Dynamic Sizing (which doesn't have specific array size)
        // ArrayList is Non - Generic DataTypes
        // ArrayList --use Boxing and Unboxing
        // Boxing   --> Value to Object
        // Unboxing --> Object to Value

        // In ArrayList Every value is stored as Object
        static void Main()
        {

            // 1. ArrayList - Is Not Type Safety (Creating ArrayList with Different DataTypes)
            // 2. ArrayList Dynamic Size. (ArrayList has Dynamic Size)
            // 3. ArrayList - Allows Mutliple DataTypes Possible
            Console.WriteLine("*******************CSE Policy Management System********************");
            ArrayList studprojectlist = new ArrayList();

            studprojectlist.Add("Divya");      //Every value is stored as a object 
            studprojectlist.Add(187810512);
            studprojectlist.Add("Swapna");
            studprojectlist.Add(187810511);
            studprojectlist.Add("Usha Arpitha");
            studprojectlist.Add(187810510);
            studprojectlist.Add("Narmada");
            studprojectlist.Add(187810509);



            //Printing All Student Names
            // 4. Looping

            foreach (object student in studprojectlist)
            {
                int somevalue = (int) student;
                Console.WriteLine(student);
            }


            // 5. Boxing and UnBoxing [As the ArrayList allows different datatypes we mention the datatype of the value to assign](Depending on Situation)
            //Object to Expected datatype

            string studname = (string)studprojectlist[0];       //Unboxing  -- Should mention the datatype before the arraylist
            Console.WriteLine($"Project Lead: {studname}");

            int studrollno = (int)studprojectlist[1];          //Unboxing  -- Should mention the datatype before the arraylist
            Console.WriteLine($"Project Lead Roll Number: {studname}");



            //var a = 10;
            //a = "Some string"; //Throws compile time error as a stored int type before and now trying to store string value

            //object a = 10;
            //a = "Some string"; //Doesn't throw error, as object allows multiple data types


        }
    }
}