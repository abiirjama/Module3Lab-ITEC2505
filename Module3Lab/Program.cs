using System;
namespace TacoBurritoLab
{

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the taco & burrito decision maker!");
            //hunger level & get the value 
            Console.WriteLine("how hungry you are(1-10)?");
            int hungerLevel = int.Parse(Console.ReadLine());
            if (hungerLevel >= 8)
            {
                Console.WriteLine("your're super hungry! Order both tacos & burritos.");

            }
            else if (hungerLevel >= 5)
            {
                Console.WriteLine("you're moderately hungry. go for tacos!");
            }
            else
            {
                Console.WriteLine("you're not that hungry.opt for a burrito.");

            }//end if else 
             //ternary operator- conditional statement to  make final recommendation
            string recommendation = (hungerLevel >= 5) ? "Tacos" : "Burrito";
            Console.WriteLine($"I recommend :{recommendation}");
            //switch statement 
            switch (hungerLevel)
            {
                case 10:
                    Console.WriteLine("you're a taco and burrito champion!");
                    break;
                case 9:
                case 8:
                    Console.WriteLine("taco time!");
                    break;
                case 5:
                    Console.WriteLine("burrito it is!");
                    break;
                default:
                    Console.WriteLine("maybe just grab a snack");
                    break;
                        


            }
        }//end main method
    }//end class
}//end namespace