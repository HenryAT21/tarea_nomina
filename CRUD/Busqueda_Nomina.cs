using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUD
{
    public partial class frmBusqueda_Nomina : Form
    {
        public frmBusqueda_Nomina()
        {
            InitializeComponent();
        }

        private void btnBuscarNomina_Click(object sender, EventArgs e)
        {
            //buscar la nomina por cargo
            Operacion oper = new Operacion();
            DataTable dt = oper.ConsultaConResultado("SELECT * FROM detalle_nomina WHERE fk_id_cargo= '" + cmbBuscarNomina.Text + "'");
            dataGridViewBN.DataSource = dt;
        }

        private void btnDetalleN_Click(object sender, EventArgs e)
        {
            frmDetalle_Nomina fr = new frmDetalle_Nomina();
            fr.Show();
        }
    }
}
