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


        protected void NotificarAvisoColor(string texto, Color pColor)
        {
            labelAvisos.Text = texto;
            labelAvisos.BackColor = pColor;
        }



    }
}
