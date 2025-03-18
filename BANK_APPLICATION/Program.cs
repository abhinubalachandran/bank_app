using System;
using System.Threading;

namespace Machinetest
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine();
            

            string[] Messages = { @" _ __    _,  _ __  __  , ____ __   ,___    __,__   ___, ____________ _ _ _ 
( /  )  / | ( /  )( /,/ ( /( /  ) /   /   (  ( /  /(   (  /  (  /   ( / ) )
 /--<  /--|  /  /  /<    /  /  / /  __     `. (__/  `.   /     /--   / / / 
/___/_/   |_/  (_ /  \__/_ /  (_(___/    (___) _/_(___)_/    (/____// / (_ 
                                              //                           
                                             (/                            
" };

            Console.WriteLine(Messages[0]);
            Thread.Sleep(3000);
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            Customers cust = new Customers();
            cust.operations();
            Console.ReadKey();
        }
    }
}
