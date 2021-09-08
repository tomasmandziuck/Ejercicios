using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Top3
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Dictionary<string, int> contadorPalabras = ObtenerContadorPalabras();

            List<KeyValuePair<string, int>> podio = contadorPalabras.ToList();

            podio.Sort(CompararCantidadRepeticiones);

            MostrarPodio(podio);


        }
        private void MostrarPodio(List<KeyValuePair<string,int>> podio)
        {
            StringBuilder sb = new StringBuilder();
            if (podio.Count==0)
            {
                sb.AppendLine("no se ingreso nada");

            }
            else
            {
                foreach (KeyValuePair<string, int> par in podio)
                {
                    sb.AppendLine($"Key: {par.Key} value: {par.Value}");
                }
            }
            
            MessageBox.Show(sb.ToString(),"Podio");
        }
        private int CompararCantidadRepeticiones(KeyValuePair<string,int> primerElemento, KeyValuePair<string,int> segundoElemento)
        {
            return segundoElemento.Value - primerElemento.Value;
        }
        private Dictionary<string,int> ObtenerContadorPalabras()
        {
            string texto = richTextBox1.Text;
            string[] palabras = texto.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            Dictionary<string, int> contador = new Dictionary<string, int>();

            foreach (string palabra in palabras)
            {
                if (contador.ContainsKey(palabra))
                {
                    contador[palabra]++;
                }
                else
                {
                    contador.Add(palabra, 1);
                }
            }

            return contador;
        }
    }
}
