using System;
using System.Runtime.Remoting.Messaging;



namespace AjioOrderDetails
{
    class OrderHistory
    {

        public int OrderId { get; set; }
        public string ProductName { get; set; }
        public string OrderDate { get; set; }

        //public OrderHistory()
        //{
        //    OrderId = OrderId;
        //    ProductName = ProductName;
        //    OrderDate = OrderDate;
        //}

        static (int OrderId, string ProductName, string OrderDate) OrderHistoryID1()
        {
            int OrderId = 210;
            string ProductName = "Denim Jeans";
            string OrderDate = "23-10-25";
            return (OrderId, ProductName, OrderDate);
        }


        static (int OrderId, string ProductName, string OrderDate) OrderHistoryID2()
        {
            int OrderId = 136;
            string ProductName = "Micheal Kors Women Watch";
            string OrderDate = "30-01-24";
            return (OrderId, ProductName, OrderDate);
        }

        

        static void Main()
        {
            //Basic Creation of Tuple  -- Type - 1 
            Tuple<int, string, string> OrderDetails = Tuple.Create(203, "Jumpsuit", "23-05-24");

            //Priting All Items, we use Item1, Item2 .....in Tuples

            Console.WriteLine("***************Ajio Order History**************");
            Console.WriteLine();
            Console.WriteLine("****************** 1st Order *****************");

            Console.WriteLine($"OrderID: {OrderDetails.Item1}");
            Console.WriteLine($"Product Name: {OrderDetails.Item2}");
            Console.WriteLine($"Order Date: {OrderDetails.Item3}");
            Console.WriteLine();



            //Value Type Tuple -- Type - 2 
            //Without mentioning the Tuple while creating

            //(int, string, string) OrderHistory = (210, "Denim Jeans", "23-10-25");
            Console.WriteLine("****************** 2nd Order *****************");
            (int Id, string ProductName, string OrderDate) OrderHistory1 = OrderHistoryID1(); //Here OrderHistory is the method(with return type)
            Console.WriteLine($"OrderID: {OrderHistory1.Id}");
            Console.WriteLine($"Product Name: {OrderHistory1.ProductName}");
            Console.WriteLine($"Order Date: {OrderHistory1.OrderDate}");


            Console.WriteLine();
            Console.WriteLine("****************** 3rd Order *****************");
            (int OrderId, string ProductName, string OrderDate) OrderHistory2 = OrderHistory.OrderHistoryID2(); //[OrderHistory is the class name and OrderHistoryID2 is the method(with return type) name]
            Console.WriteLine($"OrderID: {OrderHistory2.OrderId}");
            Console.WriteLine($"Product Name: {OrderHistory2.ProductName}");
            Console.WriteLine($"Order Date: {OrderHistory2.OrderDate}");

            Console.WriteLine();
            //Destructure The Tuple (by using var keyword and without mentioning the datatypes while the create tuple)

            var (OrderId, ProductName, OrderDate) = (143, "Men's Denim Shirt", "10-05-25");
            Console.WriteLine("**************** 4th Order ***********************");
            Console.WriteLine($"OrderID: {OrderId}");
            Console.WriteLine($"Product Name: {ProductName}");
            Console.WriteLine($"Order Date: {OrderDate}");



        


        }
    }


}
