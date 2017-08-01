namespace CRUD
{
    partial class frmEmpleado
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEmpleado));
            this.lblID = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.btnApellido = new System.Windows.Forms.Label();
            this.btnSexo = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.btnCrear = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.lblDGenerales = new System.Windows.Forms.Label();
            this.lblFN = new System.Windows.Forms.Label();
            this.lblFI = new System.Windows.Forms.Label();
            this.txtFN = new System.Windows.Forms.TextBox();
            this.txtFI = new System.Windows.Forms.TextBox();
            this.lblHeadSalario = new System.Windows.Forms.Label();
            this.lblSalario = new System.Windows.Forms.Label();
            this.txtSalario = new System.Windows.Forms.TextBox();
            this.lblCalculos = new System.Windows.Forms.Label();
            this.txtCEdad = new System.Windows.Forms.TextBox();
            this.txtCAnt = new System.Windows.Forms.TextBox();
            this.btnCEdad = new System.Windows.Forms.Button();
            this.btnCAnt = new System.Windows.Forms.Button();
            this.pictureBoxEmpleado = new System.Windows.Forms.PictureBox();
            this.cmbSexo = new System.Windows.Forms.ComboBox();
            this.lblCedula = new System.Windows.Forms.Label();
            this.txtCedula = new System.Windows.Forms.TextBox();
            this.lblPuesto = new System.Windows.Forms.Label();
            this.cmbPuesto = new System.Windows.Forms.ComboBox();
            this.btnCargos = new System.Windows.Forms.Button();
            this.btnLimparFormularioEmp = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEmpleado)).BeginInit();
            this.SuspendLayout();
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(356, 42);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(18, 13);
            this.lblID.TabIndex = 0;
            this.lblID.Text = "ID";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(5, 42);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "Nombre";
            // 
            // btnApellido
            // 
            this.btnApellido.AutoSize = true;
            this.btnApellido.Location = new System.Drawing.Point(5, 69);
            this.btnApellido.Name = "btnApellido";
            this.btnApellido.Size = new System.Drawing.Size(44, 13);
            this.btnApellido.TabIndex = 2;
            this.btnApellido.Text = "Apellido";
            // 
            // btnSexo
            // 
            this.btnSexo.AutoSize = true;
            this.btnSexo.Location = new System.Drawing.Point(5, 95);
            this.btnSexo.Name = "btnSexo";
            this.btnSexo.Size = new System.Drawing.Size(31, 13);
            this.btnSexo.TabIndex = 3;
            this.btnSexo.Text = "Sexo";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(380, 39);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(34, 20);
            this.txtID.TabIndex = 4;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(119, 39);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(153, 20);
            this.txtNombre.TabIndex = 5;
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(119, 66);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(153, 20);
            this.txtApellido.TabIndex = 6;
            // 
            // btnCrear
            // 
            this.btnCrear.Location = new System.Drawing.Point(11, 452);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(75, 23);
            this.btnCrear.TabIndex = 8;
            this.btnCrear.Text = "Crear";
            this.btnCrear.UseVisualStyleBackColor = true;
            this.btnCrear.Click += new System.EventHandler(this.btnCrear_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(173, 452);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(75, 23);
            this.btnActualizar.TabIndex = 9;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnBorrar
            // 
            this.btnBorrar.Location = new System.Drawing.Point(254, 452);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(75, 23);
            this.btnBorrar.TabIndex = 10;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // btnImprimir
            // 
            this.btnImprimir.Location = new System.Drawing.Point(92, 452);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(75, 23);
            this.btnImprimir.TabIndex = 11;
            this.btnImprimir.Text = "Imprimir";
            this.btnImprimir.UseVisualStyleBackColor = true;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // lblDGenerales
            // 
            this.lblDGenerales.AutoSize = true;
            this.lblDGenerales.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDGenerales.Location = new System.Drawing.Point(12, 9);
            this.lblDGenerales.Name = "lblDGenerales";
            this.lblDGenerales.Size = new System.Drawing.Size(130, 17);
            this.lblDGenerales.TabIndex = 12;
            this.lblDGenerales.Text = "Datos Generales";
            // 
            // lblFN
            // 
            this.lblFN.AutoSize = true;
            this.lblFN.Location = new System.Drawing.Point(5, 149);
            this.lblFN.Name = "lblFN";
            this.lblFN.Size = new System.Drawing.Size(108, 13);
            this.lblFN.TabIndex = 13;
            this.lblFN.Text = "Fecha de Nacimiento";
            // 
            // lblFI
            // 
            this.lblFI.AutoSize = true;
            this.lblFI.Location = new System.Drawing.Point(5, 179);
            this.lblFI.Name = "lblFI";
            this.lblFI.Size = new System.Drawing.Size(90, 13);
            this.lblFI.TabIndex = 14;
            this.lblFI.Text = "Fecha de Ingreso";
            // 
            // txtFN
            // 
            this.txtFN.Location = new System.Drawing.Point(119, 146);
            this.txtFN.Name = "txtFN";
            this.txtFN.Size = new System.Drawing.Size(71, 20);
            this.txtFN.TabIndex = 15;
            this.txtFN.Text = "2017-12-31";
            // 
            // txtFI
            // 
            this.txtFI.Location = new System.Drawing.Point(119, 176);
            this.txtFI.Name = "txtFI";
            this.txtFI.Size = new System.Drawing.Size(71, 20);
            this.txtFI.TabIndex = 16;
            this.txtFI.Text = "2017-12-31";
            // 
            // lblHeadSalario
            // 
            this.lblHeadSalario.AutoSize = true;
            this.lblHeadSalario.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeadSalario.Location = new System.Drawing.Point(12, 242);
            this.lblHeadSalario.Name = "lblHeadSalario";
            this.lblHeadSalario.Size = new System.Drawing.Size(59, 17);
            this.lblHeadSalario.TabIndex = 17;
            this.lblHeadSalario.Text = "Salario";
            // 
            // lblSalario
            // 
            this.lblSalario.AutoSize = true;
            this.lblSalario.Location = new System.Drawing.Point(71, 277);
            this.lblSalario.Name = "lblSalario";
            this.lblSalario.Size = new System.Drawing.Size(42, 13);
            this.lblSalario.TabIndex = 18;
            this.lblSalario.Text = "Salario:";
            // 
            // txtSalario
            // 
            this.txtSalario.Location = new System.Drawing.Point(119, 274);
            this.txtSalario.Name = "txtSalario";
            this.txtSalario.Size = new System.Drawing.Size(153, 20);
            this.txtSalario.TabIndex = 19;
            // 
            // lblCalculos
            // 
            this.lblCalculos.AutoSize = true;
            this.lblCalculos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCalculos.Location = new System.Drawing.Point(12, 319);
            this.lblCalculos.Name = "lblCalculos";
            this.lblCalculos.Size = new System.Drawing.Size(69, 17);
            this.lblCalculos.TabIndex = 20;
            this.lblCalculos.Text = "Cálculos";
            // 
            // txtCEdad
            // 
            this.txtCEdad.Location = new System.Drawing.Point(119, 347);
            this.txtCEdad.Name = "txtCEdad";
            this.txtCEdad.Size = new System.Drawing.Size(153, 20);
            this.txtCEdad.TabIndex = 21;
            // 
            // txtCAnt
            // 
            this.txtCAnt.Location = new System.Drawing.Point(119, 373);
            this.txtCAnt.Name = "txtCAnt";
            this.txtCAnt.Size = new System.Drawing.Size(153, 20);
            this.txtCAnt.TabIndex = 22;
            // 
            // btnCEdad
            // 
            this.btnCEdad.Location = new System.Drawing.Point(293, 345);
            this.btnCEdad.Name = "btnCEdad";
            this.btnCEdad.Size = new System.Drawing.Size(123, 23);
            this.btnCEdad.TabIndex = 23;
            this.btnCEdad.Text = "Calcular Edad";
            this.btnCEdad.UseVisualStyleBackColor = true;
            // 
            // btnCAnt
            // 
            this.btnCAnt.Location = new System.Drawing.Point(293, 371);
            this.btnCAnt.Name = "btnCAnt";
            this.btnCAnt.Size = new System.Drawing.Size(123, 23);
            this.btnCAnt.TabIndex = 24;
            this.btnCAnt.Text = "Calcular Antigüedad";
            this.btnCAnt.UseVisualStyleBackColor = true;
            // 
            // pictureBoxEmpleado
            // 
            this.pictureBoxEmpleado.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxEmpleado.Image")));
            this.pictureBoxEmpleado.Location = new System.Drawing.Point(359, 69);
            this.pictureBoxEmpleado.Name = "pictureBoxEmpleado";
            this.pictureBoxEmpleado.Size = new System.Drawing.Size(173, 190);
            this.pictureBoxEmpleado.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxEmpleado.TabIndex = 25;
            this.pictureBoxEmpleado.TabStop = false;
            // 
            // cmbSexo
            // 
            this.cmbSexo.FormattingEnabled = true;
            this.cmbSexo.Items.AddRange(new object[] {
            "M",
            "F"});
            this.cmbSexo.Location = new System.Drawing.Point(119, 92);
            this.cmbSexo.Name = "cmbSexo";
            this.cmbSexo.Size = new System.Drawing.Size(48, 21);
            this.cmbSexo.TabIndex = 26;
            // 
            // lblCedula
            // 
            this.lblCedula.AutoSize = true;
            this.lblCedula.Location = new System.Drawing.Point(5, 123);
            this.lblCedula.Name = "lblCedula";
            this.lblCedula.Size = new System.Drawing.Size(40, 13);
            this.lblCedula.TabIndex = 27;
            this.lblCedula.Text = "Cedula";
            // 
            // txtCedula
            // 
            this.txtCedula.Location = new System.Drawing.Point(119, 120);
            this.txtCedula.Name = "txtCedula";
            this.txtCedula.Size = new System.Drawing.Size(100, 20);
            this.txtCedula.TabIndex = 28;
            // 
            // lblPuesto
            // 
            this.lblPuesto.AutoSize = true;
            this.lblPuesto.Location = new System.Drawing.Point(5, 209);
            this.lblPuesto.Name = "lblPuesto";
            this.lblPuesto.Size = new System.Drawing.Size(40, 13);
            this.lblPuesto.TabIndex = 29;
            this.lblPuesto.Text = "Puesto";
            // 
            // cmbPuesto
            // 
            this.cmbPuesto.FormattingEnabled = true;
            this.cmbPuesto.Items.AddRange(new object[] {
            "gerente general",
            "contable",
            "secretaria",
            "auxiliar de cont.",
            "mecanico",
            "chofer",
            "enc. de almacen",
            "depemdiente",
            "cajera/o",
            "mensajero/a",
            "gerente de compras",
            "enc. de mantenimiento",
            "asistente del chofer"});
            this.cmbPuesto.Location = new System.Drawing.Point(119, 209);
            this.cmbPuesto.Name = "cmbPuesto";
            this.cmbPuesto.Size = new System.Drawing.Size(121, 21);
            this.cmbPuesto.TabIndex = 30;
            // 
            // btnCargos
            // 
            this.btnCargos.Location = new System.Drawing.Point(246, 207);
            this.btnCargos.Name = "btnCargos";
            this.btnCargos.Size = new System.Drawing.Size(75, 23);
            this.btnCargos.TabIndex = 31;
            this.btnCargos.Text = "Cargos";
            this.btnCargos.UseVisualStyleBackColor = true;
            this.btnCargos.Click += new System.EventHandler(this.btnCargos_Click);
            // 
            // btnLimparFormularioEmp
            // 
            this.btnLimparFormularioEmp.Location = new System.Drawing.Point(335, 452);
            this.btnLimparFormularioEmp.Name = "btnLimparFormularioEmp";
            this.btnLimparFormularioEmp.Size = new System.Drawing.Size(115, 23);
            this.btnLimparFormularioEmp.TabIndex = 32;
            this.btnLimparFormularioEmp.Text = "Limpiar Formulario";
            this.btnLimparFormularioEmp.UseVisualStyleBackColor = true;
            this.btnLimparFormularioEmp.Click += new System.EventHandler(this.btnLimparFormularioEmp_Click);
            // 
            // frmEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(544, 578);
            this.Controls.Add(this.btnLimparFormularioEmp);
            this.Controls.Add(this.btnCargos);
            this.Controls.Add(this.cmbPuesto);
            this.Controls.Add(this.lblPuesto);
            this.Controls.Add(this.txtCedula);
            this.Controls.Add(this.lblCedula);
            this.Controls.Add(this.cmbSexo);
            this.Controls.Add(this.pictureBoxEmpleado);
            this.Controls.Add(this.btnCAnt);
            this.Controls.Add(this.btnCEdad);
            this.Controls.Add(this.txtCAnt);
            this.Controls.Add(this.txtCEdad);
            this.Controls.Add(this.lblCalculos);
            this.Controls.Add(this.txtSalario);
            this.Controls.Add(this.lblSalario);
            this.Controls.Add(this.lblHeadSalario);
            this.Controls.Add(this.txtFI);
            this.Controls.Add(this.txtFN);
            this.Controls.Add(this.lblFI);
            this.Controls.Add(this.lblFN);
            this.Controls.Add(this.lblDGenerales);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.btnCrear);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.btnSexo);
            this.Controls.Add(this.btnApellido);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblID);
            this.MaximizeBox = false;
            this.Name = "frmEmpleado";
            this.Text = "Empleado";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.frmEmpleado_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEmpleado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label btnApellido;
        private System.Windows.Forms.Label btnSexo;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.Button btnCrear;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.Label lblDGenerales;
        private System.Windows.Forms.Label lblFN;
        private System.Windows.Forms.Label lblFI;
        private System.Windows.Forms.TextBox txtFN;
        private System.Windows.Forms.TextBox txtFI;
        private System.Windows.Forms.Label lblHeadSalario;
        private System.Windows.Forms.Label lblSalario;
        private System.Windows.Forms.TextBox txtSalario;
        private System.Windows.Forms.Label lblCalculos;
        private System.Windows.Forms.TextBox txtCEdad;
        private System.Windows.Forms.TextBox txtCAnt;
        private System.Windows.Forms.Button btnCEdad;
        private System.Windows.Forms.Button btnCAnt;
        private System.Windows.Forms.PictureBox pictureBoxEmpleado;
        private System.Windows.Forms.ComboBox cmbSexo;
        private System.Windows.Forms.Label lblCedula;
        private System.Windows.Forms.TextBox txtCedula;
        private System.Windows.Forms.Label lblPuesto;
        private System.Windows.Forms.ComboBox cmbPuesto;
        private System.Windows.Forms.Button btnCargos;
        private System.Windows.Forms.Button btnLimparFormularioEmp;
    }
}