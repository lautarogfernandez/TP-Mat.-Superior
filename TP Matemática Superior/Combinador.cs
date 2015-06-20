using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_Matemática_Superior
{
    class Combinador
    {

        List<List<Muestra>> _combinacionesPosibles=new List<List<Muestra>>();
        List<Muestra> _combinacionActual=new List<Muestra>();
        public List<List<Muestra>> realizarCombinaciones(List<Muestra> _muestras, int p)
        {
            combinar(_muestras, p);
            return _combinacionesPosibles;
        }
        public void combinar(List<Muestra> _muestras, int p)
        {
            for (int i = 0; i < _muestras.Count &&p>0; i++)
            {
                _combinacionActual.Add(_muestras.ElementAt(i));
                List<Muestra> nuevaLista = new List<Muestra>();
                _muestras.ForEach(x=>nuevaLista.Add(x));
                nuevaLista.RemoveRange(0,i+1);
                combinar(nuevaLista, p - 1);
                List<Muestra> otraLista = new List<Muestra>();
                _combinacionActual.ForEach(x => otraLista.Add(x));
                if(otraLista.Count>p)_combinacionesPosibles.Add(otraLista);
                _combinacionActual.RemoveAt(_combinacionActual.Count - 1);
            }
        }

    }
}
