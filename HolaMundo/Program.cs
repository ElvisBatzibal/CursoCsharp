using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("Hello World");
        Console.ReadLine();

        //Comentario Simple-Linea:Funcional en una sola linea
        Console.WriteLine(5 + 2);
        Console.WriteLine("Hector");

        //Comentario Multilinea
        /* Inicio
         Console.WriteLine("Hector");
         Console.WriteLine("Hector");
         */

        //Control K +Control C Para Comentar
        //Control K +Control U Para Descomentar

        //Declaracion de Variables
        //Tipos de datos primitivos: Más comunes
        //https://www.dotnetperls.com/

        //Declaracion de variables
        //numeros enteros. Tamaño: 32
        int count;
        //numeros enteros - bigger range: Tamaño 64
        long wait;
        //numero de puntos flotantes: Tamaño: 32
        float away;
        //numeros de punto flotante de Doble-Precisión. Más precisos: Tamaño:64
        double trouble;
        //valore monetarios: Tamaños 128
        decimal coin;
        //Secuencia de caracteres: Tamaño: 16 bits por caracter
        string vest;
        //Caracter unico: Tamaño 16
        char grill;
        //Boleanos: Tamaño: 8
        bool teeth;

        //Inicializacion de variables
        count = 42;
        wait = 42L;
        away = 0.42F;
        trouble = 0.42;
        coin = 0.42M;
        vest = "Forty";
        grill = 'x';
        teeth = false;

        //Información adicional invetigar el rango de valores 


        Console.WriteLine(count);
        Console.WriteLine(wait);
        Console.WriteLine(away);
        Console.WriteLine(trouble);
        Console.WriteLine(coin);
        Console.WriteLine(vest);
        Console.WriteLine(grill);
        Console.WriteLine(teeth);

        Console.ReadLine();


        //Rango de valores maximos o minimos
        int entero = 2147483648;
        Console.WriteLine(entero);

        long entero2 = 2147483648;
        Console.WriteLine(entero2);

        Console.ReadLine();


    }
}

