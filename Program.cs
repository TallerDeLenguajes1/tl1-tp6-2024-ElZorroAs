/*
Ejercicio 3. Ingrese al Branch CalculadoraV2 para implementar las mejoras en la
calculadora.. Solicite al usuario un número y muestre por pantalla:
● El valor absoluto de un número
● El cuadrado
● La raíz cuadrada
● El seno
● El Coseno
● La parte entera de un tipo float.
Luego de esto, solicite dos números al usuario y determine:
● El Máximo entre los dos números
● El Mínimo entre los dos números
Para TODOS los casos, no olvide contemplar siempre el caso de que el usuario no
ingrese un número válido
*/

string leer;
bool valido;
double numero;
int opcion;

do
{
    Console.WriteLine("1 - Valor absoluto");
    Console.WriteLine("2 - Cuadrado");
    Console.WriteLine("3 - Raíz cuadrada");
    Console.WriteLine("4 - Seno");
    Console.WriteLine("5 - Coseno");
    Console.WriteLine("6 - Parte entera de un tipo float");
    Console.WriteLine("7 - Salir");

    Console.WriteLine("Ingrese la opción");
    leer = Console.ReadLine();
    valido = int.TryParse(leer, out opcion);

    if (opcion == 7) // Si la opción es 9, salir del programa
    {
        Console.WriteLine("Saliendo del programa...");
        break;
    }

    if (valido && opcion >= 1 && opcion <= 6) // Verificar si la opción es válida
    {
        Console.WriteLine("Ingrese el número");
        leer = Console.ReadLine();
        valido = double.TryParse(leer, out numero);

        if (!valido)
        {
            Console.WriteLine("Número inválido. Inténtelo de nuevo.");
            continue; // Si el número no es válido, volver al inicio del bucle
        }

        switch (opcion)
        {
            case 1:
                Console.WriteLine($"Valor absoluto: {Math.Abs(numero)}");
                break;
            case 2:
                Console.WriteLine($"Cuadrado: {Math.Pow(numero, 2)}");
                break;
            case 3:
                Console.WriteLine($"Raíz cuadrada: {Math.Sqrt(numero)}");
                break;
            case 4:
                Console.WriteLine($"Seno: {Math.Sin(numero)}");
                break;
            case 5:
                Console.WriteLine($"Coseno: {Math.Cos(numero)}");
                break;
            case 6:
                Console.WriteLine($"Parte entera: {Math.Floor(numero)}");
                break;
        }
    }
    else
    {
        Console.WriteLine("Opción no válida. Inténtelo de nuevo.");
    }

} while (true);

double numero1, numero2;

Console.WriteLine("Ingrese el primer número:");
leer = Console.ReadLine();
valido = double.TryParse(leer, out numero1);

if (!valido)
{
    Console.WriteLine("Número inválido. Programa terminado.");
    return;
}

Console.WriteLine("Ingrese el segundo número:");
leer = Console.ReadLine();
valido = double.TryParse(leer, out numero2);

if (!valido)
{
    Console.WriteLine("Número inválido. Programa terminado.");
    return;
}

double maximo = Math.Max(numero1, numero2);
double minimo = Math.Min(numero1, numero2);

Console.WriteLine($"El máximo entre los dos números es: {maximo}");
Console.WriteLine($"El mínimo entre los dos números es: {minimo}");
