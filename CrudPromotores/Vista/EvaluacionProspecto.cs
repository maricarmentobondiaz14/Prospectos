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
using CrudPromotores.ModeloM;

namespace CrudPromotores
{
    public partial class EvaluacionProspecto : Form
    {
        public int identificador;
        ClsProspectos objProspectos = new ClsProspectos();
        Prospecto prospecto = new Prospecto();
         
        public EvaluacionProspecto()
        {
            InitializeComponent();

        }
        

       
        

        

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            int status = 0;

            if (rBAutorizar.Checked) {
                status = 1;
            }
            if (rBRechazar.Checked) { 
                status = 2;
            }
            objProspectos.ActualizarStatusProspectos( identificador,status,
               txtbObservaciones.Text );
            this.Close();
        }

        private void EvaluacionProspecto_Load(object sender, EventArgs e)
        {
            List<string> urls1 = new List<string>();

            prospecto = objProspectos.RevisarLista(identificador);
            urls1 = objProspectos.RevisarListaDocumentos(identificador);
            txtbnombreProspecto.Text = prospecto.NombreP;
            txtbapellidoP.Text = prospecto.ApellidoP;
            txtbapellidoM.Text=prospecto.ApellidoM;
            txtbCalle.Text=prospecto.Calle;
            txtbNumeroCasa.Text=prospecto.NumeroCasa;
            txtbColonia.Text=prospecto.Colonia;
            txtbCodigoPostal.Text = prospecto.CodigoPostal.ToString();
            txtbTelefono.Text=prospecto.Telefono.ToString();
            txtbRFC.Text=prospecto.RFC;
            if (prospecto.Estatus == 1)
            {
                rBAutorizar.Checked = true;
            }
            else if (prospecto.Estatus == 2)
            {
                rBRechazar.Checked = true;

            }
            else {
                rBAutorizar.Checked=false;
                rBRechazar.Checked=false;   
            }
            txtbObservaciones.Text=prospecto.Observaciones;
           
            for (var i = 0; i < urls1.Count; i++)
            {

                TextBox txtAlmomento = new TextBox(); 
                txtAlmomento.Text = urls1[i];             

                this.Controls.Add(txtAlmomento);
            }

        }
    }
}
