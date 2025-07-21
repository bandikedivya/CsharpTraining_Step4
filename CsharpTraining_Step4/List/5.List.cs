using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListNamespace
{

    //List -- Should use System.Collection.Generic namespace
    //Syntax For List
    //List<T> localVariable = new List<T>();
    class ListExample
    {
        static void Main()
        {

            // 1. Type - Safety (List allows multiple datatypes) 

            List<string> employeeNameList = new List<string>();
            employeeNameList.Add("Conrad");
            employeeNameList.Add("Isbel");
            employeeNameList.Add("Jermiad");
            employeeNameList.Add("Laural");
            employeeNameList.Add("Steven");

            foreach (Object name in employeeNameList)
            {
                Console.WriteLine(name);
            }

            // 2. Dynamic Size
            //Allows duplicate (repeated) values
            List<int> employeeId = new List<int>();
            employeeId.Add(2576260);
            employeeId.Add(2576250);
            employeeId.Add(2576760);
            employeeId.Add(2569850);
            employeeId.Add(2797655);


            foreach (Object id in employeeId)
            {
                Console.WriteLine(id);
            }

            // 3.List Doesn't Allow Mutliple DataTypes
            //employeeId.Add("Taylor");
            //employeeId.Add(false);




            Console.WriteLine("***********Employee List**************");
            Console.WriteLine("ID\tEmployee Name");
            for (int i =0; i< employeeId.Count; i++)
            {
                Console.WriteLine(employeeId[i] +"\t" + employeeNameList[i]);
            }

          

           

            //Console.WriteLine($"Employee Name: {employeeNameList} and Employee Id: {employeeId}");

            // 4.  Boxing  [As List allows only single datatype, we directly assign the index value to the new local variable
            // Eg.. CEO is of string datatype which is assigned to employeeNameList[3] which is "Laural" which is of string datatype]
            string CEO = employeeNameList[3];
            Console.WriteLine($"The CEO of Company is: {CEO}");


            // var paired = employeeNameList.Zip(employeeId, (name, id) => (Name: name, Id: id));
            //5. Looping
            var NameId = employeeNameList.Zip(employeeId, (employeename, employeeid) => (Name: employeename, Id: employeeid));


            foreach (var emp in NameId)
            {

                Console.WriteLine($"Employee Name: {emp.Name}, Employee ID: {emp.Id}");
            }


            //foreach(string employeename in employeeNameList)
            //{
            //    string somename = $"Some Name: {employeename}";
            //    Console.WriteLine(employeename);
            //}
        }
    }
}
