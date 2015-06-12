using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_Matemática_Superior
{
    class Resultado
    {
        public List<Muestra> muestra1, muestra2;
        public Recta recta1, recta2;
        public double sumaDeDistanciasAlCuadrado1, sumaDeDistanciasAlCuadrado2;

        public Resultado(List<Muestra> muestra1, List<Muestra> muestra2, Recta recta1, Recta recta2, double sumaDeDistanciasAlCuadrado1, double sumaDeDistanciasAlCuadrado2)
        {
            this.muestra1 = muestra1;
            this.muestra2 = muestra2;
            this.recta1 = recta1;
            this.recta2 = recta2;
            this.sumaDeDistanciasAlCuadrado1 = sumaDeDistanciasAlCuadrado1;
            this.sumaDeDistanciasAlCuadrado2 = sumaDeDistanciasAlCuadrado2;
        }

        public bool errorMenorALoIndicado()
        {
            return ((resultado.sumaDeDistanciasAlCuadrado1 < 0.3) && (resultado.sumaDeDistanciasAlCuadrado2 < 0.3));
        }

    }
}
