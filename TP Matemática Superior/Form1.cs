using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP_Matemática_Superior
{
    public partial class Form1 : Form
    {
        List<Muestra> muestras = new List<Muestra>();
        int tamanioMuestra = 10;
        double error = 0.9999;
        
        public Form1()
        {
            InitializeComponent();
            DataGridViewRow _fila=new DataGridViewRow();
            _fila.HeaderCell.Value="Particulas Fotónicas";
            _dgvDatos.Rows.Add(_fila);
            DataGridViewRow _fila2 = new DataGridViewRow();
            _fila2.HeaderCell.Value = "Hidrogeno Ionizado";
            _dgvDatos.Rows.Add(_fila2);
            _dgvDatos.RowHeadersWidthSizeMode=
                DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
        }

        private void b_ingresarValor_Click_1(object sender, EventArgs e)
        {            
            //controlar que sean numeros ¿solo positivos? .................................
            if (_dgvDatos.Columns.Count >= tamanioMuestra)
            {
                List<Muestra> _listaDeMuestras = new List<Muestra>();
                for (int i = 0; i < _dgvDatos.Columns.Count; i++)
                {
                    //agregar muestras a una lista de muestras
                    Muestra _nuevaMuestra = new Muestra(
                        Convert.ToDouble(_dgvDatos.Rows[0].Cells[i].Value),
                        Convert.ToDouble(_dgvDatos.Rows[1].Cells[i].Value));
                    _listaDeMuestras.Add(_nuevaMuestra);
                }

                //para probar con los valores, despues sacar .............................
                _listaDeMuestras.Clear();
                _listaDeMuestras.Add(new Muestra(118, 230));
                _listaDeMuestras.Add(new Muestra(123, 240));
                _listaDeMuestras.Add(new Muestra(132, 260));
                _listaDeMuestras.Add(new Muestra(148, 290));
                _listaDeMuestras.Add(new Muestra(150, 300));
                _listaDeMuestras.Add(new Muestra(178, 350));
                _listaDeMuestras.Add(new Muestra(184, 375));
                _listaDeMuestras.Add(new Muestra(198, 390));
                //para probar con los valores, despues sacar .............................

                Combinador _combinador = new Combinador();
                Muestra primerMuestraDeLaCombinacion1 = new Muestra(54, 100);
                Muestra primerMuestraDeLaCombinacion2 = new Muestra(83, 150);
                int n = _listaDeMuestras.Count;
                int p = 4;

                //Armo una lista de listas de muestras con las combinaciones de la lista de muestras
                List<List<Muestra>> _listaDeListaDeMuestras = new List<List<Muestra>>();
                _listaDeListaDeMuestras = _combinador.realizarCombinaciones(_listaDeMuestras, p);


                bool seEncontró=false;

                _listaDeListaDeMuestras.ForEach(delegate(List<Muestra> unaListaDeMuestras)
                {
                    _listaDeListaDeMuestras.ForEach(delegate(List<Muestra> otraListaDeMuestras)
                        {
                            if (unaListaDeMuestras.TrueForAll(elemento =>
                                !otraListaDeMuestras.Exists(otroElemento => elemento == otroElemento)))
                            {
                                unaListaDeMuestras.Add(primerMuestraDeLaCombinacion1);
                                otraListaDeMuestras.Add(primerMuestraDeLaCombinacion2);
                                List<List<Muestra>> listaDeListaDeMuestras = new List<List<Muestra>>();
                                listaDeListaDeMuestras.Add(unaListaDeMuestras);
                                listaDeListaDeMuestras.Add(otraListaDeMuestras);
                                Combinacion _combinacion = new Combinacion(listaDeListaDeMuestras);
                                Resultado _resultado = _combinacion.calcularRectas();
                                if (_resultado.errorMenorALoIndicado(error))
                                {
                                    string cadenaExito = "Combinaciones: ";
                                    cadenaExito += "\nCombinacion1: ";
                                    unaListaDeMuestras.ForEach(elemento => cadenaExito =
                                        cadenaExito + string.Format("({0},{1}) ",
                                        elemento.ParticulasFotonicas, elemento.HidrogenoIonizado));
                                    cadenaExito += "\nCombinacion2: ";
                                    otraListaDeMuestras.ForEach(elemento => cadenaExito =
                                        cadenaExito + string.Format("({0},{1}) ",
                                        elemento.ParticulasFotonicas, elemento.HidrogenoIonizado));
                                    MessageBox.Show(cadenaExito,
                                        "¡Exito!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                    seEncontró=true;
                                }
                                else
                                {
                                }

                            }
                        });
                }
                );
                if(seEncontró==false)
                {

                    MessageBox.Show("No se encontró la combinacion",
"¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                /*
                //Filtra las listas que tengan a la primera muestra y no a la segunda
                List<List<Muestra>> _listaDeListaDeMuestras2 = new List<List<Muestra>>();
                foreach(List<Muestra> lista in _listaDeListaDeMuestras)
                {
                    if((lista.Contains(primerMuestraDeLaCombinacion1) && (!lista.Contains(primerMuestraDeLaCombinacion2))))
                        _listaDeListaDeMuestras2.Add(lista);
                }
                
                //A partir de una lista de muestra, generea la complementaria. 
                List<Combinacion> combinacionesFinales= new List<Combinacion>();
                foreach (List<Muestra> lista in _listaDeListaDeMuestras2)
                {
                    List<Muestra> nuevaLista = new List<Muestra>();
                    foreach (Muestra item in _listaDeMuestras)
                    {
                           if(!(lista.Contains(item))) nuevaLista.Add(item);
                    }
                    List<List<Muestra>> listaCombinacion = new List<List<Muestra>>();
                    listaCombinacion.Add(lista);
                    listaCombinacion.Add(nuevaLista);
                    combinacionesFinales.Add(new Combinacion(listaCombinacion));
                }

                List<Resultado> resultados = new List<Resultado>();
                foreach (Combinacion comb in combinacionesFinales)
                {
                    resultados.Add(comb.calcularRectas());
                }

                List<Resultado> resultadoFinal = new List<Resultado>();                
                foreach (Resultado res in resultados)
                {
                    if (res.errorMenorALoIndicado(error)) resultadoFinal.Add(res);
                }

                if (resultadoFinal.Count()==1)
                {
                    Resultado final = resultadoFinal[0];
                    //mustrar resultados, puede ser una tabla o algo ..........................................................
                }
                else
                {
                    MessageBox.Show(string.Format("El método ha fallado."), "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);                    
                }
            }
            else
            {
                MessageBox.Show(string.Format("Debe ingresar 10 muestras en total."), "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }    
                 * 
                 */
            }

        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            int cantidadFilas=_dgvDatos.Columns.Count+1;
            DataGridViewColumn _columnaNueva = 
                new DataGridViewColumn(_dgvDatos.Columns[0].CellTemplate);
            _columnaNueva.Width = 40;
            _columnaNueva.Name="Columna"+cantidadFilas.ToString();
            _columnaNueva.HeaderText = cantidadFilas.ToString();

            _dgvDatos.Columns.Add(_columnaNueva);
        }

        private void _dgvDatos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //ver que va a ir aca. Si no va nada, sacalo................................................. 
        }

    }
}
