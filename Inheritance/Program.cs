using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO Be sure to follow best practice when creating your classes


            /*Create an object of your Bird class
             *  give values to your members using the object of your Bird class
             *  
             * Creatively display the class member values 
             */

            Bird redBird = new Bird();
            redBird.Name = "Cardnial";
            redBird.Movement = "Flight";
            redBird.Legs = 2;
            redBird.LayEggs = false;
            redBird.FeatherColor = "Red";
            redBird.Chirp = "Tweet Tweet";
            redBird.Peck = "Peck Peck";
            redBird.isPerching = true;

            Console.WriteLine("************************************************************");
            Console.WriteLine($"Name: {redBird.Name}");
            Console.WriteLine($"Movement: {redBird.Movement}");
            Console.WriteLine($"Legs: {redBird.Legs}");
            Console.WriteLine($"Does This bird have eggs: {redBird.LayEggs}");
            Console.WriteLine($"Bird Color: {redBird.FeatherColor}");
            Console.WriteLine($"Bird's Song: {redBird.Chirp}");
            Console.WriteLine($"Birds's Peck:{redBird.Peck}");
            Console.WriteLine($"Is Bird Perching:{redBird.isPerching}");
            Console.WriteLine("************************************************************");


            /*Create an object of your Reptile class
             *  give values to your members using the object of your Bird class
             *  
             * Creatively display the class member values 
             */
            Reptile snake = new Reptile();

            snake.HaveFangs = true;
            snake.Name = "Mamba";
            snake.Talk = "Hiss Hiss";
            snake.LayEggs = true;
            snake.SkinColor = "black";
            snake.Movement = "Slither";
            snake.Legs = 0;
            snake.DetachedTail = false;

            Console.WriteLine("************************************************************");
            Console.WriteLine($"Snake have fangs: {snake.HaveFangs}");
            Console.WriteLine($"Name: {snake.Name}");
            Console.WriteLine($"Snake Talk: {snake.Talk}");
            Console.WriteLine($"Does the Snake have any eggs: {snake.LayEggs}");
            Console.WriteLine($"Snake Skin Color: {snake.SkinColor}");
            Console.WriteLine($"Snake's Movement: {snake.Movement}");
            Console.WriteLine($"Legs: {snake.Legs}");
            Console.WriteLine($"Detached Tail: {snake.DetachedTail}");
            Console.WriteLine("************************************************************");



        }
    }
}
