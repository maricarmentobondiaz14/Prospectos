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
using CrudPromotores.Modelo;
using System;
namespace CrudPromotores
{
    public partial class PantallaProspecto : Form
    {
        ClsProspectos objProspectos = new ClsProspectos();
        List<string> urls = new List<string>();


        public PantallaProspecto()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            int status = 1;
            urls.Add(txtbUrl.Text);

            objProspectos.InsertaProspectos(
                txtbNombreProspecto.Text,
                txtbApellidoP.Text,
                txtbApellidoM.Text,
                txtbCalle.Text,
                txtbNumeroCasa.Text,
                txtbColonia.Text,
                Convert.ToInt32(txtbCodigoPostal.Text),
                txtbTelefono.Text,
                txtbRFC.Text,
                status,
                "",
                urls.ToArray());
            MessageBox.Show("Se inserto correctamente el prospecto. ");
            txtbNombreProspecto.Text = "";
            txtbApellidoP.Text = "";
            txtbApellidoM.Text = "";
            txtbCalle.Text = "";
            txtbNumeroCasa.Text = "";
            txtbColonia.Text = "";
            txtbCodigoPostal.Text = "";
            txtbTelefono.Text = "";
            txtbRFC.Text = "";
            
            this.Close();

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea salir de la aplicación",
                               "Salir",
                               MessageBoxButtons.YesNo,
                               MessageBoxIcon.Question,
                               MessageBoxDefaultButton.Button1) == DialogResult.Yes) {
                this.Close();
            }
                

        }

        private void btnOtroDocumento_Click(object sender, EventArgs e)
        {

            urls.Add(txtbUrl.Text);
            txtbUrl.Text = "";

        }
    }
}
