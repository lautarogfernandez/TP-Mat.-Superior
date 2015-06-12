using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_Matemática_Superior
{
    class Recta
    {
        public double pendiente, ordenada;

        public Recta(double pendiente, double ordenada)
        {
            this.pendiente=pendiente;
            this.ordenada=ordenada;
        }

        public double YPara(double x)
        {
            return (pendiente * x + ordenada);
        }

    }
}
