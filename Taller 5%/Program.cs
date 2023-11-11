/* Dado un vector de tamaño N, llenar el vector aleatoriamente con números enteros.
Pedir por pantalla un número y determinar si ese número se encuentra en el vector,
en caso afirmativo, indicar su posición (índice)
dentro del vector, en caso negativo, mostrar el mensaje “El número no existe”.*/




using System;
using System.Numerics;

public class TallerFinal
{
    static void Main()
    {
        Random random = new Random();
        int[] NVector = new int[1996];

        for (int i = 0; i < NVector.Length; i++)
        {
            NVector[i] = random.Next(1, 101);
        }

        bool continuar = true;

        do
        {

            Console.WriteLine("\nEscribe un numero por favor: ");
            int numeroAleatorio = int.Parse(Console.ReadLine());

            Console.Write("Buscando ");
            for (int i = 0; i < 3; i++)
            {
                Console.Write(".");
                Thread.Sleep(500);
            }
            Console.WriteLine();

            int posicion = 102;

            for (int i = 0; i < NVector.Length; i++)
            {
                if (NVector[i] == numeroAleatorio)
                {
                    posicion = i;
                    break;
                }
            }

            if (posicion != 102)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"El número {numeroAleatorio} se encuentra en la posición {posicion} del NVector.");
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("El número no existe en NVector.");
                Console.ResetColor();

            }

            string respuesta;
            do
            {
                Console.WriteLine("\n¿Deseas buscar otro número? (Sí/No)");
                respuesta = Console.ReadLine().ToLower();

                if (respuesta != "si" && respuesta != "sí" && respuesta != "no")
                {
                    Console.WriteLine("\nRespuesta incorrecta. Por favor, ingresa 'Sí' o 'No'.");
                }
            } while (respuesta != "si" && respuesta != "sí" && respuesta != "no");

            if (respuesta != "si" && respuesta != "sí")
            {
                continuar = false;
            }
        } while (continuar);

        Console.WriteLine("\n¿Deseas ver el NVector completo? (Sí/No)");
        string respuestaVerNVector = Console.ReadLine().ToLower();

        if (respuestaVerNVector == "si" || respuestaVerNVector == "sí")
        {
            Console.WriteLine("\nNVector completo: \n");
            for(int i = 0; i < NVector.Length; i++)
            {
                ConsoleColor color = (ConsoleColor)random.Next(1, 16); 
                Console.ForegroundColor = color;
                Console.Write(NVector[i] + " ");
            }
            Console.ResetColor();
        }
        
    }
}