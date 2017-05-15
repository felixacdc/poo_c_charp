using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using poo.Clases;

namespace poo
{
    class Program
    {
        static void Main(string[] args)
        {
            Cuenta cuenta = new Cuenta(new Persona("Felix", "123456"), 100);
            Console.WriteLine("Saldo de la cuenta: "+ cuenta.Saldo);
            Console.WriteLine("Saldo en dólares: "+ cuenta.SaldoDolar);
            Console.Read();
        }
    }
}
