using System;

class Program
{
    static void Main()
    {

       
         //Dungeon
         string playerName;
         string rawNumberInput;
         int luckyNumber;

         Console.WriteLine("Enter your name: ");
         playerName = Console.ReadLine();

         Console.WriteLine("Hello " + playerName + "welcome to the dungeon!");
         Console.WriteLine("Enter your lucky number (number between1-10): ");
         rawNumberInput = Console.ReadLine();

         luckyNumber = int.Parse(rawNumberInput);

         if (luckyNumber >= 7)
         {
             Console.WriteLine("The door opens safely. You win!");
         }
         else
         {
             Console.WriteLine("A trapdoor opens! Game Over");
         }

     
    }
}