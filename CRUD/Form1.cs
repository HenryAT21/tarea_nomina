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

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            frmEmpleado f = new frmEmpleado();
            f.Show();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnProbar_Click(object sender, EventArgs e)
        {
            Operacion oper = new Operacion();
            string resultado = oper.Conectar();
            MessageBox.Show(resultado);
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void radioID_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioNombre_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
