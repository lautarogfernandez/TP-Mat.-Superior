using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_Matemática_Superior
{
    class Muestra
    {
        private double _particulasFotonicas, _hidrogenoIonizado;
        #region Getters and Setters
        public double ParticulasFotonicas
        {
            get { return _particulasFotonicas; }
            set { _particulasFotonicas = value; }
        }
        public double HidrogenoIonizado 
        {
            get { return _hidrogenoIonizado;}
            set { _hidrogenoIonizado = value; }
        }
        #endregion
        public Muestra(double particulasFotonicas, double hidrogenoIonizado)
        {
            ParticulasFotonicas = particulasFotonicas;
            HidrogenoIonizado = hidrogenoIonizado;
        }

        public bool esIgual(Muestra otraMuestra)
        {
            return ((ParticulasFotonicas == otraMuestra.ParticulasFotonicas) && (HidrogenoIonizado == otraMuestra.HidrogenoIonizado));
        }

        public double distanciaAlcuadradoConRespectoA(Recta recta)
        {
            double valorDeYEnLARecta = recta.YPara(ParticulasFotonicas);
            double distancia = valorDeYEnLARecta - HidrogenoIonizado;
            return Math.Pow(distancia,2);
        }
        
    }
}
