using CarClass;
using Microsoft.VisualBasic;
using System;
using System.Runtime.ConstrainedExecution;
using System.Runtime.Intrinsics.X86;
namespace Carsncapsul
{
    class Cars
    {

        public static void Main (string[] args )
        {
          Car Car1=new Car("Audi",2012,"Green"); //instance for the Car1
            Console.WriteLine($"Car Name:{Car1.Name} Car Model:{Car1.Model} Car Color:{Car1.Color} Car Door Number:{Car1.Dournumber(1)}");//Information Car1 and we use ncapsulation car door
            Car Car2 = new Car("Audi", 2018, "Red"); ////instance for the Car2
            Console.WriteLine($"Car Name:{Car2.Name} Car Model:{Car2.Model} Car Color:{Car2.Color} Car Door Number:{Car2.Dournumber(2)}");//Information Car2 and we use ncapsulation car door
            Car Car3 = new Car("Mercedes", 2024, "White");//instance for the Car3
            Console.WriteLine($"Car Name:{Car3.Name} Car Model:{Car3.Model} Car Color:{Car3.Color} Car Door Number:{Car3.Dournumber(4)}"); //Information Car3 and we use ncapsulation car door
            Car Car4 = new Car("BMW", 2012, "Yellow");//instance for the Car4
            Console.WriteLine($"Car Name:{Car3.Name} Car Model:{Car3.Model} Car Color:{Car3.Color} Car Door Number:{Car3.DoorNumber}");// Information Car4 and we use constructor for door
        }
    }

}