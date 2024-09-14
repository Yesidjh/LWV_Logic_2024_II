using System.Text.RegularExpressions;

public class Program

{
    private static double sueldoBase;

    private static void Main(string[] args, object ConsoleConsole)


    {


        //Debemos calcular el dinero que gana el vendedor en base a las comisones por venta, la venta que le djo mayor comision, el promedio de comisones por venta  y si gano o no el beneficio.

        //Datos de entrada: Salario base, comision por ventas y beneficio extra por cumpliento de obetivo del mes.

        //Proceso:Calcular dinero del vendedor por comisiones tomando su sueldo base mas comisiones, la venta que le genero mayor comsion y el promedio de cimisiones por cada venta.

        //Declaracion de variables:
        double sueldoBase;
        double venta1, venta2, venta3;
        double comision1, comision2, comision3;
        double promedioComisiones;
        double totalComisiones, totalDevengado;
        double totalVentas;
        double objetivo = 1000000;
        double beneficioExtra = 100000;
        double totalVenta;




        Console.WriteLine("Ingrese slario base del vendedor");
        sueldoBase = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Ingrese valor de la primera venta");
        venta1 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Ingresa el valor de la segunda venta");
        venta2 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Ingrese el valor de la tercera venta");
        venta3 = Convert.ToDouble(Console.ReadLine());

        //Calculo de comision:

        comision1 = venta1 * 0.10;
        comision2 = venta2 * 0.10;
        comision3 = venta3 * 0.10;

        //Calculo total comisiones.

        totalComisiones = comision1 + comision2 + comision3;

        //Calcular total devengado mes.

        totalDevengado = sueldoBase + totalComisiones;

        //Calculo tontal de ventas.

        totalVenta = venta1 + venta2 + venta3;

        //Calculo promedio de comisiones:

        promedioComisiones = totalComisiones / 3;

        //Validar si el vendedor recibe el beneficio extra.

        bool recibeBeneficio = totalVenta >= objetivo;

        //Validar venta de mayor comision.

        double mayorComision = Math.Max(comision1, Math.Max(comision2, comision3));


        //Resultados en pantalla.
        Console.WriteLine("Resultado del mes");
        Console.WriteLine($"Comisiones totales");
        Console.WriteLine($"Salario total");
        Console.WriteLine($"Comision mayor");
        Console.WriteLine("Promedio comisiones");

        if (recibeBeneficio)

        {
            Console.WriteLine("Felicidades, alcanzaste el objetivo");
        }
        else
        {
            Console.WriteLine("Que pena, no alcanzaste el objetivo");


        }

   


    }
}
