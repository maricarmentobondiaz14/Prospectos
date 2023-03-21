using CrudPromotores.Modelo;
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
    public partial class InicioSesion : Form
    {
        ClsPromotores objPromotores = new ClsPromotores();
        AgregarPromotores agrPromotores;
        VistaPromotor vistaPromotor;

        public InicioSesion()
        {
            InitializeComponent();
            agrPromotores = new AgregarPromotores();
            vistaPromotor = new VistaPromotor();
        }

        private void btnInicioSesion_Click(object sender, EventArgs e)
        {
            bool bandera = false;
            bandera=objPromotores.ExistePromotor(txtbUsuario.Text, txtbPassword.Text);
            if (bandera == true)
            {
                vistaPromotor.ShowDialog();
                this.Close();
            }
            else if(bandera == false) {
                MessageBox.Show("El usuario u contraseña no coinciden o no existen","Revisar la información", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
