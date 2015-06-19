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
            _grpIngreso.Enabled = false;
            //controlar que sean numeros ¿solo positivos?
            if(_dgvDatos.Columns.Count>_cmbCantTiposMuestra.SelectedIndex+1)
            {
                List<Muestra> _listaDeMuestras= new List<Muestra>();
                for (int i = 0; i < _dgvDatos.Columns.Count; i++)
                {
                    //agregar muestras a una lista de muestras
                    Muestra _nuevaMuestra = new Muestra(
                        Convert.ToDouble(_dgvDatos.Rows[0].Cells[i].Value),
                        Convert.ToDouble(_dgvDatos.Rows[1].Cells[i].Value));
                    _listaDeMuestras.Add(_nuevaMuestra);
                }
                Combinador _combinador = new Combinador();
                List<Muestra> _muestrasModelos=new List<Muestra>();
                int p= Convert.ToInt32(_cmbCantTiposMuestra.Text);
                int n=_listaDeMuestras.Count;
                for(int i=0;i*p<n;i++)
                {
                    _muestrasModelos.Add(_listaDeMuestras[0]);
                    _listaDeMuestras.RemoveAt(0);
                }
                //armo una lista de listas de muestras con las combinaciones
                //de la lista de muestras
                List<List<Muestra>> _listaDeListaDeMuestras =
                    _combinador.realizarCombinaciones(_listaDeMuestras,
                    Convert.ToInt32(_cmbCantTiposMuestra.Text));
                _listaDeListaDeMuestras.RemoveAll(_lista => _lista.Count <
                   p);
                _lblCombinacionesPosibles.Text += _listaDeListaDeMuestras.Count.ToString();
            }
            /*
            Muestra muestra = new Muestra(Convert.ToInt32
                (txt_particulasFotonicas.Text.ToString()),
                Convert.ToInt32(txt_hidrogenoIonizado.Text.ToString()));
            muestras.Add(muestra);
            txt_hidrogenoIonizado.Text = "";
            txt_particulasFotonicas.Text = "";
            if (tamanioMuestra - muestras.Count==0)
            {
                calcular();
            }
            else
            {
                MessageBox.Show(string.Format("Muestra guardada correctamente. Faltan ingresar {0} muestras.", tamanioMuestra-muestras.Count), "¡Éxito!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }  
             */
            _grpIngreso.Enabled = true;
        }

        private List<Combinacion> generarCombinaciones(List<Muestra> muestras, int paraElegir)
        {
            //ver si hay que tirar error si no cumple condicion
            List<Combinacion> combinaciones=new List<Combinacion>();



            return combinaciones;
        }

        private void calcular(){
            /*
            Muestra valor1Muestra1 = muestras[0];
            muestras.RemoveAt(0);
            Muestra valor1Muestra2 = muestras[0];
            muestras.RemoveAt(0);
            List<Combinacion> combinaciones= generarCombinaciones(muestras, 4);
            //a todas las combinaciones hay que agregarles el primer elemento
            foreach (Combinacion combinacion in combinaciones){
                combinacion.muestra1.Add(valor1Muestra1);
                combinacion.muestra2.Add(valor1Muestra2);
            }
            List<Resultado> resultados=combinaciones.Select(combinacion => combinacion.calcularRectas());
            resultados.Where(resultado => resultado.errorMenorALoIndicado());
            
            if (resultados.Count!=1)
            {
                MessageBox.Show("salió mal", "¡MAL!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Resultado resultadoFinal = resultados[0];
                MessageBox.Show(string.Format("MOSTRAR BIEN EL RESULTADO FINAL", tamanioMuestra-muestras.Count), "¡Éxito!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
             */
        }

        private void Form1_Load(object sender, EventArgs e)
        {

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

        }

    }
}
