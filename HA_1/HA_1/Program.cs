using System;

namespace HA_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Aufgabe Nr.1
            int kante = 10;
            int oberfläche = 6 * kante * kante;
            int volum = kante * kante * kante;

            Console.WriteLine("Berechnung am Würfel");
            Console.WriteLine("Kantenlänge: " + kante + " cm");
            Console.WriteLine("Oberfläche : " + oberfläche);
            Console.WriteLine("Volumen    : " + volum);

            Console.WriteLine("");

            //Aufgabe Nr.2
            int radius = 10;
            float pi = 3.14159265359f;
            int durchmesser = 2 * radius;
            float umfang = 2 * pi * radius;
            float fläche = pi * radius * radius;

            Console.WriteLine("Berechnung am Kreis");
            Console.WriteLine("Radius     : " + radius + " cm");
            Console.WriteLine("Durchmesser: " + durchmesser);
            Console.WriteLine("Umfang     : " + umfang);
            Console.WriteLine("Fläche     : " + fläche);

            Console.WriteLine("");

            //Aufgabe Nr.3
            long c = 100000;
            long d = c * c / c;

            Console.WriteLine(d);

            Console.WriteLine("");

            //Aufgabe Nr.4
            float a = 2;
            float b = 5;
            float answer = a + (b / a - a / b) * b;

            Console.WriteLine(answer);
        }
    }
}
