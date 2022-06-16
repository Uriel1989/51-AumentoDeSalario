using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace AumentoDeSalario
{
    class Program
    {
        static void Main(string[] args)
        {
            double PorcentajeASumar = 0;

            double salarioAumentado= 0;
            Console.WriteLine("Bienvenido, aqui se calculará el aumento de su salario.");

            Console.WriteLine("Ingrese el monto al cual desea que se le aplique el aumento:");
            double salarioInicial = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Ingrese el porcentaje de aumento que se debe aplicar:");
            double PorcentajeDeAumento = Convert.ToDouble(Console.ReadLine());

            PorcentajeDeAumento = PorcentajeDeAumento / 100;

            PorcentajeASumar = salarioInicial * PorcentajeDeAumento;

            salarioAumentado = salarioInicial + PorcentajeASumar;

            Console.Clear();

            Console.WriteLine("El salario inicial era de: " + " " + salarioInicial + " " + "pesos.");
            Console.WriteLine("El salario con el aumento aplicado es de:" +" " +  salarioAumentado + "pesos");

            Console.ReadKey();

        }
    }
}
