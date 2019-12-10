using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enums
{
    class TestandoEnum
    {
        public enum Generos
        {
            Aventura,
            Romance,
            Suspense,
            Terror
        }

        Generos valor = Generos.Aventura;

        public enum StatusDaConta
        {
            NaoRegistrado = 1,
            ClienteComum = 2,
            ClienteEspecial = 3,
            ClienteVIP = 4
        }

        public static void AplicarDesconto(StatusDaConta statusDaConta)
        {
            switch (statusDaConta)
            {
                case StatusDaConta.NaoRegistrado:
                    Console.WriteLine(StatusDaConta.NaoRegistrado.GetHashCode());
                    break;
                case StatusDaConta.ClienteComum:
                    Console.WriteLine("");
                    break;
                case StatusDaConta.ClienteEspecial:
                    Console.WriteLine("");
                    break;
                case StatusDaConta.ClienteVIP:
                    Console.WriteLine("");
                    break;
            }
        }
    }
}
