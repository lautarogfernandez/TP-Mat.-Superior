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
        
        public Form1()
        {
            InitializeComponent();
            DataGridViewRow _fila=new DataGridViewRow();
            _fila.HeaderCell.Value="Hidrógeno Ionizado";
            _dgvDatos.Rows.Add(_fila);
            DataGridViewRow _fila2 = new DataGridViewRow();
            _fila2.HeaderCell.Value = "Particulas Fotónicas";
            _dgvDatos.Rows.Add(_fila2);
            _dgvDatos.RowHeadersWidthSizeMode=
                DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
        }

        private bool esPar(int numero)
        {
            return numero % 2 == 0;
        }
        private void b_ingresarValor_Click_1(object sender, EventArgs e)
        {            
            //controlar que sean numeros ¿solo positivos? .................................
            if (esPar(_dgvDatos.Columns.Count))
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


                Combinador _combinador = new Combinador();
                int n = _listaDeMuestras.Count;
                int p = Convert.ToInt32(Math.Truncate(Convert.ToDouble(_listaDeMuestras.Count/2)));

                //Armo una lista de listas de muestras con las combinaciones de la lista de muestras
                List<List<Muestra>> _listaDeListaDeMuestras = new List<List<Muestra>>();
                _listaDeListaDeMuestras = _combinador.realizarCombinaciones(_listaDeMuestras, p);
                //Creo error, primero
                double error = 0;
                bool primero = true;
                //Solucion parcial va a ser la mejor solución posible con el menor error
                List<List<Muestra>> solucionParcial = new List<List<Muestra>>();

                //Para cada lista de muestras en la lista de lista de muestras
                _listaDeListaDeMuestras.ForEach(delegate(List<Muestra> unaListaDeMuestras)
                {
                    //para cada otra lista de muestras en la lista de lista de muestras
                    _listaDeListaDeMuestras.ForEach(delegate(List<Muestra> otraListaDeMuestras)
                        {
                            //Si tienen todos los elementos diferentes

                            if (unaListaDeMuestras.TrueForAll(elemento =>
                                !otraListaDeMuestras.Exists(otroElemento => elemento == otroElemento)))
                            {
                                //Los agrego a otra lista de lista de muestras
                                List<List<Muestra>> listaDeListaDeMuestras = new List<List<Muestra>>();
                                listaDeListaDeMuestras.Add(unaListaDeMuestras);
                                listaDeListaDeMuestras.Add(otraListaDeMuestras);
                                //Trato de resolver el sistema
                                Combinacion _combinacion = new Combinacion(listaDeListaDeMuestras);
                                Resultado _resultado = _combinacion.calcularRectas();
                                //Si es la primera combinación probada
                                if(primero==true)
                                {
                                    //Para cada estructura de parametros de muestras
                                    _resultado._listaParametrosDeMuestras.ForEach(delegate(ParametrosListaDeMuestras unosParametros)
                                    {
                                        //Si es la primer estructura de parámentros de muestra
                                        if (primero == true)
                                        {
                                            //El error es igual al error del primero
                                            error= unosParametros._sumaDeDistanciasAlCuadrado;
                                            primero = false;
                                            //Es la nueva solución parcial
                                            solucionParcial.Add(unaListaDeMuestras);
                                            solucionParcial.Add(otraListaDeMuestras);
                                        }
                                        else
                                        {
                                            //Si el error es mayor, lo asigno a error
                                            if(unosParametros._sumaDeDistanciasAlCuadrado>error)
                                            {
                                                error = unosParametros._sumaDeDistanciasAlCuadrado;
                                            }
                                        }
                                    });
                                }
                                //Si el error del resultado es menor al error actual
                                if (_resultado.errorMenorALoIndicado(error))
                                {
                                    //Para cada estructura de parámetros del resultado
                                    error=_resultado._listaParametrosDeMuestras.Max
                                        (elemento => elemento._sumaDeDistanciasAlCuadrado);
                                    //Ésta pasa a ser la solución parcial
                                    solucionParcial.Clear();
                                    solucionParcial.Add(unaListaDeMuestras);
                                    solucionParcial.Add(otraListaDeMuestras);
                                }
                            }
                        });
                }
                );
                //Muestro la solución definitiva
                List<Muestra> primerLista = solucionParcial.ElementAt(0);
                List<Muestra> segundaLista = solucionParcial.ElementAt(1);
                Combinacion combinacionDefinitiva = new Combinacion(solucionParcial);
                Resultado resultadoDefinitivo = combinacionDefinitiva.calcularRectas();
                string cadenaExito = "Combinaciones: ";
                cadenaExito += "\nCombinacion 1: ";
                primerLista.ForEach(elemento => cadenaExito =
                    cadenaExito + string.Format("({0},{1}) ",
                    elemento.ParticulasFotonicas, elemento.HidrogenoIonizado));


                cadenaExito += string.Format("\nRecta Solucion:\nPendiente: {0}, Ordenada: {1}\n"
                    , combinacionDefinitiva._rectasSolucion[0].Pendiente, combinacionDefinitiva._rectasSolucion[0].Ordenada);

                cadenaExito += "\nCombinacion 2: ";
                segundaLista.ForEach(elemento => cadenaExito =
                    cadenaExito + string.Format("({0},{1}) ",
                    elemento.ParticulasFotonicas, elemento.HidrogenoIonizado));

                cadenaExito += string.Format("\nRecta Solucion:\nPendiente: {0}, Ordenada: {1}"
                    , combinacionDefinitiva._rectasSolucion[1].Pendiente, combinacionDefinitiva._rectasSolucion[1].Ordenada);

                cadenaExito += string.Format("\n \nSuma de distancias al cuadrado máxima: {0}", error);
                MessageBox.Show(cadenaExito,
                    "¡Exito!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            { 
                MessageBox.Show(string.Format("Debe ingresar una cantidad par de muestras."),
                    "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
