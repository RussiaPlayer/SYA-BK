using System;

namespace EVA
{
    class Program
    {
        static void Main(string[] args)
        {
            //Aufgabe Nr.1
            int a = 0, b = 0, c = 0; //Eingabe
            Console.WriteLine("Addition zweier Ganzzahlen");
            Console.WriteLine("");

            // Eingabe
            Console.WriteLine("Bitte geben Sie einen Wert für a ein:");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Bitte geben Sie einen Wert für b ein:");
            b = Convert.ToInt32(Console.ReadLine());
            // Verarbeitung
            c = a + b;
            //Ausgabe
            Console.WriteLine("Ergebnis: " + c);


            
            //Aufgabe Nr.2
            double m = 0, x = 0, b2 = 0, y = 0;

            Console.WriteLine("");
            Console.WriteLine("Addition zweier Ganzzahlen");
            Console.WriteLine("y: m*x + b");
            Console.WriteLine("");
            Console.WriteLine("Bitte geben Sie einen Wert für m ein:");
            strIn = Console.ReadLine();
            m = Convert.ToDouble(strIn);
            Console.WriteLine("Bitte geben Sie einen Wert für x ein:");
            strIn = Console.ReadLine();
            x = Convert.ToDouble(strIn);
            Console.WriteLine("Bitte geben Sie einen Wert für b ein:");
            strIn = Console.ReadLine();
            b2 = Convert.ToDouble(strIn);
            y = m * x + b2;
            Console.WriteLine("Ergebnis: " + y);
        }
    }
}
