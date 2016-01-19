using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarApplication
{// https://github.com/Jusqu123/demo3Autojuttu.git

    class Program
    {
        static void Main(string[] args)
        {
            // create one car instance
            Car car = new Car();
            car.Model = "Audi";
            car.Color = "Silver";
            car.Engine = 2.0;
            car.FuzzyDices = false;
            car.Speed = 100;
            car.PrintData();




            Car nascar = new Car("Toyota");

            //    Console.WriteLine("FuzzyDices = " + nascar.FuzzyDices);
            //  Console.WriteLine("Model = " + nascar.Model);


            nascar.Speed = 200;
            nascar.Color = "Red";
            nascar.Engine = 5.0;
            nascar.FuzzyDices = true;
            nascar.PrintData();
            nascar.Accelerate(50);
            nascar.PrintData();
            Console.ReadLine();
        }
    }
}
