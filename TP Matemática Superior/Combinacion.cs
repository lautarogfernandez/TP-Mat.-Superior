using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_Matemática_Superior
{
    public struct ParametrosListaDeMuestras
    {
        public double _sumaX, _sumaY, _sumaXalCuadrado, _sumaXporY, _sumaDeDistanciasAlCuadrado;

        //Constructor
        public ParametrosListaDeMuestras(double _sumaX, double _sumaY,
        double _sumaXalCuadrado, double _sumaXporY, double _sumaDeDistanciasAlCuadrado)
        {
            this._sumaX = _sumaX;
            this._sumaY = _sumaY;
            this._sumaXalCuadrado = _sumaXalCuadrado;
            this._sumaXporY = _sumaXporY;
            this._sumaDeDistanciasAlCuadrado = _sumaDeDistanciasAlCuadrado;
        }
    };

    class Combinacion
    {
        public List<List<Muestra>> _muestras;

        public List<List<Muestra>> Muestras
        {
            get { return _muestras; }
            set { _muestras = value; }
        }

        public Combinacion(List<List<Muestra>> _muestras)
        {
            Muestras = _muestras;
        }

        public double sumaParticulasFotonicas(List<Muestra> muestras)
        {
            double sum=0;
            muestras.ForEach(elemento => sum = sum + elemento.ParticulasFotonicas);
            return sum;
        }

        public double sumaHidrogenoIonizado(List<Muestra> muestras)
        {
            double sum = 0;
            muestras.ForEach(elemento => sum = sum + elemento.HidrogenoIonizado);
            return sum;
        }

        public double sumaParticulasFotonicasAlCuadrado(List<Muestra> muestras)
        {
            double sum = 0;
            muestras.ForEach(elemento => sum = sum + Math.Pow(elemento.ParticulasFotonicas,2));
            return sum;
        }

        public double sumaParticulasFotonicasPorHidrogenoIonizado(List<Muestra> muestras)
        {
            double sum = 0;
            foreach (Muestra item in muestras)
            {
                sum = sum + item.HidrogenoIonizado * item.ParticulasFotonicas;
            }
            return sum;
        }

        public Recta resolverSistema(double a, double b, double c, double d, double e, double f)
        {
            double pendiente=0, ordenada=0;
            double det = a * e - b * d;
            if (det != 0)
            {
                ordenada = (e * c - b * f) / det;
                pendiente = (a * f - d * c) / det;
            }
            else
            {
                //El sistema no tiene soluciones o infinitas, pero le asignamos (0,0). Igualmente nunca sucede en este TP.
            }
            return (new Recta(pendiente, ordenada));
        }

        public double sumaDeDistanciasAlCuadrado(List<Muestra> muestras, Recta recta)
        {
            double sum = 0;
            muestras.ForEach(elemento => sum = sum + elemento.distanciaAlcuadradoConRespectoA(recta));
            return sum;
        }

        public ParametrosListaDeMuestras cargarParametrosDeListaDeMuestras(List<Muestra> _listaDeMuestras)
        {
            double sumaX=sumaParticulasFotonicas(_listaDeMuestras);
            double sumaY=sumaHidrogenoIonizado(_listaDeMuestras);
            double sumaXalCuadrado = sumaParticulasFotonicasAlCuadrado(_listaDeMuestras);
            double sumaXporY = sumaParticulasFotonicasPorHidrogenoIonizado(_listaDeMuestras);
            double sumaDistanciasAlCuadrado=sumaDeDistanciasAlCuadrado(_listaDeMuestras,
                resolverSistema(_listaDeMuestras.Count, sumaX, sumaY, sumaX, sumaXalCuadrado, sumaXporY));
            ParametrosListaDeMuestras _nuevoParametro = new ParametrosListaDeMuestras
                (sumaX,sumaY,sumaXalCuadrado,
                sumaXporY, sumaDistanciasAlCuadrado);
            return _nuevoParametro;
        }

        public Resultado calcularRectas()
        {            
            List<ParametrosListaDeMuestras> _listaParametros=new List<ParametrosListaDeMuestras>();
            Muestras.ForEach(_listaDeMuestras=>_listaParametros.Add(
                cargarParametrosDeListaDeMuestras(_listaDeMuestras)));
            return (new Resultado(this,_listaParametros));
        }

    }
}
