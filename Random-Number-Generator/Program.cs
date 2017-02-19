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
            #region Starup
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
            //Say what version of the software this is and change the color
            Console.ForegroundColor = ConsoleColor.Cyan;
            Thread.Sleep(500);
            Console.WriteLine("This Is Version 0.02 Alpha");
            //Say what numbers this random number generator generates between.
            //Also Wait 500 millseconds (ms) To Display The Mesage
            //Change To Color To Yellow
            Console.ForegroundColor = ConsoleColor.Yellow;
            Thread.Sleep(500);
            Console.WriteLine("This Random Number Generator Generates Numbers Between 0 to 100. I will be making differnt versions of this with different numbers");
            //Change The Console Color To Green
            Console.ForegroundColor = ConsoleColor.Green;
            //Advertise My Github LOL!
            //Change The Color To Purple (Magenta)
            //Wait Another Half A Second Until Saying Another Message
            Console.ForegroundColor = ConsoleColor.Magenta;
            Thread.Sleep(500);
            Console.WriteLine("Visit Me On GitHub For More Cool Stuff! (https://github.com/GameTours)");
            //Tell The User If They Have Any Problems to contact me on GitHub
            //Again, wait another half a second to display the message again.
            //Change The Color To Dark Red
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Thread.Sleep(500);
            Console.WriteLine("If you find any problems feel free to contact me on YouTube (j.mp/gametoursgaming)!");
            #endregion
            #region cleaningup
            //Wait 5 Seconds And Then Change The Color To The Standard White
            Thread.Sleep(5000);
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("TEST");
            //Then Wait 2 Seconds And Close The Console Window
            Thread.Sleep(2000);
            //Thank The User For Using This App
            Console.WriteLine("Thank You Very Much For Using This Piece Of Software! -GameTours");
            //Close The Command Window
            #endregion
        }
    }
}
