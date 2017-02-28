#region Program
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
            //Change the Color to Blue
            Console.ForegroundColor = ConsoleColor.Blue;
            //Print The Test String
            Console.WriteLine("Hello World!");
            //Make the app wait Half a second to display a different message
            Thread.Sleep(500);
            //Change The Console Color To Red
            Console.ForegroundColor = ConsoleColor.Red;
            //Make The Program Wait Half A Second To Display The Message Below
            //Print A Message To Tell The User What App This Is
            Thread.Sleep(500);
            Console.WriteLine("Welcome To A Random Number Generator Made By GameTours");
            //Say what version of the software this is and change the color to Dark Purple (Dark Magenta)
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Thread.Sleep(500);
            Console.WriteLine("This Is Version Beta 1");
            //Say what numbers this random number generator generates between.
            //Also Wait 500 millseconds (ms) To Display The Mesage
            //Change To Color To Pink (Magenta)
            Console.ForegroundColor = ConsoleColor.Magenta;
            Thread.Sleep(500);
            Console.WriteLine("This Random Number Generator Generates Numbers Between 0 to 100. I will be making differnt versions of this with different numbers");
            //Change The Console Color To White
            Console.ForegroundColor = ConsoleColor.White;
            //Advertise My Github LOL!
            //Change The Color To Green
            //Wait Another Half A Second Until Saying Another Message
            Console.ForegroundColor = ConsoleColor.Green;
            Thread.Sleep(500);
            Console.WriteLine("Visit Me On GitHub For More Cool Stuff! (https://github.com/GameTours)");
            //Tell The User If They Have Any Problems to contact me on GitHub
            //Again, wait another half a second to display the message again.
            //Change The Color To Dark Red
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Thread.Sleep(500);
            Console.WriteLine("If you find any problems feel free to contact me on YouTube (j.mp/gametoursgaming)!");
            #endregion
            #region Random/Main
            //Create A New Random Object called 'R'
            Random r = new Random();
            //Create A While Infinte Loop
            while (true)
            {
                //Anything In These Brackets Will Be Looped Forever Until the program is closed by pressing the X button at the top right or pushing ALT+F4
                //Change The Console Color To Cyan
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                //Wait 1 second or 1000 ms and then print a random number
                //Thread.Sleep(1000);
                //Print The Random Number Between 1 And 100
                Console.WriteLine(r.Next());
            }
                #endregion
               
            }
        }
    }


#endregion