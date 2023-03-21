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
    public partial class ListadoProspecto : Form
    {
        ClsProspectos objProspectos = new ClsProspectos();
        EvaluacionProspecto evaluacionProspecto=new EvaluacionProspecto();
        public ListadoProspecto()
        {
            InitializeComponent();
        }

        private void dtgvProspectos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dtgvProspectos.SelectedRows.Count == 1) {
                Int32 idProspecto = Convert.ToInt32(dtgvProspectos.CurrentRow.Cells[0].Value);
               
                evaluacionProspecto.ShowDialog();
            }
        }
        public void listarProspectos() {
            dtgvProspectos.DataSource = objProspectos.ListarProspectos();
            
        }

        private void ListadoProspecto_Load(object sender, EventArgs e)
        {
            listarProspectos();
        }

        private void dtgvProspectos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dtgvProspectos.SelectedRows.Count == 1)
            {
                Int32 idProspecto = Convert.ToInt32(dtgvProspectos.CurrentRow.Cells[0].Value);
                evaluacionProspecto.identificador = idProspecto;
                evaluacionProspecto.ShowDialog();
            }

        }
    }
}
