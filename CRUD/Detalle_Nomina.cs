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
    public partial class frmDetalle_Nomina : Form
    {
        public frmDetalle_Nomina()
        {
            InitializeComponent();
        }

        private void btnCrearDN_Click(object sender, EventArgs e)
        {
            Operacion oper = new Operacion();//conexion a la base de datos

            try
            {
                //para insertar un cargo a la tabla de cargos en la base de datos
                oper.ConsultaSinResultado("INSERT INTO detalle_nomina(id_det, ISR, SS, otros, total_deducciones, sueldo_neto, fk_id_cargo) " +
                "VALUES('" + txtID_det.Text + "', '" + txt_ISR.Text + "', '" + txt_SS.Text + "', '" + txt_Otros.Text + "', " +
                "'" + txt_TD.Text + "', '" + txt_SN.Text + "', '" + cmbCargoDN.Text + "')");
                /*Con estas condiciones, a menos que no este todo lleno, no saltara el mensaje.*/
                if (txtID_det.Text == "")
                {
                    MessageBox.Show("Faltan datos.");
                }

                else if (txt_ISR.Text == "")
                {
                    MessageBox.Show("Faltan datos.");
                }

                else if (txt_SS.Text == "")
                {
                    MessageBox.Show("Faltan datos.");
                }

                else if (txt_Otros.Text == "")
                {
                    MessageBox.Show("Faltan datos.");
                }

                else if (txt_TD.Text == "")
                {
                    MessageBox.Show("Faltan datos.");
                }

                else if (txt_SN.Text == "")
                {
                    MessageBox.Show("Faltan datos.");
                }

                else if (cmbCargoDN.Text == "")
                {
                    MessageBox.Show("Faltan datos.");
                }

            }
            catch (Exception error)
            {//mostrara un mensaje de error
                MessageBox.Show(error.Message);
            }
            /*con este, al momento de crear un nuevo detalle de nomina 
            tendremos el formulario libre para agregar mas datos*/
            txtID_det.Clear();
            txt_Otros.Clear();
            txt_SN.Clear();
            txt_SS.Clear();
            txt_TD.Clear();
            txt_ISR.Clear();
        }

        private void btnVerDN_Click(object sender, EventArgs e)
        {
            //para mostrar los detalles de la nomina en los textBox
            if (txtID_det.Text == "")
            {
                MessageBox.Show("Inserte datos en ID");
            }

            Operacion oper = new Operacion();//conexion a la base de datos
            DataTable dtDN = oper.ConsultaConResultado("SELECT * FROM detalle_nomina WHERE id_det= '" + txtID_det.Text + "'");
            foreach (DataRow dr in dtDN.Rows)
            {
                string ID, ISR, SS, otros, total_deducciones, sueldo_neto, cargo;
                ID = dr["id_det"].ToString();
                ISR = dr["ISR"].ToString();
                SS = dr["SS"].ToString();
                otros = dr["otros"].ToString();
                total_deducciones = dr["total_deducciones"].ToString();
                sueldo_neto = dr["sueldo_neto"].ToString();
                cargo = dr["fk_id_cargo"].ToString();
                txtID_det.Text = ID;
                txt_ISR.Text = ISR;
                txt_SS.Text = SS;
                txt_Otros.Text = otros;
                txt_TD.Text = total_deducciones;
                txt_SN.Text = sueldo_neto;
                cmbCargoDN.Text = cargo;
            }
        }

        private void btnActualizarDN_Click(object sender, EventArgs e)
        {
            //este es para actualizar los datos ya existentes en la tabla detalle_nomina
            Operacion oper = new Operacion();
            oper.ConsultaSinResultado("UPDATE detalle_nomina SET ISR = '"+ txt_ISR.Text +"', SS = '"+ txt_SS.Text +"'," +
                " otros = '"+ txt_Otros.Text +"', total_deducciones = '"+ txt_TD.Text +"', sueldo_neto = '"+ txt_SN.Text +"'," +
                " fk_id_cargo = '"+ cmbCargoDN.Text +"' WHERE id_det = '" + txtID_det.Text + "'");
        }

        private void btnBorrarDN_Click(object sender, EventArgs e)
        {
            //este sirve para eliminar datos existentes en la tabla detalle_nomina
            Operacion oper = new Operacion();
            oper.ConsultaSinResultado("DELETE FROM detalle_nomina WHERE id_det='" + txtID_det.Text + "'");

            if (txtID_det.Text == "")
            {
                MessageBox.Show("Inserte datos en ID");
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            //sirve para limpiar el formulario
            txtID_det.Clear();
            txt_Otros.Clear();
            txt_SN.Clear();
            txt_SS.Clear();
            txt_TD.Clear();
            txt_ISR.Clear();
        }

        //private void txtID_empDN_TextChanged(object sender, EventArgs e)
        //{
        //    //esta se usara luego para relacionar el detalle de la nomina con el empleado
        //}
    }
}
