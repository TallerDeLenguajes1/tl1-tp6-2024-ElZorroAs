/*
// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
Console.WriteLine("Hello, World!");
int a;
int b;
a = 10;
b = a;
Console.WriteLine("valor de a:" + a);
Console.WriteLine("valor de b:" + b);
*/
/*
Ejercicio 1. Construir un programa que permita invertir un número. Verifique que el
texto ingresado es de hecho un número y, en caso afirmativo, realice la inversión del
número sólo si éste es mayor a 0.
Nota: Si observa un subrayado amarillo sugiriendo modificar las variables al tipo
"nullable", abra el archivo de configuración de proyecto de extensión .csproj y elimine
la línea que dice <Nullable>enable</Nullable>. No olvide guardar el archivo.
*/
/*
Console.WriteLine("Ingrese el numero xd");
string leer = Console.ReadLine();
double numero,resto=0;
bool valido = double.TryParse(leer, out numero);
if (valido)
{
    if (numero > 0)
    {
        while (numero > 0)
        {
            resto = resto * 10 + numero % 10;
            numero = Math.Floor(numero / 10);
            
        }
        Console.WriteLine("El numero invertido es "+resto);
    }else
    {
        Console.WriteLine("El numero no es valido");
    }
}
*/

/*
Para los ejercicios 2 y 3, cree dos branchs en su repositorio, CalculadoraV1 y
CalculadoraV2
Ejercicio 2. Ingrese al branch CalculadoraV1 y construya un programa que sea una
calculadora que permita al usuario realizar las 4 operaciones básicas (Sumar, Restar,
Multiplicar y Dividir) a partir de un menú para seleccionar la opción a elegir y que luego
pida dos números y que devuelva el resultado de la operación seleccionada. Además
una vez que termine de realizar la operación le pregunte si desea realizar otro cálculo.
*/
string leer;
bool valido;
double numero, numero2, salida;
int opcion;

do
{
    Console.WriteLine("1 - Suma");
    Console.WriteLine("2 - Resta");
    Console.WriteLine("3 - Multiplicación");
    Console.WriteLine("4 - División");
    Console.WriteLine("5 - Salir");

    Console.WriteLine("Ingrese la opcion");
    leer = Console.ReadLine();
    valido = int.TryParse(leer, out opcion);

    if (opcion == 5)
    {
        Console.WriteLine("Saliendo del programa...");
        break;
    }

    if (valido)
    {
        Console.WriteLine("Ingrese el primer numero");
        leer = Console.ReadLine();

        valido = double.TryParse(leer, out numero);

        Console.WriteLine("Ingrese el segundo numero");
        leer = Console.ReadLine();

        valido = double.TryParse(leer, out numero2) == valido;
        if (valido)
        {
            switch (opcion)
            {
                case 1:
                    Console.WriteLine($"Resultado de la suma: {numero + numero2}");
                    break;
                case 2:
                    Console.WriteLine($"Resultado de la resta: {numero - numero2}");
                    break;
                case 3:
                    Console.WriteLine($"Resultado de la multiplicación: {numero * numero2}");
                    break;
                case 4:
                    if (numero2 != 0)
                    {
                        Console.WriteLine($"Resultado de la división: {numero / numero2}");
                    }
                    else
                    {
                        Console.WriteLine("Error: División por cero");
                    }
                    break;

                default:
                    Console.WriteLine("Opción no válida");
                    break;
            }
        }
    }

} while (true);

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
