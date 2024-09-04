public class Program
{
    //Lea las coordenadas de dos puntos y que muestre la distancia entre los dos puntos.
    private static void Main(string[] args)
    {
        //Lea las coordenadas de dospuntos y que muestre las distancias entre los dos puntos

        //Datos de entrada
        //Declarar las variables, en este caos son 4:
        double x1, x2, y1, y2, d;

        //Vamos a inicilizar mis variables pidiendo valores en pantalla:
        Console.WriteLine("Por favor ingrese el valor de x1: "); //Esta es la forma de leer en pantalla
        x1 = Convert.ToDouble(Console.ReadLine()); //Esta es la forma de escribir en pantalla

        Console.WriteLine("Por favor ingrese el valor de y1: ");
        y1 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Por favor ingrese el valor de x2: ");
        x2 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Por favor ingrese el valor de y2: ");
        y2 = Convert.ToDouble(Console.ReadLine());

        //Proceso - Calculo de variable "d"

        double x = (x2 - x1) * (x2 - x1);
        double y = (y2 - y1) * (y2 - y1);

        double suma = x + y;

        //La clase Math tiene muchos metodos, entre ellos el metodo Sqrt, este señor reibe un parametro dentro de sus (), ese parametro es el nuemero que yo le mando al metodo para que me saque la Raiz cuadrada
        d = Math.Sqrt(suma);

        //Forma mas primitiva de concatenar texto a traves del simbolo "+"
        Console.WriteLine("Concatenar con +");
        Console.Write("La distancia entre los pares ordenados (" + x1 + "," + y1 + ") y (" + x2 + "," + y2 + ") es: " + d);

        Console.WriteLine("");

        //Forma de concatenar a traves del simbolo "$" se llama Interpolacion:
        Console.WriteLine("Concatenar con $");
        Console.Write($"La distancia entre los pares ordenados ({x1},{y1} y ({x2},{y2}) es: {d}");

        Console.WriteLine("");





    }
}