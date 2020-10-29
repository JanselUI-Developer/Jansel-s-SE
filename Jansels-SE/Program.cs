using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jansels_SE
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Jansel Software Enabler V1.0";
            Console.CursorVisible = false;
            Console.WriteLine("This Program enables Desktop and downloads Software like OBS Studio and Firefox");
            string user = Environment.UserName;
            Console.WriteLine("Current User (User that executed this): " + user);
            Console.ReadKey();

        }
    }
}
