using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace BookingSystem
{
    class RoomBooking
    {

        static void Main()
        {
            Dictionary<int, string> FiveStartHotel = new Dictionary<int, string>();
            FiveStartHotel.Add(101, "Room 101");
            FiveStartHotel.Add(201, "Room 201");
            FiveStartHotel.Add(301, "Room 301");
            FiveStartHotel.Add(401, "Room 401");

            Dictionary<string, bool> checkroom = new Dictionary<string, bool>();
            checkroom.Add("Room 101", true);
            checkroom.Add("Room 201", false);
            checkroom.Add("Room 301", true);
            checkroom.Add("Room 401", false);
            





            if (FiveStartHotel.ContainsKey(201))
            {
                Console.WriteLine($"{FiveStartHotel[201]} is Available");
            }


            //Console.WriteLine("***********************Welcome To FiveStarHotel*******************");
            //Console.WriteLine("Please Enter Your Name ");
            //string name = Console.ReadLine();
            //Console.WriteLine("Please Enter Your Mobile Number");
            //long phnnum = Convert.ToInt64(Console.ReadLine());
            Console.WriteLine("Check If Room Is Available [1. Room 101 \t 2. Room 201 \t 3.Room 301 \t 4. Room 401");
            string choice = Console.ReadLine();

            if (checkroom.ContainsKey(choice))
            {
                Console.WriteLine("Room is Available");
            }
            else
            {
                Console.WriteLine("Room is Not Avaliable");
            }
        }
    }
}
