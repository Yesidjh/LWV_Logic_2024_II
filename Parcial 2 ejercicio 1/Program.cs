

public class Program
{
    

    private static void Main(string[] args)

    {
        //Adivina el número. Crear un programa que consiste en adivinar un número N aleatorio que el sistema escoge de un determinado rango y lo guarda enmemoria sin ser revelado.

        //El juego debe tener la funcionalidad de escoger el número de participantes que jugarán: mínimo 2 y máximo 4 integrantes.Dependiendo de la cantidad de jugadores, el número ℕ aleatorio se generar en los siguientes rangos:

        //Si participan 2 jugadores, el número ℕ aleatorio se generará entre 0 y 50

        //Si participan 3 jugadores, el número ℕ aleatorio se generará entre 0 y 100 

        //Si participan 4 jugadores, el número ℕ aleatorio se generará entre 0 y 200 

        //Numero de jugadores


        Random random = new Random();
        bool jugarOtraVez;

        do
        {
            int cantidadJugadores;
            do
            {
                Console.Write("Ingrese el número de jugadores (2-4): ");
                cantidadJugadores = int.Parse(Console.ReadLine());
            } while (cantidadJugadores < 2 || cantidadJugadores > 4);

            int numeroSecreto;
            switch (cantidadJugadores)
            {
                //Rango de 0 a 50
                case 2:
                    numeroSecreto = random.Next(0, 51);
                    break;

                // Rango de 0 a 100
                case 3:
                    numeroSecreto = random.Next(0, 101);
                    break;

                // Rango de 0 a 200
                case 4:
                    numeroSecreto = random.Next(0, 201);
                    break;

                default:
                    numeroSecreto = 0;
                    break;

            }

            int jugadorActual = 0;
            bool ganador = false;

            while (!ganador)

            {

                Console.WriteLine($"Turno del jugador {jugadorActual + 1}. Ingrese su intento:");
                int intento = int.Parse(Console.ReadLine());

                if (intento > numeroSecreto)
                {
                    Console.WriteLine("MENOR");
                }
                else if (intento < numeroSecreto)
                {
                    Console.WriteLine("MAYOR");






















