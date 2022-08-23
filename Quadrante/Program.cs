using System;

namespace Quadrante
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite duas cordenadas na mesma linha: !");
            string[] coordenada = Console.ReadLine().Split(" ");
            var coordenada1 = int.Parse(coordenada[0]);
            var coordenada2 = int.Parse(coordenada[1]);
           
            ImprimirQuadrante resultado = new ImprimirQuadrante(coordenada1, coordenada2);
            Console.WriteLine(resultado.EncontrarQuadrante()); 
        }
    }
}
