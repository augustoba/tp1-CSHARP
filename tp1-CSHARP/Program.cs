using System;
using System.Timers;

namespace tp1_CSHARP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* mensajeEjercicio1();
           edadEjercicio2();
           nombreEjercicio3();
           dobleEjercicio4();
           areaEjercicio5();
           numerosEjercicio6();
           edadEjercicio7();
           mesesEjercicio8();
           calculadoraEjercicio9();
            ejercicio10();
            ejercicio11();
            ejercicio12();
            ejercicio13();
            ejercicio14();*/
            ejercicio15();
        }

        static void mensajeEjercicio1()
        {
            /*EJERCICIO 1
         Mostrar un mensaje fijo: "Bienvenido al curso de C#".
         */
            Console.WriteLine("Bienvenido al curso de C#");
        }
        static void edadEjercicio2()
        {
            /*EJERCICIO 2 
         Pedir la edad del usuario y mostrarla.
         */
            Console.WriteLine("INGRESE LA EDAD");
            int edad = int.Parse(Console.ReadLine());

            Console.WriteLine("la edad es: " + edad);
        }
        static void nombreEjercicio3()
        {
            /*EJERCICIO 3 
         Pedir la edad del usuario y mostrarla.
         */
            Console.WriteLine("INGRESE el nombre");
            String nombre = Console.ReadLine();
            Console.WriteLine("INGRESE apellido ");
            String apellido = Console.ReadLine();
            Console.WriteLine("el nombre y apellido es : " + nombre + " " + apellido);
        }
        static void dobleEjercicio4()
        {
            /*EJERCICIO 4
        Pedir un número y mostrar su doble.
         */
            Console.WriteLine("INGRESE un numero");
            int numero = int.Parse(Console.ReadLine());
            Console.WriteLine("el doble del numero: " + numero + " es : " + (numero * 2));

        }
        static void areaEjercicio5()
        {
            /*EJERCICIO 5
             Pedir el lado de un cuadrado y calcular el área.
            */
            Console.WriteLine("ingrese el lado de un cuadrado");

            double lado = double.Parse(Console.ReadLine());

            Console.WriteLine("el area es: " + (lado * lado));
        }
        static void numerosEjercicio6()
        {
            /*EJERCICIO 6
            Pedir tres números y mostrar cuál es el mayor.
           */

            Console.WriteLine("ingrese 3 numeros");
            int numero1 = int.Parse(Console.ReadLine());
            int numero2 = int.Parse(Console.ReadLine());
            int numero3 = int.Parse(Console.ReadLine());
            int aux = 0;

            if (numero1 > numero2) aux = numero1;

            else aux = numero2;

            if (numero3 > aux)
            {
                aux = numero3;

            }
            Console.WriteLine("el numero mas grande es: " + aux);
        }
        static void edadEjercicio7()
        {

            /*EJERCICIO 7
            Preguntar la edad y decir si puede votar (mayor o igual a 16).
           */
            Console.WriteLine("ingresela edad");

            int edadV = int.Parse(Console.ReadLine());

            if (edadV >= 16) Console.WriteLine("puede votar");
            else
            {
                Console.WriteLine("no puede votar");
            }


        }
        static void mesesEjercicio8()
        {

            /*EJERCICIO 8
           Ingresar un número del 1 al 12 y mostrar el mes correspondiente.
           */

            Console.WriteLine("ingrese un numero para el mes");
            int opcion = int.Parse(Console.ReadLine());
            switch (opcion)
            {
                case 1:
                    Console.WriteLine("el mes es enero");
                    break;

                case 2:
                    Console.WriteLine("el mes es febrero");
                    break;
                case 3:
                    Console.WriteLine("el mes es marzo");
                    break;
                case 4:
                    Console.WriteLine("el mes es abril");
                    break;
                case 5:
                    Console.WriteLine("el mes es mayo");
                    break;
                case 6:
                    Console.WriteLine("el mes es junio");
                    break;
                case 7:
                    Console.WriteLine("el mes es julio");
                    break;
                case 8:
                    Console.WriteLine("el mes es agosto");
                    break;
                case 9:
                    Console.WriteLine("el mes es septiembre");
                    break;
                case 10:
                    Console.WriteLine("el mes es octubre");
                    break;
                case 11:
                    Console.WriteLine("el mes es noviembre");
                    break;
                case 12:
                    Console.WriteLine("el mes es diciembre");
                    break;
                default:
                    Console.WriteLine("opcion incorrecta");
                    break;


            }

        }
        static void calculadoraEjercicio9()
        {

            /*EJERCICIO 9
          Calculadora simple: +, -, *, / según opción elegida.
          */
            Console.WriteLine("ingrese los 2 numeros");
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            double resultado = 0;

            Console.WriteLine("ingrese la operacion + ,  - ,  * , %");
            String operacion = Console.ReadLine();

            switch (operacion)
            {
                case ("+"):
                    Console.WriteLine("la suma es: " + (num1 + num2));
                    break;

                case ("-"):
                    Console.WriteLine("la resta es: " + (num1 - num2));
                    break;

                case ("*"):
                    Console.WriteLine("la multiplicacion  es: " + (num1 * num2));
                    break;

                case ("%"):

                    Console.WriteLine("la division es: " + ((double)num1 / num2));
                    break;

                default:
                    Console.WriteLine("ingrese una opcion correcta");
                    break;
            }

        }
        static void ejercicio10()
        {
            /*EJERCICIO 10
     Calificación de letras: A, B, C, D, F y su correspondiente mensaje.
      */
            Console.WriteLine("INGRESE la letra");
                char letra = char.Parse(Console.ReadLine().ToLower());

            switch (letra)
            {
                case ('a'):
                    Console.Write("la nota es excelente");
                    break;
                case ('b'):
                    Console.Write("la nota es Bueno");
                    break;
                case ('c'):
                    Console.Write("la nota es Aprobado");
                    break;
                case ('d'):
                    Console.Write("la nota es Insuficiente");
                    break;               
                case ('f'):
                    Console.Write("la nota es Reprobado");
                    break;
                default:
                    Console.Write("ingrese una opcion correcta");
                    break;
            }
        }
        static void ejercicio11()
        {
            /*Elegir tipo de figura: cuadrado, rectángulo, círculo. De acuerdo a la figura seleccionada,
        solicita los datos necesarios para calcular la superficie.*/

            Console.WriteLine("ingrese un tipo de figura cuadrado, rectangulo, circulo");

            String opcion = Console.ReadLine().ToLower();


            switch (opcion)
            {
                case ("cuadrado"):
                    Console.WriteLine("ingrese el tamaño de un lado");
                    double lado = double.Parse(Console.ReadLine());
                    Console.WriteLine("la superficie del cuadrado es: " + (lado * lado));
                    break;
                case ("rectangulo"):
                    Console.WriteLine("ingrese el tamaño de la base y de la altura");
                    double base1 = double.Parse(Console.ReadLine());
                    double alura = double.Parse(Console.ReadLine());
                    Console.WriteLine("la superficie del rectangulo es: " + (base1 * alura));
                    break;
                case ("circulo"):
                    Console.WriteLine("ingrese radio del circulo");
                    double radio = double.Parse(Console.ReadLine());                   
                    Console.WriteLine("la superficie del circulo es: " + (Math.PI *( radio*radio)));
                    break;
                default:
                    Console.WriteLine("ingrese una opcion valida");
                    break;
                

            }

        }
        static void ejercicio12()
        {
            /*Ingresar tipo de usuario: administrador, invitado o usuario. De acuerdo al valor
            seleccionado mostrar un mensaje.*/

            Console.WriteLine("ingrese el tipo de usuario: adminsitrador, invitado o usuario");
            String opcion = Console.ReadLine().ToLower();
            switch (opcion)
            {
                case "administrador" :
                    Console.WriteLine("bienvenido administrador");
                    break;

                case "invitado":
                    Console.WriteLine("bienvenido invitado");
                    break;
                case "usuario":
                    Console.WriteLine("bienvenido usuario");
                    break;



            }
        }
        static void ejercicio13()
        {
            /* Pedir un número y decir si es par o impar*/
            Console.WriteLine("ingrese un numero");
            int numero = int.Parse(Console.ReadLine()!);
            string resultado = (numero % 2 == 0) ? "El número es par" : "El número es impar";
            Console.WriteLine(resultado);
            Console.WriteLine("Presione Enter para salir...");
            Console.ReadLine();
        }
        static void ejercicio14()
        {
            /*Pedir un número y verificar si está entre 10 y 20.*/

            Console.WriteLine("ingrese un numero");
                int numero = int.Parse(Console.ReadLine());

            Console.WriteLine((numero >= 10 && numero <= 20) ? "El número está entre 10 y 20" : "El número no se encuentra entre 10 y 20");
            Console.WriteLine("Presione Enter para salir...");
            Console.ReadLine();

        }
        static void ejercicio15() {
            /*Pedir un monto y aplicar 10% de descuento si supera $1000.*/

            Console.WriteLine("ingrese un monto");
            double monto= double.Parse(Console.ReadLine());

           monto= (monto > 1000) ? monto * 0.9: monto;

            Console.WriteLine("el total es: " + monto);

            Console.WriteLine("Presione Enter para salir...");
            Console.ReadLine();

        }
    }
}

