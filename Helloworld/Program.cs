using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Helloworld
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Type 'exit' to quit program");
            do // le programme gère l'affichage des messages
            {
                // Instanciation de la classe Message
                Message message = new Message();
                WriteLine(message.GetHelloMessage() + Environment.UserName);
            } while (ReadLine() != "exit");
        }
    }
}

