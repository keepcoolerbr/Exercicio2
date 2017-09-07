using Stream;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite sua stream: ");
            StreamString obj = new StreamString(Console.ReadLine());

            char c = obj.firstChar(obj);

            if (c != ' ')
            {
                Console.WriteLine("Caractere encontrado: " + c);
            }
            else
            {
                Console.WriteLine("Nenhum caractere encontrado");
            }

            Console.ReadKey();
        }
    }
}
