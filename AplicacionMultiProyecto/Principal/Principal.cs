using Base;
using System;
using System.Drawing;

namespace Principal
{
    public partial class Principal : FormBase
    {
        private const string DEFAULT_TXT = "FORMULARIO PRINCIPAL: Boton info sobreescrito";
        public Principal()
        {
            InitializeComponent();
        }

        private void btInfo_Click(object sender, EventArgs e)
        {
            labelAvisos.Text = "FORMULARIO PRINCIPAL: Boton info sobreescrito";
        }

        private void avisoRojo_Click(object sender, EventArgs e)
        {
            NotificarAvisoColor(DEFAULT_TXT + " ROJO", Color.Coral);
        }

        private void avisoVERDE_Click(object sender, EventArgs e)
        {
            NotificarAvisoColor(DEFAULT_TXT + " VERDE", Color.LightGreen);
        }

        private void avisoAMARILLO_Click(object sender, EventArgs e)
        {
            NotificarAvisoColor(DEFAULT_TXT + " AMARILLO", Color.LightYellow);
        }

        private void avisoNORMAL_Click(object sender, EventArgs e)
        {
            NotificarAvisoColor(DEFAULT_TXT + " GRIS", Color.LightGray);
        }
    }
}
