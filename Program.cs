using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enums
{
    class Program
    {
        static void Main(string[] args)
        {
            TestandoEnum.Generos valor;

            valor = TestandoEnum.Generos.Aventura;

            Console.WriteLine(valor);
            Console.ReadLine();
        }
    }
}
