using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_Matemática_Superior
{
    class Combinacion
    {      
        public List<Muestra> muestra1, muestra2;

        public Combinacion(List<Muestra> muestra1, List<Muestra> muestraTotal)
        {
            this.muestra1 = muestra1;
            this.muestra2 = muestraTotal.Where(muestra => muestra1.Contains(muestra));
        }

        public bool esIgual(Combinacion laOtra)
        {
            return //TODO: ver si sirve
        }

        public int sumaParticulasFotonicas(List<Muestra> muestras)
        {
            return muestras.Select(muestra => muestra.particulasFotonicas).Sum;
        }

        public int sumaHidrogenoIonizado(List<Muestra> muestras)
        {
            return muestras.Select(muestra => muestra.hidrogenoIonizado).Sum;
        }

        public int sumaParticulasFotonicasAlCuadrado(List<Muestra> muestras)
        {
            return muestras.Select(muestra => Math.Pow(muestra.particulasFotonicas,2)).Sum;
        }

        public int sumaParticulasFotonicasPorHidrogenoIonizado(List<Muestra> muestras)
        {
            return muestras.Select(muestra => muestra.particulasFotonicas * muestra.hidrogenoIonizado).Sum;
        }

        public Recta resolverSistema(double a, double b, double c, double d, double e, double f)
        {
            double pendiente, ordenada;
            double det = a * e - b * d;
            if (det != 0)
            {                
                pendiente = (e * c - b * f) / det;
                ordenada = (a * f - d * c) / det;
                return (new Recta(pendiente, ordenada));
            }
            else
            {
                //"El sistema no tiene soluciones o infinitas"
                return (new Recta(0, 0));//esta mal pero no se como es
            }
        }

        public double sumaDeDistanciasAlCuadrado(List<Muestra> muestra, Recta recta)
        {
            return sumaDeDistanciasAlCuadrado = muestra1.Select(muestra => muestra.distanciaAlcuadradoConRespectoA(recta)).Sum;
        }

        public Resultado calcularRectas()
        {
            double sumaX1 = sumaParticulasFotonicas(muestra1);
            double sumaY1 = sumaHidrogenoIonizado(muestra1);
            double sumaX1AlCuadrado1 = sumaParticulasFotonicasAlCuadrado(muestra1);
            double sumaMultiplicacionXY1 = sumaParticulasFotonicasPorHidrogenoIonizado(muestra1);
            double sumaX2 = sumaParticulasFotonicas(muestra2);
            double sumaY2 = sumaHidrogenoIonizado(muestra2);
            double sumaX2AlCuadrado2 = sumaParticulasFotonicasAlCuadrado(muestra2);
            double sumaMultiplicacionXY2 = sumaParticulasFotonicasPorHidrogenoIonizado(muestra2);
            Recta recta1 = resolverSistema(muestra1.Count, sumaX1, sumaY1, sumaX1, sumaX1AlCuadrado1, sumaMultiplicacionXY1);
            Recta recta2 = resolverSistema(muestra2.Count, sumaX2, sumaY2, sumaX2, sumaX2AlCuadrado2, sumaMultiplicacionXY2);
            double sumaDeDistanciasAlCuadrado1 = sumaDeDistanciasAlCuadrado(muestra1, recta1);
            double sumaDeDistanciasAlCuadrado2 = sumaDeDistanciasAlCuadrado(muestra2, recta2);
            return (new Resultado(muestra1, muestra2, recta1, recta2, sumaDeDistanciasAlCuadrado1, sumaDeDistanciasAlCuadrado2));
        }

    }
}
