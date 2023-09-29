using System;
class Program
{
    static void  Main(string[] args)
    {
        Console.WriteLine("Ingrese un numero que muestre la tabla de multiplicar");
        if (int.TryParse(Console.ReadLine(), out int numero))
        {
            Console.WriteLine($"Tabla de multiplicar del {numero}:");
            MostrarTabladeMultiplicar(numero, 1);
        }
        else
        {
            Console.WriteLine("Entrada no valida. Por favor, ingrese una numero entero.");
        }
        static void MostrarTabladeMultiplicar(int numero, int multiplicador)
        {
            if (multiplicador <= 10)
            {
           
                int resultado = numero * multiplicador;
                Console.WriteLine($"{numero} X {multiplicador} = {resultado}.");
                MostrarTabladeMultiplicar(numero * multiplicador, +1);
            }
        }
        /*static void Main()
        {

            Console.Write("Ingrese el número de inicio del intervalo: ");
            int inicio = int.Parse(Console.ReadLine());

            Console.Write("Ingrese el número de fin del intervalo: ");
            int fin = int.Parse(Console.ReadLine());

            if (inicio == fin)
            {
                Console.WriteLine("Los números ingresados son iguales.");
            }
            else
            {

                int paso = (inicio < fin) ? 1 : -1;


                for (int numero = inicio; numero != fin + paso; numero += paso)
                {
                    Console.WriteLine($"La secuencia de los números es {numero}");
                }
            }
        }*/

    }
}








   