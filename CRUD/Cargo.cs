using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Sql;
using System.Data.SQLite;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUD
{
    public partial class frmCargo : Form
    {
        public frmCargo()
        {
            InitializeComponent();
        }

        private void btnAgregarC_Click(object sender, EventArgs e)
        {
            //Esto es para agregar cargos a la tabla de cargo
            Operacion oper = new Operacion();
            oper.ConsultaSinResultado("INSERT INTO cargo(id_cargo) VALUES('" + txtID_C.Text + "')");
            txtID_C.Clear();
        }

        private void btnBuscarC_Click(object sender, EventArgs e)
        {
            Operacion oper = new Operacion();
            //Para buscar los cargos y mostrarlos en el DataGridView
            DataTable dt = oper.ConsultaConResultado(" SELECT * FROM cargo ");
            dataGridViewCargo.DataSource = dt;
            return;
        }

        private void btnBorrarC_Click(object sender, EventArgs e)
        {
            //borrar cargos especificando mediante su id
            Operacion oper = new Operacion();
            oper.ConsultaSinResultado("DELETE FROM cargo WHERE id_cargo= '" + txtID_C.Text + "'");
        }
    }
}
