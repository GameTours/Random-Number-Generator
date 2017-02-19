//The absolute begining of the Random Number Generator

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

/// <summary>
/// The Name Space Of The Random Number Generator
/// </summary>
namespace Random_Number_Generator

    //The Class Called Program
{
    class Program
    {
        static void Main(string[] args)
        {
            //Change the Color to Gold
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            //Print The Test String
            Console.WriteLine("Hello World!");
            //Make the app wait Half a second to display a different message
            Thread.Sleep(500);
            //Change The Console Color To Blue
            Console.ForegroundColor = ConsoleColor.Blue;
            //Make The Program Wait Half A Second To Display The Message Below
            //Print A Message To Tell The User What App This Is
            Thread.Sleep(500);
            Console.WriteLine("Welcome To A Random Number Generator Made By GameTours");
            //Change The Console Color To Green
            Console.ForegroundColor = ConsoleColor.Green;
            //Advertise My Github LOL!
            //Wait Another Half A Second Until Saying Another Message
            Thread.Sleep(500);
            Console.WriteLine("Visit Me On GitHub For More Cool Stuff! (https://github.com/GameTours)");
            //Tell The User If They Have Any Problems to contact me on GitHub
            //Again, wait another half a second to display the message again.
            Thread.Sleep(500);
            Console.WriteLine("If you find any problems feel free to contact me on YouTube (j.mp/gametoursgaming)!");
        }
    }
}
