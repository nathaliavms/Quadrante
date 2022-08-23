using System;
using System.Collections.Generic;
using System.Text;

namespace Quadrante
{
    class ImprimirQuadrante
    {
        public int Coordenada1 { get; private set; }
        public int Coordenada2 { get; private set; }

        public ImprimirQuadrante(int coordenada1, int coordenada2)
        {
            Coordenada1 = coordenada1;
            Coordenada2 = coordenada2;
        }
        public string EncontrarQuadrante()
        {
           if (Coordenada1 == 0 || Coordenada2 == 0)
           {
                return " ";
           }
           else if (Coordenada1 >= 1 && Coordenada2 >= 1)
           {
                return "primeiro";
           }
           else if (Coordenada1 < 0 && Coordenada2 >= 1)
           {
                return "segundo";
           }
           else if (Coordenada1 < 0 && Coordenada2 < 0)
           {
                return "terceiro";
           }
           else 
           {
                return "quarto";
           }
        }
    }
}
