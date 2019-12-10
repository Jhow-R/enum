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
        
        enum Acoes { Falar = 0, Cantar = 1, Gritar = 2, Sussurrar = 3, Calar = 4 }
    }
}
