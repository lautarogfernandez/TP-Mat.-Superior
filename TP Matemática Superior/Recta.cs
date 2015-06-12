using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_Matemática_Superior
{
    class Recta
    {
        private double _pendiente, _ordenada;
        #region Getters and Setters
        public double Pendiente
        {
            get { return _pendiente; }
            set { _pendiente = value; }
        }
        public double Ordenada
        {
            get { return _ordenada; }
            set { _ordenada = value; }
        }
        #endregion
        public Recta(double pendiente, double ordenada)
        {
            Pendiente=pendiente;
            Ordenada=ordenada;
        }

        public double YPara(double x)
        {
            return (Pendiente * x + Ordenada);
        }

    }
}
