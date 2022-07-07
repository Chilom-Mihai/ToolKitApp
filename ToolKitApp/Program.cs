using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToolKitApp
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Entry[] entries = new Entry[]
            {
                new Entry("www.facebook.com", "Facebook", "f"),
                new Entry("www.google.com", "Google", "g"),
                new Entry("www.youtube.com", "Youtube", "y")

            };

            Console.WriteLine("Simply write the jey and press enter\n");
            //Console.WriteLine("Options:\n" + "\tf - facebook\n" + "\tg - Google\n" + "\ty- Youtube\n");
            Console.WriteLine("Options:");

            foreach(Entry entry in entries)
            {
                Console.WriteLine("\t" + entry.key + " - " + entry.name);
            }
            Console.WriteLine("\nYour Option?");

            string UserInput = Console.ReadLine().ToLower();
            bool FoundEntry = false;

            foreach(Entry entry in entries)
            {
                if(UserInput == entry.key.ToLower() || UserInput == entry.name.ToLower())
                {
                    System.Diagnostics.Process.Start(@"C:\Program Files\Internet Explorer\iexplore.exe", entry.url);
                    FoundEntry = true;
                    RestartApp();
                }
            }
            if(FoundEntry == false)
            {
                Console.WriteLine("\nCan't find a valid entry. Try again?");
                Console.WriteLine("\ty - yes");
                Console.WriteLine("\nYour option? ");
                string choice = Console.ReadLine();

                if (choice == "y" || choice == "yes")
                    RestartApp();

            }

            Console.Read();

        }

        static void RestartApp()
            {
                Console.Clear();
                Main(null);
            }

       
    }
}
