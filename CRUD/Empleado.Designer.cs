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
            this.lblID = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.btnApellido = new System.Windows.Forms.Label();
            this.btnSexo = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtSexo = new System.Windows.Forms.TextBox();
            this.btnCrear = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
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
            this.SuspendLayout();
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(5, 15);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(18, 13);
            this.lblID.TabIndex = 0;
            this.lblID.Text = "ID";
            this.lblID.Visible = false;
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
            this.txtID.Location = new System.Drawing.Point(119, 12);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(153, 20);
            this.txtID.TabIndex = 4;
            this.txtID.Visible = false;
            this.txtID.TextChanged += new System.EventHandler(this.txtID_TextChanged);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(119, 39);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(153, 20);
            this.txtNombre.TabIndex = 5;
            this.txtNombre.TextChanged += new System.EventHandler(this.txtNombre_TextChanged);
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(119, 66);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(153, 20);
            this.txtApellido.TabIndex = 6;
            this.txtApellido.TextChanged += new System.EventHandler(this.txtApellido_TextChanged);
            // 
            // txtSexo
            // 
            this.txtSexo.Location = new System.Drawing.Point(119, 92);
            this.txtSexo.Name = "txtSexo";
            this.txtSexo.Size = new System.Drawing.Size(153, 20);
            this.txtSexo.TabIndex = 7;
            this.txtSexo.Text = "M";
            this.txtSexo.TextChanged += new System.EventHandler(this.txtSexo_TextChanged);
            // 
            // btnCrear
            // 
            this.btnCrear.Location = new System.Drawing.Point(15, 532);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(75, 23);
            this.btnCrear.TabIndex = 8;
            this.btnCrear.Text = "Crear";
            this.btnCrear.UseVisualStyleBackColor = true;
            this.btnCrear.Click += new System.EventHandler(this.btnCrear_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(96, 532);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 9;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnBorrar
            // 
            this.btnBorrar.Location = new System.Drawing.Point(177, 532);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(75, 23);
            this.btnBorrar.TabIndex = 10;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(258, 532);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(75, 23);
            this.btnCerrar.TabIndex = 11;
            this.btnCerrar.Text = "Imprimir";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // lblDGenerales
            // 
            this.lblDGenerales.AutoSize = true;
            this.lblDGenerales.Location = new System.Drawing.Point(12, 9);
            this.lblDGenerales.Name = "lblDGenerales";
            this.lblDGenerales.Size = new System.Drawing.Size(86, 13);
            this.lblDGenerales.TabIndex = 12;
            this.lblDGenerales.Text = "Datos Generales";
            this.lblDGenerales.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblFN
            // 
            this.lblFN.AutoSize = true;
            this.lblFN.Location = new System.Drawing.Point(5, 124);
            this.lblFN.Name = "lblFN";
            this.lblFN.Size = new System.Drawing.Size(108, 13);
            this.lblFN.TabIndex = 13;
            this.lblFN.Text = "Fecha de Nacimiento";
            // 
            // lblFI
            // 
            this.lblFI.AutoSize = true;
            this.lblFI.Location = new System.Drawing.Point(5, 154);
            this.lblFI.Name = "lblFI";
            this.lblFI.Size = new System.Drawing.Size(90, 13);
            this.lblFI.TabIndex = 14;
            this.lblFI.Text = "Fecha de Ingreso";
            // 
            // txtFN
            // 
            this.txtFN.Location = new System.Drawing.Point(119, 121);
            this.txtFN.Name = "txtFN";
            this.txtFN.Size = new System.Drawing.Size(153, 20);
            this.txtFN.TabIndex = 15;
            this.txtFN.Text = "31/12/2017";
            this.txtFN.TextChanged += new System.EventHandler(this.txtFN_TextChanged);
            // 
            // txtFI
            // 
            this.txtFI.Location = new System.Drawing.Point(119, 151);
            this.txtFI.Name = "txtFI";
            this.txtFI.Size = new System.Drawing.Size(153, 20);
            this.txtFI.TabIndex = 16;
            this.txtFI.Text = "31/12/2017";
            this.txtFI.TextChanged += new System.EventHandler(this.txtFI_TextChanged);
            // 
            // lblHeadSalario
            // 
            this.lblHeadSalario.AutoSize = true;
            this.lblHeadSalario.Location = new System.Drawing.Point(12, 207);
            this.lblHeadSalario.Name = "lblHeadSalario";
            this.lblHeadSalario.Size = new System.Drawing.Size(39, 13);
            this.lblHeadSalario.TabIndex = 17;
            this.lblHeadSalario.Text = "Salario";
            // 
            // lblSalario
            // 
            this.lblSalario.AutoSize = true;
            this.lblSalario.Location = new System.Drawing.Point(71, 242);
            this.lblSalario.Name = "lblSalario";
            this.lblSalario.Size = new System.Drawing.Size(42, 13);
            this.lblSalario.TabIndex = 18;
            this.lblSalario.Text = "Salario:";
            // 
            // txtSalario
            // 
            this.txtSalario.Location = new System.Drawing.Point(119, 239);
            this.txtSalario.Name = "txtSalario";
            this.txtSalario.Size = new System.Drawing.Size(153, 20);
            this.txtSalario.TabIndex = 19;
            this.txtSalario.Text = "RD$";
            this.txtSalario.TextChanged += new System.EventHandler(this.txtSalario_TextChanged);
            // 
            // lblCalculos
            // 
            this.lblCalculos.AutoSize = true;
            this.lblCalculos.Location = new System.Drawing.Point(12, 319);
            this.lblCalculos.Name = "lblCalculos";
            this.lblCalculos.Size = new System.Drawing.Size(47, 13);
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
            // frmEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 567);
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
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnCrear);
            this.Controls.Add(this.txtSexo);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.btnSexo);
            this.Controls.Add(this.btnApellido);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblID);
            this.Name = "frmEmpleado";
            this.Text = "Empleado";
            this.Load += new System.EventHandler(this.frmEmpleado_Load);
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
        private System.Windows.Forms.TextBox txtSexo;
        private System.Windows.Forms.Button btnCrear;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.Button btnCerrar;
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
    }
}