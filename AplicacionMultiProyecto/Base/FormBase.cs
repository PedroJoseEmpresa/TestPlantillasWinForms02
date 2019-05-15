using System;
using System.Drawing;
using System.Windows.Forms;

namespace Base
{
    public partial class FormBase : Form
    {
        public FormBase()
        {
            InitializeComponent();
        }

        private void btSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btInfo_Click(object sender, EventArgs e)
        {
            labelAvisos.Text = " FORM BASE --> boton info";
        }


        protected void nuevoAvisoRojo(string texto)
        {
            labelAvisos.Text = texto;
            labelAvisos.BackColor = Color.Red;
        }

        protected void nuevoAvisoVerde(string texto)
        {
            labelAvisos.Text = texto;
            labelAvisos.BackColor = Color.Green;
        }

        protected void nuevoAvisoAmarillo(string texto)
        {
            labelAvisos.Text = texto;
            labelAvisos.BackColor = Color.Yellow;
        }

        protected void nuevoAvisoNormal(string texto)
        {
            labelAvisos.Text = texto;
            labelAvisos.BackColor = Control.DefaultBackColor;
        }


        protected void nuevoAvisoColor(string texto, Color pColor)
        {
            labelAvisos.Text = texto;
            labelAvisos.BackColor = pColor;
        }



    }
}
