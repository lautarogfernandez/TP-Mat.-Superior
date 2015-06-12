using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_Matemática_Superior
{
    class Muestra
    {
        public double particulasFotonicas, hidrogenoIonizado;

        public Muestra(double particulasFotonicas, double hidrogenoIonizado)
        {
            this.particulasFotonicas = particulasFotonicas;
            this.hidrogenoIonizado = hidrogenoIonizado;
        }

        public bool esIgual(Muestra otraMuestra)
        {
            return ((this.particulasFotonicas == otraMuestra.particulasFotonicas) && (this.hidrogenoIonizado == otraMuestra.hidrogenoIonizado));
        }

        public int distanciaAlcuadradoConRespectoA(Recta recta)
        {
            double valorDeYEnLARecta = recta.YPara(particulasFotonicas);
            double distancia = valorDeYEnLARecta - hidrogenoIonizado;
            return Math.Pow(distancia,2);
        }
        
    }
}
