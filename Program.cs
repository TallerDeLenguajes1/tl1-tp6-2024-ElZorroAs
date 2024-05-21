// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
Console.WriteLine("Hello, World!");
int a;
int b;
a = 10;
b = a;
Console.WriteLine("valor de a:" + a);
Console.WriteLine("valor de b:" + b);

/*
Ejercicio 1. Construir un programa que permita invertir un número. Verifique que el
texto ingresado es de hecho un número y, en caso afirmativo, realice la inversión del
número sólo si éste es mayor a 0.
Nota: Si observa un subrayado amarillo sugiriendo modificar las variables al tipo
"nullable", abra el archivo de configuración de proyecto de extensión .csproj y elimine
la línea que dice <Nullable>enable</Nullable>. No olvide guardar el archivo.
*/

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

