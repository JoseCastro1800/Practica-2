using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen
{
    class Solucion
    {
        public void Conversion(int TotalC , out int P, out int C)
        {//Aqui se hacen las conversiones para saber cuantos centavos o pesos hay
            P = TotalC / 100;
            C = TotalC % 100;
        }
    }
}