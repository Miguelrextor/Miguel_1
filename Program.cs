// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using System;
using static System.Net.Mime.MediaTypeNames;

double num1 = 0;
double num2 = 0;
int des = 0;
String resp = "";
double sum = 0;
double rest = 0;
double divi = 0;
double mul = 0;

Console.WriteLine("¿Desea usted usar la calculadora?");
resp = Console.ReadLine();

while (resp == "Si" || resp == "si")
{ 
        Console.WriteLine("====BIENVENIDO A LA CALCULADORA====");
        Console.WriteLine("Dijite el primer numero:");
        num1 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Dijite el segundo numero:");
        num2 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Elija entre estas respuestas:\n 1.Multiplicar 2 numeros.\n 2.Sumar 2 numeros.\n" +
            " 3.Restar 2 numeros\n 4.Dividir 2 numeros.\n 5.Multiplicar, restar, multiplicar y dividir estos numeros\n");

        des = Convert.ToInt32(Console.ReadLine());



        switch (des)
        {
            case 1:

                mul = num1 * num2;
                Console.WriteLine("El resultado de la multiplicacion es: " + mul);
                break;

            case 2:

                sum = num1 + num2;
                Console.WriteLine("El resultado de la suma es: " + sum);
                break;

            case 3:

                rest = num1 - num2;
                Console.WriteLine("El resultado de la resta es: " + rest);
                break;

            case 4:

                divi = num1 / num2;
                Console.WriteLine("La division de los dos numeros es: " + divi);
                break;

            case 5:

                mul = num1 * num2;
                sum = num1 + num2;
                rest = num1 - num2;
                divi = num1 / num2;
                Console.WriteLine("La multiplicacion de los 2 numeros es: " + mul + "\n" +
                    "La suma de los 2 numeros es: " + sum + "\n" + "La resta de los 2 numeros es: " + rest + "\n" +
                    "La division de los 2 numeros es: " + divi);
                break;


        }
        Console.WriteLine("Desea volver a usar la calculadora para algo mas?");
        resp = Console.ReadLine();

        


    }

