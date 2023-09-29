using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen
{
    internal class Metodos
    {
            static void MostrarTabladeMultiplicar(int numero, int multiplicador)
            {
                if(multiplicador <= 10)
                {
                    int resultado = numero * multiplicador;
                    Console.WriteLine($"{numero} X {multiplicador} = {resultado}.");
                    MostrarTabladeMultiplicar(numero * multiplicador, + 1);
                }
            }
        
    }
}



















     
        
