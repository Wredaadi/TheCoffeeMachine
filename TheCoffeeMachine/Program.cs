using System;

namespace TheCoffeeMachine
{
    class Program
    {
        static void Main(string[] args)
        {
            
            CoffeePowder coffe = new CoffeePowder(1000);
            WaterMilk milk = new WaterMilk(1000);
            WaterGalon water = new WaterGalon(1000);
            CoffeeMachine yummyCoffe = new CoffeeMachine(coffe, water, milk);

            Console.WriteLine("check " + yummyCoffe.checkAvailabili());
            String result = yummyCoffe.makeCappucino();
            Console.WriteLine("result " +result);

            //1st cup coffe
            Console.WriteLine("check" + yummyCoffe.checkAvailabili());
            result = yummyCoffe.makeEsspresso();
            Console.WriteLine("result"+result);

            //2nd cup coffe
            Console.WriteLine("check" + yummyCoffe.checkAvailabili());
            result = yummyCoffe.makeEsspresso();
            Console.WriteLine("result"+result);

            //3rd cup coffe
            Console.WriteLine("check" + yummyCoffe.checkAvailabili());
            result = yummyCoffe.makeEsspresso();
            Console.WriteLine("result"+result);

            //4th cup coffe
            Console.WriteLine("check" + yummyCoffe.checkAvailabili());
            result = yummyCoffe.makeEsspresso();
            Console.WriteLine("result"+result);

            //5th cup coffe
            Console.WriteLine("check" + yummyCoffe.checkAvailabili());
            result = yummyCoffe.makeEsspresso();
            Console.WriteLine("result"+result);

            //6th cup coffe
            Console.WriteLine("check" + yummyCoffe.checkAvailabili());
            result = yummyCoffe.makeEsspresso();
            Console.WriteLine("result"+result);

            Console.WriteLine("check" + yummyCoffe.checkAvailabili());
        }
    }
}
