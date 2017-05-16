﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using poo.Clases;

namespace poo
{
    class Program
    {
        public struct Punto
        {
            private int x;
            private int y;
            public int X { get { return x; } }
            public int Y { get { return y; } }
            public Punto(int x, int y) {
                this.x = x;
                this.y = y;
            }
            public void desplaza(int enX, int enY)
            {
                x = x + enX;
                x = x + enY;
            }
        }

        static void Main(string[] args)
        {
            Cuenta cuenta = new Cuenta(new Persona("Felix", "123456"), 100);
            Console.WriteLine("Saldo de la cuenta: "+ cuenta.Saldo);
            Console.WriteLine("Saldo en dólares: "+ cuenta.SaldoDolar);
            estructura();
            Console.Read();
        }

        static void estructura()
        {
            Punto punto; // No está inicializada
            punto = new Punto(2, 3);
            Console.WriteLine("Punto X: " + punto.X); // 2

            Punto punto2 = new Punto(8, 7);
            punto = punto2;
            Console.WriteLine("Punto X(igualacion con el punto2): " + punto.X); // 8
        }
    }
}
