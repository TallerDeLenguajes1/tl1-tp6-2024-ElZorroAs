/*
Ejercicio 4.
Realizar los siguientes ejercicios
Dada una cadena (un string) de texto ingresada por el usuario, realice las siguientes
tarea:


*/
//● Obtener la longitud de la cadena y muestre por pantalla.
Console.WriteLine("Ingrese una cadena de texto:");
string texto = Console.ReadLine();

int longitud = texto.Length;

Console.WriteLine($"La longitud de la cadena ingresada es: {longitud}");

//● A partir de una segunda cadena ingresada por el usuario, concatene ambas cadenas distintas.

Console.WriteLine("Ingrese otra cadena de texto:");
string texto1 = Console.ReadLine();

string concatenar = texto + texto1;

Console.WriteLine("La cadena concatenada es: " + concatenar);

//● Extraer una subcadena de la cadena ingresada.

int startIndex = 5;  // Comienza después de la coma
int length = 5;      // Longitud de "mundo"

string substring = texto.Substring(startIndex, length);

Console.WriteLine("Cadena original: " + texto);
Console.WriteLine("Subcadena: " + substring);

/*
● Utilizando la calculadora creada anteriormente realizar las operaciones de dos
números y mostrar por pantalla y mostrar en texto el resultado. Por ejemplo para
la suma sería:
“la suma de “ num1 “ y de” num2 “ es igual a: ” resultado.
Donde num1, num2 y resultados son los sumandos y el resultado de la operación
respectivamente.
Nota: Busque el comportamiento del Método ToString();
*/
Console.WriteLine("Ingrese el primer número:");
double num1 = double.Parse(Console.ReadLine());
Console.WriteLine("Ingrese el segundo número:");
double num2 = double.Parse(Console.ReadLine());

double suma = num1 + num2;
double resta = num1 - num2;
double multiplicacion = num1 * num2;
double division = num1 / num2;

Console.WriteLine($"La suma de {num1} y {num2} es igual a: {suma}");
Console.WriteLine($"La resta de {num1} y {num2} es igual a: {resta}");
Console.WriteLine($"La multiplicación de {num1} y {num2} es igual a: {multiplicacion}");
Console.WriteLine($"La división de {num1} y {num2} es igual a: {division}");


//● Recorrer la cadena de texto con un ciclo Foreach e ir mostrando elemento por elemento en pantalla
foreach (char character in texto)
{
    Console.WriteLine(character);
}

//● Buscar la ocurrencia de una palabra determinada en la cadena ingresada
Console.WriteLine("Ingrese una cadena de texto:");
string cadena = Console.ReadLine();
Console.WriteLine("Ingrese la palabra a buscar:");
string palabra = Console.ReadLine();
if (cadena.Contains(palabra))
{
    Console.WriteLine($"La palabra '{palabra}' se encontró en la cadena.");
}
else
{
    Console.WriteLine($"La palabra '{palabra}' no se encontró en la cadena.");
}

//● Convierta la cadena a mayúsculas y luego a minúsculas.
Console.WriteLine($"Conversion de {cadena} en mayusculas es: {cadena.ToUpper()}");
Console.WriteLine($"Conversion de {cadena} en minusculas es: {cadena.ToLower()}");
//● Ingrese una cadena separada por caracteres que usted determine y muestre por pantalla los resultados
//(Revisar el comportamiento de split())
string cadenaComa="No@se@que@poner@pero@esta@separada@con@comas@xD";
string[] partes1 = cadenaComa.Split('@');
Console.WriteLine("Las partes de la cadena son:");
foreach (string parte in partes1)
{
    Console.WriteLine(parte);
}

//● Siguiendo con el ejemplo de la calculadora (ejercicio 2) ingrese una ecuación simple como cadena de caracteres
//y que el sistema lo resuelva. Por ej. ingrese por pantalla “582+2” y que le devuelva la suma de 582 con 2
Console.WriteLine("Ingrese una ecuación simple (por ejemplo, 582+2):");
string ecuacion = Console.ReadLine();
string[] partes = ecuacion.Split(new char[] { '+', '-', '*', '/' }, StringSplitOptions.RemoveEmptyEntries);
double num1_ecuacion = double.Parse(partes[0]);
double num2_ecuacion = double.Parse(partes[1]);
double resultado_ecuacion = 0;

string operador = new string(ecuacion.Except(partes[0]).Except(partes[1]).ToArray()).Trim();

switch (operador)
{
    case "+":
        resultado_ecuacion = num1_ecuacion + num2_ecuacion;
        break;
    case "-":
        resultado_ecuacion = num1_ecuacion - num2_ecuacion;
        break;
    case "*":
        resultado_ecuacion = num1_ecuacion * num2_ecuacion;
        break;
    case "/":
        resultado_ecuacion = num1_ecuacion / num2_ecuacion;
        break;
    default:
        Console.WriteLine("Ecuación no válida.");
        break;
}
Console.WriteLine($"El resultado de {ecuacion} es: {resultado_ecuacion}");
