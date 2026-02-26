using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Ingrese un número: ");
        int numero = int.Parse(Console.ReadLine());

        string resultado = CheckNumber(numero);
        Console.WriteLine(resultado);
    }

    static string CheckNumber(int numero)
    {
        if (numero > 0)
        {
            return "El número es positivo";
        }
        else if (numero < 0)
        {
            return "El número es negativo";
        }
        else
        {
            return "El número es cero";
        }
    }
}