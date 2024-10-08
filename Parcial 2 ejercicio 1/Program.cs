using System.Reflection;
using static System.Formats.Asn1.AsnWriter;

public class Program
{
    private static de fasle;

    private static void Main(string[] args)
    {
        //Adivina el número. Crear un programa que consiste en adivinar un número N aleatorio que el sistema escoge de un determinado rango y lo guarda enmemoria sin ser revelado.

        //El juego debe tener la funcionalidad de escoger el número de participantes que jugarán: mínimo 2 y máximo 4 integrantes.Dependiendo de la cantidad de jugadores, el número ℕ aleatorio se generar en los siguientes rangos:

        //Si participan 2 jugadores, el número ℕ aleatorio se generará entre 0 y 50

        //Si participan 3 jugadores, el número ℕ aleatorio se generará entre 0 y 100 

        //Si participan 4 jugadores, el número ℕ aleatorio se generará entre 0 y 200 

        //Numero de jugadores

       
            bool jugar 
            do

        { jugar nuevamente = fasle;
            int jugadores = 0;


            //Seleccionar jugador

            while (jugadores < 2 || jugadores > 4)
            {
                Console.WriteLine("Porfavor ingrese el numero de jugadores (entre 2 y 4 jugadotes):");
                if (int.TryParse(Console.ReadLine(), out jugadores) && jugadores >= 2 && jugadores <= 4)

                {
                    break;
                }
                Console.WriteLine("Numero incorrecto. Intente nuvamente");

            }

            //Generar numero aleatorio segun nuemro de jugadores

            int numeroAleaotorio = NumeroAleatorio(jugadores);

            Console.WriteLine($"Se genero un numero entre 0 y {GetMaximo(jugadores)}.");

            int jugadorActual = 0;
            bool ganador = false;

            while (!ganador)
            {
                Console.WriteLine($"{jugadorActual + 1}, ingresa un numero:");
                int intento;
      
            




