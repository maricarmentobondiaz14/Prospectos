using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CrudPromotores
{
    public partial class PantallaPrincipal : Form
    {
        PantallaProspecto pantProspecto;
        InicioSesion iniSesion;
        public PantallaPrincipal()
        {
            InitializeComponent();
            pantProspecto = new PantallaProspecto();
            iniSesion = new InicioSesion();
        }

        private void btnAgregarProspecto_Click(object sender, EventArgs e)
        {
            pantProspecto.ShowDialog();
        }

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            iniSesion.ShowDialog();

        }
    }
}
