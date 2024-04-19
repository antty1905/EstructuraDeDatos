//1) Realiza la suma, resta, multiplicación y división de dos números ingresados por el usuario. 
Console.WriteLine("Ingresa el primer numero");
int num1 = int.Parse(Console.ReadLine());
Console.WriteLine("Ingresa el segundo numero");
int num2 = int.Parse(Console.ReadLine());

int suma = num1 + num2;
int resta = num1 - num2;
int multiplicacion = num1 * num2;
int division = num1 / num2;
Console.WriteLine("La suma de:\f" + num1 + "\fy de :\f" + num2 + "\fes de :" + suma);
Console.WriteLine("La resta de:\f" + num1 + "\fy de :\f" + num2 + "\fes de :" + resta);
Console.WriteLine("La multiplicacion de:\f" + num1 + "\fy de :\f" + num2 + "\fes de :" + multiplicacion);
Console.WriteLine("La division de:\f" + num1 + "\fy de :\f" + num2 + "\fes de :" + division);

//2) Solicita un número al usuario y determina si es par o impar. 
Console.WriteLine("Ingresa un numero entero cualquiera");
int numero = int.Parse(Console.ReadLine());
if (numero % 2 == 0)
{
    Console.WriteLine("El numero es par");
}
else
{
    Console.WriteLine("El numero es impar");
}