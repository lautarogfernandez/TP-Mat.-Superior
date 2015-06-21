using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_Matemática_Superior
{
    public class Resultado
    {
        public List<ParametrosListaDeMuestras> _listaParametrosDeMuestras;
        public Combinacion _combinacion;

        public Resultado(Combinacion comb,List<ParametrosListaDeMuestras> _listaParametros)
        {
            _combinacion = comb;
            _listaParametrosDeMuestras = _listaParametros;
        }

        public bool errorMenorALoIndicado(double errorMinimo)
        {
            return (_listaParametrosDeMuestras.TrueForAll(parametrosDeMuestra=>
                parametrosDeMuestra._sumaDeDistanciasAlCuadrado<=errorMinimo));
        }

    }
}
