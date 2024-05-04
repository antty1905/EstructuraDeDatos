//////1) Realiza la suma, resta, multiplicación y división de dos números ingresados por el usuario. 
//Console.WriteLine("Ingresa el primer numero");
//int num1 = int.Parse(Console.ReadLine());
//Console.WriteLine("Ingresa el segundo numero");
//int num2 = int.Parse(Console.ReadLine());

//int suma = num1 + num2;
//int resta = num1 - num2;
//int multiplicacion = num1 * num2;
//int division = num1 / num2;
//Console.WriteLine("La suma de:\f" + num1 + "\fy de :\f" + num2 + "\fes de :" + suma);
//Console.WriteLine("La resta de:\f" + num1 + "\fy de :\f" + num2 + "\fes de :" + resta);
//Console.WriteLine("La multiplicacion de:\f" + num1 + "\fy de :\f" + num2 + "\fes de :" + multiplicacion);
//Console.WriteLine("La division de:\f" + num1 + "\fy de :\f" + num2 + "\fes de :" + division);

////2) Solicita un número al usuario y determina si es par o impar. 
//Console.WriteLine("Ingresa un numero entero cualquiera");
//int numero = int.Parse(Console.ReadLine());
//if (numero % 2 == 0)
//{
//    Console.WriteLine("El numero es par");
//}
//else
//{
//    Console.WriteLine("El numero es impar");
//}

////3) Pide la base y la altura de un triángulo al usuario y calcula su área. 
//Console.WriteLine("Ingrese la medida de la Base del triangulo");
//int bas = int.Parse(Console.ReadLine());
//Console.WriteLine("Ingrese la medida de la altura del triangulo");
//int alt = int.Parse(Console.ReadLine());

//int area = (bas * alt) / 2;
//Console.WriteLine("El area del triangulo es :\t" + area + "cm2");
//4)Funcion para calcular el factorial de un numero 
//Console.WriteLine("Ingrese un numero para calcular su factorial");

//int fac = 1, x, n;
//x = 1;
//n = int.Parse(Console.ReadLine());

//while (x <= n)
//{
//    fac *= x;
//    x++;
//}
//Console.Write("El factorial es: " + fac);
//Console.ReadKey();
//5) Verifica si un número ingresado por el usuario es primo o no
//Console.WriteLine("Ingrese Un numero entero");
//int nume = int.Parse(Console.ReadLine());
//int x = 1;
//int contador = 0;

//while (x <= nume)
//{
//    if (nume % x == 0)
//    {
//        contador++;
//    }
//    x++;
//}
//if (contador == 2)
//{
//    Console.WriteLine("El numero ingresado es Primo");
//}
//else
//{
//    Console.WriteLine("El numero Ingresado NO es Primo");
//}
//6) Toma una cadena de texto y muestra su inversión. 
//string cadenaOriginal = "Hola, mundo!";
//string cadenaInvertida = InvertirCadena(cadenaOriginal);

//Console.WriteLine("Cadena original: " + cadenaOriginal);
//Console.WriteLine("Cadena invertida: " + cadenaInvertida);


//static string InvertirCadena(string cadena)
//{
//    char[] caracteres = cadena.ToCharArray();
//    Array.Reverse(caracteres);
//    return new string(caracteres);
//}

//7) Calcula la suma de los números pares en un rango especificado por el usuario. 
//Console.WriteLine("Ingrese el valor mínimo del rango:");
//int min = Convert.ToInt32(Console.ReadLine());

//Console.WriteLine("Ingrese el valor máximo del rango:");
//int max = Convert.ToInt32(Console.ReadLine());

//int sumaPares = SumaNumerosParesEnRango(min, max);

//Console.WriteLine($"La suma de los números pares en el rango de {min} a {max} es: {sumaPares}");


//static int SumaNumerosParesEnRango(int min, int max)
//{
//    int suma = 0;

//    Iterar a través del rango y sumar los números pares
//    for (int i = min; i <= max; i++)
//    {
//        if (i % 2 == 0) // Verificar si el número es par
//        {
//            suma += i;
//        }
//    }

//    return suma;

//}

//8) Crea una lista de los cuadrados de los primeros 10 números naturales.

//List<int> cuadrados = new List<int>();

//for (int i = 1; i <= 10; i++)
//{
//    cuadrados.Add(i * i);
//}

//Console.WriteLine("Los cuadrados de los primeros 10 números naturales son:");
//foreach (int cuadrado in cuadrados)
//{
//    Console.WriteLine(cuadrado);
//}
//9) Cuenta el número de vocales en una cadena de texto. 

//Console.WriteLine("Ingrese una cadena de texto:");
//string texto = Console.ReadLine();

//int contadorVocales = ContarVocales(texto);

//Console.WriteLine($"El número de vocales en el texto es: {contadorVocales}");


//static int ContarVocales(string texto)
//{
//    int contador = 0;
//    foreach (char c in texto.ToLower())
//    {
//        if ("aeiou".Contains(c))
//        {
//            contador++;
//        }
//    }
//    return contador;
//}
//10) Genera los primeros 10 números de la serie Fibonacci. 
//int ni = 10;
//Console.WriteLine($"Los primeros {ni} números de la serie Fibonacci son:");
//for (int i = 0; i < ni; i++)
//{
//    Console.WriteLine(Fibonacci(i));
//}


//static int Fibonacci(int n)
//{
//    if (n <= 1)
//        return n;
//    else
//        return Fibonacci(n - 1) + Fibonacci(n - 2);
//}
//11) Ordena una lista de números ingresados por el usuario de menor a mayor.
Console.WriteLine("Ingrese los números separados por espacio:");
string input = Console.ReadLine();
string[] numerosComoString = input.Split(' ');
List<int> numeros = new List<int>();

foreach (string numer in numerosComoString)
{
    if (int.TryParse(numer, out int nx))
    {
       numeros.Add(nx);
    }
    else
    {
        Console.WriteLine($"'{numer}' no es un número válido y será ignorado.");
    }
}

numeros.Sort();

Console.WriteLine("Lista ordenada de menor a mayor:");
foreach (int numer in numeros)
{
    Console.WriteLine(numer);
}
//12)Verifica si una palabra ingresada por el usuario es un palíndromo.
Console.WriteLine("Ingrese una palabra:");
string palabra = Console.ReadLine();

bool esPalindromo = VerificarPalindromo(palabra);

if (esPalindromo)
{
    Console.WriteLine("La palabra ingresada es un palíndromo.");
}
else
{
    Console.WriteLine("La palabra ingresada no es un palíndromo.");
}
    

    static bool VerificarPalindromo(string palabra)
{
    palabra = palabra.ToLower();
    int izquierda = 0;
    int derecha = palabra.Length - 1;

    while (izquierda < derecha)
    {
        if (palabra[izquierda] != palabra[derecha])
        {
            return false;
        }
        izquierda++;
        derecha--;
    }

    return true;
}
//13)Crea un programa que genere la tabla de multiplicar de un número ingresado por el usuario
Console.WriteLine("Ingrese un número para generar su tabla de multiplicar:");
int num = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Tabla de multiplicar del {num}:");
for (int i = 1; i <= 10; i++)
{
    Console.WriteLine($"{num} x {i} = {num * i}");
}
//14) Pide el radio de un círculo al usuario y calcula su área. 
Console.WriteLine("Ingrese el radio del círculo:");
double radio = Convert.ToDouble(Console.ReadLine());

double area1 = CalcularAreaCirculo(radio);

Console.WriteLine($"El área del círculo con radio {radio} es: {area1}");
    

    static double CalcularAreaCirculo(double radio)
{
    return Math.PI * Math.Pow(radio, 2);
}
//15) Toma un número entero y calcula la suma de sus dígitos.
Console.WriteLine("Ingrese un número entero:");
int nu = Math.Abs(Convert.ToInt32(Console.ReadLine()));

int sumaDigitos = SumaDigitos(nu);

Console.WriteLine($"La suma de los dígitos del número es: {sumaDigitos}");
    

    static int SumaDigitos(int numero)
{
    int suma = 0;

    while (numero != 0)
    {
        suma += numero % 10;
        numero /= 10;
    }

    return suma;
}
Console.ReadKey();