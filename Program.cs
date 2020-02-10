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

            TestandoEnum.StatusDaConta teste = TestandoEnum.StatusDaConta.NaoRegistrado;
            TestandoEnum.AplicarDesconto(teste);

            Order order = new Order
            {
                ID = 1080,
                Moment = DateTime.Now,
                Status = OrderStatus.PendingPayment
            };

            Console.WriteLine(order);

            string txt = OrderStatus.PendingPayment.ToString();
            Console.WriteLine(txt);

            // Enum.TryParse("Delivered", out OrderStatus os);
            OrderStatus os = (OrderStatus)Enum.Parse(typeof(OrderStatus), Console.ReadLine());
            Console.WriteLine(os);

            Console.ReadLine();
        }
    }
}
