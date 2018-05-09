using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HelloMethods
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string message = Message.GetMessage("fr");
            string message2 = Message.GetMessage("sp");
            string message3 = Message.GetMessage("na");
            string message4 = Message.SomeMessage();
            Console.WriteLine(message + message2 + message3 + message4);
            Console.ReadLine();
        }
    }
}
