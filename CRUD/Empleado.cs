using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;
using System.Data.SQLite;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace CRUD
{
    public partial class frmEmpleado : Form
    {
        public frmEmpleado()
        {
            InitializeComponent();
        }

        private void frmEmpleado_Load(object sender, EventArgs e)
        {
            
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            Operacion oper = new Operacion();//conexion a la base de datos
            //para agregar los datos de un empleado a la base de datos
            oper.ConsultaSinResultado
                (" INSERT INTO empleado(id_empleado, nombre, apellido, sexo, cedula, fecha_nacimiento, fecha_ingreso, fk_id_cargo, sueldo) " +
                "VALUES('" + txtID.Text + "', '" + txtNombre.Text + "', '" + txtApellido.Text + "','" + cmbSexo.Text + "', '" + txtCedula.Text + "', " +
                "'" + txtFN.Text + "', '" + txtFI.Text + "', '" + cmbPuesto.Text + "', '" + txtSalario.Text + "') ");
            //una vez agregados, estos codigos limpian el formulario para seguir trabajando
            txtID.Clear();
            txtNombre.Clear();
            txtApellido.Clear();
            txtSalario.Clear();
            txtCedula.Clear();
            txtNombre.Focus();
        }

        private void btnLimparFormularioEmp_Click(object sender, EventArgs e)
        {//este boton sirve para limpiar el formulario manualmente
            txtID.Clear();
            txtNombre.Clear();
            txtApellido.Clear();
            txtSalario.Clear();
            txtCedula.Clear();
            txtNombre.Focus();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            Operacion oper = new Operacion();//conexion a la base de datos
            //para actualizar los datos de un empleado seleccionado
            oper.ConsultaSinResultado("UPDATE empleado SET id_empleado = '"+ txtID.Text +"', nombre = '"+ txtNombre.Text +"', apellido = '"+ txtApellido.Text +"', " +
                "sexo = '"+ cmbSexo.Text +"', cedula = '"+ txtCedula.Text +"', fecha_nacimiento = '"+ txtFN.Text +"', fecha_ingreso = '"+ txtFI.Text +"', " +
                "fk_id_cargo = '"+ cmbPuesto.Text +"' WHERE id_empleado = '" + txtID.Text + "'");
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {   
            Operacion oper = new Operacion();//conexion a la base de datos
            //estos codigos son para poner los datos de un empleado en su respectivo textBox
            DataTable dtEmpleado = oper.ConsultaConResultado("SELECT * FROM empleado WHERE id_empleado= '" + txtID.Text + "'");
            foreach (DataRow dr in dtEmpleado.Rows)
            {
                string ID_empleado, nombre, apellido, sexo, cedula, FN, FI, puesto, salario;
                ID_empleado = dr["id_empleado"].ToString();
                nombre = dr["nombre"].ToString();
                apellido = dr["apellido"].ToString();
                sexo = dr["sexo"].ToString();
                cedula = dr["cedula"].ToString();
                FN = dr["fecha_nacimiento"].ToString();
                FI = dr["fecha_ingreso"].ToString();
                puesto = dr["fk_id_cargo"].ToString();
                salario = dr["sueldo"].ToString();
                txtNombre.Text = nombre;
                txtApellido.Text = apellido;
                txtID.Text = ID_empleado;
                cmbSexo.Text = sexo;
                txtCedula.Text = cedula;
                txtFN.Text = FN;
                txtFI.Text = FI;
                cmbPuesto.Text = puesto;
                txtSalario.Text = salario;
            }

            if (txtID.Text.Length == 0)
            {//esta condicion lanzara un mensaje en caso de que no se haya puesto ningun ID como filtro de busqueda
                MessageBox.Show("Inserte un numero en ID");
            }
            try //manejador de errores
            {//esta linea permite mostrar la foto de un empleado en caso de que exista...
                pictureBoxEmpleado.Image = Image.FromFile(@"C:\sistema\Imagenes\" + txtID.Text + ".jpg");
            }
            catch (Exception error)
            {//...si no existe, este catch mostrara un mensaje diciendo que la imagen no existe
                MessageBox.Show("La foto " + txtID.Text + ".jpg no existe en " + error.Message);
            }
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {//este boton es para eliminar los datos de un empleado
            Operacion oper = new Operacion();//conexion a la base de datos
            try //manejador de errores
            {//esta consulta intentara eliminar los datos del empleado filtrado por el ID
                oper.ConsultaSinResultado("DELETE FROM empleado WHERE id_empleado =" + txtID.Text + "");
            }
            catch (SQLiteException error)
            {//este catch mostrara un mensaje de error en caso de que exista en el proceso de eliminacion
                MessageBox.Show("Ha ocurrido un error. " + error.Message);
            }
        }

        private void btnCargos_Click(object sender, EventArgs e)
        {//muestra la ventana de los cargos
            frmCargo fr = new frmCargo();
            fr.Show();
        }
    }
}
