namespace CRUD
{
    partial class frmCargo
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
            this.dataGridViewCargo = new System.Windows.Forms.DataGridView();
            this.btnBuscarC = new System.Windows.Forms.Button();
            this.btnAgregarC = new System.Windows.Forms.Button();
            this.btnBorrarC = new System.Windows.Forms.Button();
            this.txtID_C = new System.Windows.Forms.TextBox();
            this.lblACargo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCargo)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewCargo
            // 
            this.dataGridViewCargo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCargo.Location = new System.Drawing.Point(46, 119);
            this.dataGridViewCargo.Name = "dataGridViewCargo";
            this.dataGridViewCargo.Size = new System.Drawing.Size(165, 150);
            this.dataGridViewCargo.TabIndex = 0;
            // 
            // btnBuscarC
            // 
            this.btnBuscarC.Location = new System.Drawing.Point(12, 77);
            this.btnBuscarC.Name = "btnBuscarC";
            this.btnBuscarC.Size = new System.Drawing.Size(240, 36);
            this.btnBuscarC.TabIndex = 2;
            this.btnBuscarC.Text = "Buscar";
            this.btnBuscarC.UseVisualStyleBackColor = true;
            this.btnBuscarC.Click += new System.EventHandler(this.btnBuscarC_Click);
            // 
            // btnAgregarC
            // 
            this.btnAgregarC.Location = new System.Drawing.Point(96, 37);
            this.btnAgregarC.Name = "btnAgregarC";
            this.btnAgregarC.Size = new System.Drawing.Size(75, 34);
            this.btnAgregarC.TabIndex = 5;
            this.btnAgregarC.Text = "Agregar";
            this.btnAgregarC.UseVisualStyleBackColor = true;
            this.btnAgregarC.Click += new System.EventHandler(this.btnAgregarC_Click);
            // 
            // btnBorrarC
            // 
            this.btnBorrarC.Location = new System.Drawing.Point(177, 37);
            this.btnBorrarC.Name = "btnBorrarC";
            this.btnBorrarC.Size = new System.Drawing.Size(75, 34);
            this.btnBorrarC.TabIndex = 8;
            this.btnBorrarC.Text = "Borrar";
            this.btnBorrarC.UseVisualStyleBackColor = true;
            this.btnBorrarC.Click += new System.EventHandler(this.btnBorrarC_Click);
            // 
            // txtID_C
            // 
            this.txtID_C.Location = new System.Drawing.Point(12, 45);
            this.txtID_C.Name = "txtID_C";
            this.txtID_C.Size = new System.Drawing.Size(78, 20);
            this.txtID_C.TabIndex = 9;
            // 
            // lblACargo
            // 
            this.lblACargo.AutoSize = true;
            this.lblACargo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblACargo.Location = new System.Drawing.Point(12, 9);
            this.lblACargo.Name = "lblACargo";
            this.lblACargo.Size = new System.Drawing.Size(114, 17);
            this.lblACargo.TabIndex = 10;
            this.lblACargo.Text = "Agregar Cargo";
            // 
            // frmCargo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(262, 281);
            this.Controls.Add(this.lblACargo);
            this.Controls.Add(this.txtID_C);
            this.Controls.Add(this.btnBorrarC);
            this.Controls.Add(this.btnAgregarC);
            this.Controls.Add(this.btnBuscarC);
            this.Controls.Add(this.dataGridViewCargo);
            this.MaximizeBox = false;
            this.Name = "frmCargo";
            this.Text = "Cargo";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCargo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewCargo;
        private System.Windows.Forms.Button btnBuscarC;
        private System.Windows.Forms.Button btnAgregarC;
        private System.Windows.Forms.Button btnBorrarC;
        private System.Windows.Forms.TextBox txtID_C;
        private System.Windows.Forms.Label lblACargo;
    }
}