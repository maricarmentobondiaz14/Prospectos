using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrudPromotores.Modelo;


namespace CrudPromotores
{
    public partial class AgregarPromotores : Form
    {
        ClsPromotores objPromotores = new ClsPromotores();
        public AgregarPromotores()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            objPromotores.InsertarPromotores(
                txtbNombrePromotor.Text,
                txtbUsuario.Text,
                txtbPassword.Text,
                txtbPuesto.Text,
                txtbRFC.Text,
                txtbTelefono.Text,
                txtbCorreo.Text);
            MessageBox.Show("Se inserto correctamente el promotor. ");
            this.Close();
        }
    }
}
