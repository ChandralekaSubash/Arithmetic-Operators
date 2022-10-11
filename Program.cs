using System;
using Arithmetic;

namespace SampleProgram
{
    class Program
    {
        //entry point of application
        public static void Main()
        {
            Product pro=new Product();
            pro.AddProducts();
            pro.DisplayProductDetails();
            Console.ReadKey();
        }
    }
}