using Base;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Principal
{
    public partial class Principal : FormBase
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void btInfo_Click(object sender, EventArgs e)
        {
            labelAvisos.Text = "FORMULARIO PRINCIPAL: Boton info sobreescrito";
        }
    }
}
