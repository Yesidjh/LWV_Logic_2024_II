using System.Text.RegularExpressions;

public class Program

{ 

    private static void Main(string[] args)

    {

        //ingresar las notas de varios estudiantes, calcular su promedio y luego clasificar a cada estudiante en diferentes categorías de desempeño académico. Al final, se le pregunta al usuario si quiere ingresar otro grupo de estudiantes

        do

        {
            List<double> notas = new List<double>();
            string continuar;

            Console.Write("Porfavor ingresa la cantidad de estudinates");
            int cantidadEstudiantes = int.Parse(Console.ReadLine());

            for (int i = 0; i < cantidadEstudiantes; i++)

            {

                Console.Write($"Ingresa la nota del estudiante {i + 1}:");
                double nota = double.Parse(Console.ReadLine());
                notas.Add(nota);

            }




        
