using System.ComponentModel.Design;
using System.Reflection;
using static System.Formats.Asn1.AsnWriter;

public class Program
{
    
    private static int numeroAleatorio;
    private static bool fasle;

    private static void Main(string[] args)
    {
        //Adivina el número. Crear un programa que consiste en adivinar un número N aleatorio que el sistema escoge de un determinado rango y lo guarda enmemoria sin ser revelado.

        //El juego debe tener la funcionalidad de escoger el número de participantes que jugarán: mínimo 2 y máximo 4 integrantes.Dependiendo de la cantidad de jugadores, el número ℕ aleatorio se generar en los siguientes rangos:

        //Si participan 2 jugadores, el número ℕ aleatorio se generará entre 0 y 50

        //Si participan 3 jugadores, el número ℕ aleatorio se generará entre 0 y 100 

        //Si participan 4 jugadores, el número ℕ aleatorio se generará entre 0 y 200 

        //Numero de jugadores


        bool jugarnuevamente;
        do

        {
            jugarnuevamente = fasle;
            int jugadores = 0;


            //Seleccionar jugador

            while (jugadores < 2 || jugadores > 4)
            {
                Console.WriteLine("Porfavor ingrese el numero de jugadores (entre 2 y 4 jugadotes):");
                if (int.TryParse(Console.ReadLine(), out jugadores) && jugadores >= 2 && jugadores <= 4)

                {
                    break;
                }
                Console.WriteLine("Numero invalido. Intente nuvamente");

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
                if (int.TryParse(Console.ReadLine(), out intento))
                {
                    if (intento > numeroAleatorio)
                    {
                        Console.WriteLine("Menor");
                    }
                    else if (intento > numeroAleatorio)
                    {
                        Console.WriteLine("Mayor");
                    }
                    else
                    {
                        Console.WriteLine("Has ganado");
                        ganador = true;
                    }

                    //Cambio al siguiente jugador
                    jugadorActual = (jugadorActual + 1) % jugadores;

                }
                else
                {

                    Console.WriteLine("Numero invalido. Intente nuvamente");
                }

            }


        //Preguntar si quiere jugar nuevamente
        (Console.WriteLine("¿Quiere volver a jugar? (s/n)");

            if (Console.ReadLine().ToLower() == "s")

            {
                jugarnuevamente = true;

                //Limpiar consola para nueve partida

                Console.Clear();
            }

        } while (jugarnuevamente);

    }

    private static int NumeroAleatorio(int jugadores)
    {
        throw new NotImplementedException();
    }

    static int GenerarNumeroAleatorio(int jugadores)
    {
        Random random = new Random();
        return random.Next(0, GetMaximo(jugadores) + 1);
    }

    static int GetMaximo(int jugadores)
    {
        switch (jugadores)
        {
            case 2:
                return 50;
            case3:
                return 100;
            case 4:
                return 200;
            default:
                return 0;
        }
    }
}
























