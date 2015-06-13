using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_Matemática_Superior
{

    class Combinacion
    {
        private List<List<Muestra>> _muestras;
        public struct ParametrosListaDeMuestras
        {
            public double _sumaX, _sumaY, _sumaXalCuadrado, _sumaXporY, _sumaDeDistanciasAlCuadrado;
            //Constructor
            public ParametrosListaDeMuestras(double _sumaX, double _sumaY,
            double _sumaXalCuadrado, double _sumaXporY,double _sumaDeDistanciasAlCuadrado)
            {
                this._sumaX = _sumaX;
                this._sumaY = _sumaY;
                this._sumaXalCuadrado = _sumaXalCuadrado;
                this._sumaXporY = _sumaXporY;
                this._sumaDeDistanciasAlCuadrado = _sumaDeDistanciasAlCuadrado ;
            }
        };
        #region Setters and Getters
        public List<List<Muestra>> Muestras
        {
            get { return _muestras; }
            set { _muestras = value; }
        }
        #endregion
        #region Public methods
        public Combinacion(List<List<Muestra>> _muestras)
        {
            Muestras = _muestras;
        }

        public bool tieneLosMismosElementos(Combinacion laOtra)
        {
            return Muestras.TrueForAll(_listaDeMuestras=>_listaDeMuestras.
                TrueForAll(_muestra=>laOtra.Muestras.Exists(_listaDeMuestras2=>_listaDeMuestras2.Exists(_muestra2
                    =>_muestra2.esIgual(_muestra)))));//TODO: ver si sirve
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
            muestras.ForEach(elemento => sum = sum + Math.Pow(elemento.HidrogenoIonizado, 2));
            return sum;
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
        #endregion
        public double sumaDeDistanciasAlCuadrado(List<Muestra> muestras, Recta recta)
        {
            double sum = 0;
            muestras.ForEach(elemento => sum = sum + elemento.distanciaAlcuadradoConRespectoA(recta));
            return sum;
        }

        public ParametrosListaDeMuestras cargarParametrosDeListaDeMuestras(List<Muestra> _listaDeMuestras)
        {
            ParametrosListaDeMuestras _nuevoParametro = new ParametrosListaDeMuestras
                (sumaParticulasFotonicas(_listaDeMuestras),sumaHidrogenoIonizado(_listaDeMuestras),
                (sumaParticulasFotonicasAlCuadrado(_listaDeMuestras)),
                (sumaParticulasFotonicasPorHidrogenoIonizado(_listaDeMuestras)),
                sumaDeDistanciasAlCuadrado(_listaDeMuestras));
            return _nuevoParametro;
        }
        public Resultado calcularRectas()
        {

            
            List<ParametrosListaDeMuestras> _listaParametros=new List<ParametrosListaDeMuestras>();
            Muestras.ForEach(_listaDeMuestras=>_listaParametros.Add(cargarParametrosDeListaDeMuestras(_listaDeMuestras,
                resolverSistema(_listaDeMuestras.Count,))));

            double sumaX1 = sumaParticulasFotonicas(Muestras);
            double sumaY1 = sumaHidrogenoIonizado(Muestras);
            double sumaX1AlCuadrado1 = sumaParticulasFotonicasAlCuadrado(Muestras);
            double sumaMultiplicacionXY1 = sumaParticulasFotonicasPorHidrogenoIonizado(Muestras);
            double sumaX2 = sumaParticulasFotonicas(Muestras);
            /*Seguir con esto
             * 
             */
            double sumaY2 = sumaHidrogenoIonizado(muestra2);
            double sumaX2AlCuadrado2 = sumaParticulasFotonicasAlCuadrado(muestra2);
            double sumaMultiplicacionXY2 = sumaParticulasFotonicasPorHidrogenoIonizado(muestra2);
            Recta recta1 = 
            Recta recta2 = resolverSistema(muestra2.Count, sumaX2, sumaY2, sumaX2, sumaX2AlCuadrado2, sumaMultiplicacionXY2);
            double sumaDeDistanciasAlCuadrado1 = sumaDeDistanciasAlCuadrado(muestra1, recta1);
            double sumaDeDistanciasAlCuadrado2 = sumaDeDistanciasAlCuadrado(muestra2, recta2);
            return (new Resultado(muestra1, muestra2, recta1, recta2, sumaDeDistanciasAlCuadrado1, sumaDeDistanciasAlCuadrado2));
        }

    }
}
