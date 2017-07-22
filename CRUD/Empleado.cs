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
    public partial class frmEmpleado : Form
    {
        public frmEmpleado()
        {
            InitializeComponent();
        }

        private void frmEmpleado_Load(object sender, EventArgs e)
        {
            txtNombre.Focus();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Operacion oper = new Operacion();
            oper.ConsultaSinResultado
                (" INSERT INTO empleado(nombre, apellido, sexo, fecha_nacimiento, fecha_ingreso, sueldo) " +
                "VALUES('"+ txtNombre.Text +"', '"+ txtApellido.Text +"','"+ txtSexo.Text +"', " +
                "'" + txtFN.Text + "', '" + txtFI.Text + "', '" + txtSalario.Text + "') ");

            txtID.Clear();
            txtNombre.Clear();
            txtApellido.Clear();
            txtSexo.Clear();
            txtNombre.Focus();
        }

        private void txtID_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtApellido_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSexo_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtFN_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtFI_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSalario_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {           

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnCrear_Click(object sender, EventArgs e)
        {

        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {

        }

        private void btnCEdad_Click(object sender, EventArgs e)
        {
            
        }

        private void btnCAnt_Click(object sender, EventArgs e)
        {

        }

        private void txtCEdad_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCAnt_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
