using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arithmetic
{
    public class Product
    {
        //properties
        int ProductID;
        string ProductName;
        int MRP_Price;
        private float GST= 13.2f;
        float Discount;
        float AfterDiscount;
        int Count;
        int Total;
        float FinalTotal;
        //methods
        public void  AddProducts()
        {
            Console.WriteLine("Enter Product ID:");
            ProductID=Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Product Name:");
            ProductName = Console.ReadLine();

            Console.WriteLine("Enter MRP Price:");
            MRP_Price = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Discount:");
            Discount = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine($"How many products do you want to Buy:");
            Count = Convert.ToInt32(Console.ReadLine());

            Total = MRP_Price * Count;
            AfterDiscount = Total - (Total * Discount / 100);
            FinalTotal = (AfterDiscount * GST) / 100;
            Console.WriteLine($"You have to pay amount Rs: {FinalTotal} ");
            Console.WriteLine("--------------------------------");
            Console.WriteLine("Thank You For Shopping with US!");
        }
        public void DisplayProductDetails()
        {
            
          // Console.WriteLine( $"{Total} {AfterDiscount} {FinalTotal}");
        }
    }
}
