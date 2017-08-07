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
        {//muestra la ventana detalle de nomina
            frmDetalle_Nomina fr = new frmDetalle_Nomina();
            fr.Show();
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {//muestra la ventana de empleado
            frmEmpleado f = new frmEmpleado();
            f.Show();
        }

        private void btnBN_Click(object sender, EventArgs e)
        {//muestra la ventana de busqueda de nomina
            frmBusqueda_Nomina fr = new frmBusqueda_Nomina();
            fr.Show();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {//este boton de buscar es para mostrar la lista de empleados en el dataGridView de la ventana Form1

            Operacion oper = new Operacion(); //la conexion a la base de datos

            if (txtBuscar.Text.Length == 0)
            {
                //esta condicion sirve para que cuando el txtBuscar este vacio muestre todos los empleados en el dataGridView
                DataTable dt = oper.ConsultaConResultado(" SELECT  * FROM empleado ");
                dataGridView1.DataSource = dt;
                return;
            }

            if (radioID.Checked == true)
            {
                //esta condicion es para cuando el boton radioButton de id este chequeado, la busqueda se filtrara por ID
                DataTable dt = oper.ConsultaConResultado(" SELECT  * FROM empleado WHERE id_empleado='" + txtBuscar.Text.Trim() + "' ");
                dataGridView1.DataSource = dt;
                return;
            }

            if (radioNombre.Checked == true)
            {
                //esta condicion es para cuando el boton radioButton de nombre este chequeado, la busqueda se filtrara por nombre
                DataTable dt = oper.ConsultaConResultado(" SELECT  * FROM empleado WHERE nombre like '%" + txtBuscar.Text.Trim() + "%' ");
                dataGridView1.DataSource = dt;
                return;
            }

        }

        private void btnProbar_Click(object sender, EventArgs e)
        {//para probar si esta conectado a la base de datos
            Operacion oper = new Operacion();
            string resultado = oper.Conectar();
            MessageBox.Show(resultado);
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            Operacion oper = new Operacion();

            if (radioNombre.Checked == true)
            {/*esta condicion sirve para que cuando el radioButton de nombre este chequeado, 
                la lista de empleados se vaya cambiando en tiempo real dependiendo la letra que se ponga*/
                DataTable dt = oper.ConsultaConResultado(" SELECT  * FROM empleado WHERE nombre like '%" + txtBuscar.Text.Trim() + "%' ");
                dataGridView1.DataSource = dt;
                return;
            }
        }

        private void btnVisor_Click(object sender, EventArgs e)
        {
            try //manejador de errores
            {
                Operacion oper = new Operacion();
                DataSet ds = new DataSet();
                //para mostrar el reporte de los empleados en el crystalReportViewer
                DataTable dt_empleado = oper.ConsultaConResultado("SELECT * FROM EMPLEADO");
                ds.Tables.Add(dt_empleado);
                ds.Tables[0].TableName = "EMPLEADO";

                ds.WriteXml(@"C:\sistema\xml\empleado.xml");
                frmVisor fr = new frmVisor("CrystalReport1.rpt");
                fr.Show();
            }
            catch (Exception error)
            {
                //para mostrar un mensaje de error en caso de que suceda
                MessageBox.Show(error.Message);
            }
        }
    }
}
