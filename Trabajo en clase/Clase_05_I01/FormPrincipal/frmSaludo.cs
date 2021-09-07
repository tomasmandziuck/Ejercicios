using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormPrincipal
{
    public partial class frmSaludo : Form
    {
        public frmSaludo(string titulo, string mensaje)
        {
            InitializeComponent();

            lblMensaje.Text = mensaje;
            lblTitulo.Text = titulo;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
