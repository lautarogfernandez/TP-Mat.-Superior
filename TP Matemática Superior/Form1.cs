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

        }

        private void b_ingresarValor_Click_1(object sender, EventArgs e)
        {
            //controlar que sean numeros ¿solo positivos?
            Muestra muestra = new Muestra(Convert.ToInt32(txt_particulasFotonicas.Text.ToString()), Convert.ToInt32(txt_hidrogenoIonizado.Text.ToString()));
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
        }

        private List<Combinacion> generarCombinaciones(List<Muestra> muestras, int paraElegir)
        {
            //ver si hay que tirar error si no cumple condicion
            List<Combinacion> combinaciones=new List<Combinacion>();



            return combinaciones;
        }

        private void calcular(){
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
        }

    }
}
