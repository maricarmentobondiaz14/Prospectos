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
    public partial class VistaPromotor : Form
    {
        AgregarPromotores agrPromotores;
        EvaluacionProspecto Eprospecto;
        ListadoProspecto listadoProspecto;

        public VistaPromotor()
        {
            InitializeComponent();
            agrPromotores = new AgregarPromotores();
            Eprospecto = new EvaluacionProspecto();
            listadoProspecto = new ListadoProspecto();
        }

        private void btnEvaluacionProspecto_Click(object sender, EventArgs e)
        {
            listadoProspecto.ShowDialog();
        }

        private void btnAgregarPromotor_Click(object sender, EventArgs e)
        {
            agrPromotores.ShowDialog();
            
        }
    }
}
