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
