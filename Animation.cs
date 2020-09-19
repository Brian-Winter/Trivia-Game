using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace TriviaGame
{
    class Animation
    {
        public void Intro()
        {
            Console.WriteLine("Created by B&B Games");
            Thread.Sleep(2000);


            Console.Clear();
            Console.WriteLine(" _____     _             ");
            Thread.Sleep(500);
            Console.WriteLine("|_   _|_ _(_)_ ____ _    ");
            Thread.Sleep(500);
            Console.WriteLine("  | | | '_| \\ V / _`|   ");
            Thread.Sleep(500);
            Console.WriteLine("  |_| |_| |_|\\_/\\__/|  ");


            Thread.Sleep(1000);
            Console.WriteLine(" Press enter to start.");
            Console.ReadKey();
            Console.Clear();

        }
        public void Winner()
        {
            Console.Clear();
            Console.WriteLine("    ");
            Console.WriteLine("    ");
            Console.WriteLine("    ");
            Console.WriteLine("    ");
            Console.WriteLine("    ");
            Console.WriteLine("/  ");
            Thread.Sleep(1000);
            Console.Clear();
            Console.WriteLine("    ");
            Console.WriteLine("    ");
            Console.WriteLine("    ");
            Console.WriteLine("    ");
            Console.WriteLine(" /");
            Console.WriteLine("/");
            Thread.Sleep(1000);
            Console.Clear();
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            
            Console.WriteLine("  /");
            Console.WriteLine(" /");
            Console.WriteLine("/");
            Thread.Sleep(1000);
            Console.Clear();
            Console.WriteLine("  `o`o` ");
            Console.WriteLine(" o`o`o`o ");
            Console.WriteLine("  `o`o` ");
            Console.WriteLine("");
            Thread.Sleep(2000);

        }
        public void BadResults()
        {
            Console.Clear();
            Console.WriteLine("    ");
            Console.WriteLine("    ");
            Console.WriteLine("    ");
            Console.WriteLine("    ");
            Console.WriteLine("    ");
            Console.WriteLine("/  ");
            Thread.Sleep(1000);
            Console.Clear();
            Console.WriteLine("    ");
            Console.WriteLine("    ");
            Console.WriteLine("    ");
            Console.WriteLine("    ");
            Console.WriteLine(" /");
            Console.WriteLine("/");
            Thread.Sleep(1000);
            Console.Clear();
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("  /");
            Console.WriteLine(" /");
            Console.WriteLine("/");
            Thread.Sleep(1000);
            Console.Clear();
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("  *");
            Console.WriteLine("");
            Console.WriteLine("");
            Thread.Sleep(1000);
            Console.Clear();
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("    *");
            Console.WriteLine("");
            Thread.Sleep(1000);
            Console.Clear();
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("     *");
            Thread.Sleep(1000);
            Console.Clear();
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Thread.Sleep(1000);
            Console.WriteLine("Bad scores don't get fireworks. Try again.");
            Thread.Sleep(2000);

        }
    }
}
