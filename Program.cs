using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sem03_Ejercicio_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int edadNum, adivinanzas;
            string edadText;
            float monto;

            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.ForegroundColor = ConsoleColor.White;
            Console.Clear();
            Console.WriteLine("\t\t\t-Campaña de premios-\n");
            Console.Write("Ingrese su edad: ");
            edadNum = int.Parse(Console.ReadLine());

            if (edadNum > 0)
            {
                if (edadNum < 18)
                    edadText = "menor";
                else
                    edadText = "mayor";
            }
            else
            {
                Console.WriteLine("¡Error! Debe ingresar una edad válida (mayor a cero)");
                Console.ReadKey();
                return;
            }

            Console.Write("¿Cuántas adivinanzas acertó?: ");
            adivinanzas = int.Parse(Console.ReadLine());
            monto = 0;
            switch (edadText)
            {
                case "menor":
                    {
                        if (adivinanzas > 0 && adivinanzas < 3)
                            monto = 50;
                        if (adivinanzas >= 3)
                            monto = 80;
                    }
                    break;
                case "mayor":
                    {
                        if (adivinanzas > 0 && adivinanzas < 3)
                            monto = 30;
                        if (adivinanzas >= 3)
                            monto = 50;
                    }
                    break;
            }
            monto = (edadNum * 5) + (adivinanzas * 2) + monto;

            Console.WriteLine("El ganador recibe de premio, por acertar {0} adivinanzas, un monto de: S/. "+monto.ToString("0.00"), adivinanzas);
            Console.ReadKey();
        }
    }
}
