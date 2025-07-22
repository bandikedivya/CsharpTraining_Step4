using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary

{
    //Dictionary -  we won't use term Index -> We use Key
    // We Use - System.Collection.Generic Namespace
    //Syntax:
    // Dictionary <TKey, TValue> localvariable = new Dictionary <TKey, TValue>();
    class DictionaryExample
    {
        static void Main()
        {
            Dictionary<int, string> Book = new Dictionary<int, string>();
            Book.Add(1, "Introduction");
            Book.Add(9, "Chapter 1");
            Book.Add(21, "Chapter 2");
            Book.Add(27, "Chapter 3");

            //Printing the values in Book
            //Here key plays important role, where key is used to print the values

            string Intro = Book[1];
            string Chapter1 = Book[9];
            string Chapter2 = Book[21];
            string Chapter3 = Book[27];


            foreach (KeyValuePair<int, string> item in Book)   //Prints all the keys & values
            {
                Console.WriteLine(item);
            }



            if (Book.ContainsKey(21))         //Checking if the [(Key) using ContainsKey] Method page 21 is available
            {
                Console.WriteLine("Page You are Looking For is Available ");
            }


            if (Book.ContainsValue(Book[27]))       //  //Checking if the [(Value) using ContainsValue] Method content chapter 3 is available
            {
                Console.WriteLine("Content You Are Looking For is Available");
            }



            Book.Remove(21);        //Removing or Deleting  - D


            Book.Add(11, "Chapter 1.2");            // Creating - C
            //Book.Add(15, "Chapter 1.2");

            if (Book.ContainsKey(9))
            {
                Book[9] = "Chapter 1.1";    //Updating - U
            }


            foreach (KeyValuePair<int, string> item in Book)
            {
                Console.WriteLine($"Pages No: {item.Key}");       //R
                Console.WriteLine($"Content : {item.Value}");    //R
            }











            //Console.WriteLine($"Serial No \t Content \t\t Page Number");
            //Console.WriteLine(
            //    $"1. \t {Intro}    \t\t {Book[1]}" +
            //    $"2. \t {Chapter1} \t\t {Book[9]}" +
            //    $"3. \t {Chapter2} \t\t {Book[21]}" +
            //    $"4. \t {Chapter3} \t\t {Book[27]}");


        }
    }
}
