using System.ComponentModel.Design;
using System.Text.RegularExpressions;

public class Program

{
    private static double sueldoBase;

    static void Main()
    {


        //Debemos resolver una ecuacion de primer grado 

        //Datos de entrada: Son los 3 coeficientes conque se resolvera la ecuacion

        //Proceso:Calcular de la ecuacion de primer grado segun los coeficientes

        //Declaracion de variables:
        double a, b;

        //Ingresar valores de los coeficientes
        Console.Write("Ingresar coeficiente a: ");
        a = Convert.ToDouble(Console.ReadLine());

        Console.Write("Ingresar coeficiente b: ");
        b = Convert.ToDouble(Console.ReadLine());

        //Calcular y mostrar la solucion.
        if (a == 0)
        {
            if (b == 0)
            {
                Console.WriteLine("Todos los numeros son solucion ");
            }
            else
            {
                Console.WriteLine("La ecuacion no tiene solucion");
            }

        }
        else
        {
            double x = -b / a;
            Console.WriteLine("La soluccion de la ecuacion es x = {x}");
        }
    }
}







