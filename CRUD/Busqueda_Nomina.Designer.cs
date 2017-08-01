namespace CRUD
{
    partial class frmBusqueda_Nomina
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
            this.dataGridViewBN = new System.Windows.Forms.DataGridView();
            this.lblBuscarNomina = new System.Windows.Forms.Label();
            this.btnBuscarNomina = new System.Windows.Forms.Button();
            this.cmbBuscarNomina = new System.Windows.Forms.ComboBox();
            this.btnDetalleN = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBN)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewBN
            // 
            this.dataGridViewBN.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBN.Location = new System.Drawing.Point(176, 13);
            this.dataGridViewBN.Name = "dataGridViewBN";
            this.dataGridViewBN.Size = new System.Drawing.Size(743, 150);
            this.dataGridViewBN.TabIndex = 0;
            // 
            // lblBuscarNomina
            // 
            this.lblBuscarNomina.AutoSize = true;
            this.lblBuscarNomina.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuscarNomina.Location = new System.Drawing.Point(13, 13);
            this.lblBuscarNomina.Name = "lblBuscarNomina";
            this.lblBuscarNomina.Size = new System.Drawing.Size(117, 17);
            this.lblBuscarNomina.TabIndex = 1;
            this.lblBuscarNomina.Text = "Buscar Nomina";
            // 
            // btnBuscarNomina
            // 
            this.btnBuscarNomina.Location = new System.Drawing.Point(34, 33);
            this.btnBuscarNomina.Name = "btnBuscarNomina";
            this.btnBuscarNomina.Size = new System.Drawing.Size(82, 30);
            this.btnBuscarNomina.TabIndex = 2;
            this.btnBuscarNomina.Text = "Buscar";
            this.btnBuscarNomina.UseVisualStyleBackColor = true;
            this.btnBuscarNomina.Click += new System.EventHandler(this.btnBuscarNomina_Click);
            // 
            // cmbBuscarNomina
            // 
            this.cmbBuscarNomina.FormattingEnabled = true;
            this.cmbBuscarNomina.Items.AddRange(new object[] {
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
            this.cmbBuscarNomina.Location = new System.Drawing.Point(13, 77);
            this.cmbBuscarNomina.Name = "cmbBuscarNomina";
            this.cmbBuscarNomina.Size = new System.Drawing.Size(121, 21);
            this.cmbBuscarNomina.TabIndex = 3;
            // 
            // btnDetalleN
            // 
            this.btnDetalleN.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnDetalleN.Location = new System.Drawing.Point(16, 118);
            this.btnDetalleN.Name = "btnDetalleN";
            this.btnDetalleN.Size = new System.Drawing.Size(114, 30);
            this.btnDetalleN.TabIndex = 4;
            this.btnDetalleN.Text = "Detalle de Nomina";
            this.btnDetalleN.UseVisualStyleBackColor = true;
            this.btnDetalleN.Click += new System.EventHandler(this.btnDetalleN_Click);
            // 
            // frmBusqueda_Nomina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(931, 177);
            this.Controls.Add(this.btnDetalleN);
            this.Controls.Add(this.cmbBuscarNomina);
            this.Controls.Add(this.btnBuscarNomina);
            this.Controls.Add(this.lblBuscarNomina);
            this.Controls.Add(this.dataGridViewBN);
            this.MaximizeBox = false;
            this.Name = "frmBusqueda_Nomina";
            this.Text = "Busqueda Nomina";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBN)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewBN;
        private System.Windows.Forms.Label lblBuscarNomina;
        private System.Windows.Forms.Button btnBuscarNomina;
        private System.Windows.Forms.ComboBox cmbBuscarNomina;
        private System.Windows.Forms.Button btnDetalleN;
    }
}