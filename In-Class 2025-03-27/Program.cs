//Jenna Liette


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace In_Class_2025_03_27
{
    /// <summary>
    /// In class assignment showing classes, properties, and methods for a project. Incorporating GitHub forking and cloning. Modeling pricing for shoes. 
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            Shoe myShoe = new Shoe(); // Declare and instantiate
            myShoe.Price = 49.99;  // Invoke the setter
            Console.WriteLine("Price of my new pair of shoes is " + myShoe.Price); // getter

            Console.WriteLine("Taylor Johnson");
        }
    }
}
