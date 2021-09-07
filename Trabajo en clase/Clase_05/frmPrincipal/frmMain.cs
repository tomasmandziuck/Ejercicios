using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;


namespace frmPrincipal
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /* DialogResult result = MessageBox.Show("Hacer formulario?","titulo",MessageBoxButtons.YesNoCancel,MessageBoxIcon.Hand);
              if (result== DialogResult.Yes)
              {
                  ///MessageBox.Show("ok");
                 /// frmNoMain form = new frmNoMain();
                  /// form.ShowDialog();
                  this.Close();

              }
            MessageBox.Show($"Nombre:{ txtNombre.Text} Edad: {nudEdad.Value.ToString()}");
            */
            Persona persona = new Persona(txtNombre.Text , nudEdad.Value);
            MessageBox.Show(persona.mostrar());

            foreach (Control item in Controls)
            {
                if (item is CheckBox && ((CheckBox)item).CheckState==CheckState.Indeterminate)
                {
                    MessageBox.Show("indeterminado");
                }

            }

        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
