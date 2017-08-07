using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using System.Data.SqlClient;
using System.Data.Sql;


namespace CRUD
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void btnDetNom_Click(object sender, EventArgs e)
        {
            frmDetalle_Nomina fr = new frmDetalle_Nomina();
            fr.Show();
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            frmEmpleado f = new frmEmpleado();
            f.Show();
        }

        private void btnBN_Click(object sender, EventArgs e)
        {
            frmBusqueda_Nomina fr = new frmBusqueda_Nomina();
            fr.Show();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Operacion oper = new Operacion();

            if (txtBuscar.Text.Length == 0)
            {

                DataTable dt = oper.ConsultaConResultado(" SELECT  * FROM empleado ");
                dataGridView1.DataSource = dt;
                return;
            }

            if (radioID.Checked == true)
            {
                DataTable dt = oper.ConsultaConResultado(" SELECT  * FROM empleado WHERE id_empleado='" + txtBuscar.Text.Trim() + "' ");
                dataGridView1.DataSource = dt;
                return;
            }

            if (radioNombre.Checked == true)
            {
                DataTable dt = oper.ConsultaConResultado(" SELECT  * FROM empleado WHERE nombre like '%" + txtBuscar.Text.Trim() + "%' ");
                dataGridView1.DataSource = dt;
                return;
            }

        }

        private void btnProbar_Click(object sender, EventArgs e)
        {
            Operacion oper = new Operacion();
            string resultado = oper.Conectar();
            MessageBox.Show(resultado);
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            Operacion oper = new Operacion();

            if (radioNombre.Checked == true)
            {
                DataTable dt = oper.ConsultaConResultado(" SELECT  * FROM empleado WHERE nombre like '%" + txtBuscar.Text.Trim() + "%' ");
                dataGridView1.DataSource = dt;
                return;
            }
        }

        private void btnVisor_Click(object sender, EventArgs e)
        {
            try
            {
                Operacion oper = new Operacion();
                DataSet ds = new DataSet();

                DataTable dt_empleado = oper.ConsultaConResultado("SELECT * FROM EMPLEADO");
                ds.Tables.Add(dt_empleado);
                ds.Tables[0].TableName = "EMPLEADO";

                DataTable dt_dNomina = oper.ConsultaConResultado("SELECT * FROM detalle_nomina");
                ds.Tables.Add(dt_dNomina);
                ds.Tables[1].TableName = "DETALLE_NOMINA";

                ds.WriteXml(@"C:\sistema\xml\empleado.xml");
                ds.WriteXml(@"C:\sistema\xml\DETALLE_NOMINA.xml");
                frmVisor fr = new frmVisor("CrystalReport1.rpt");
                fr.Show();
            }
            catch (Exception error)
            {

                MessageBox.Show(error.Message);
            }
        }
    }
}
