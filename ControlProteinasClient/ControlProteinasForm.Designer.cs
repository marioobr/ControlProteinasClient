namespace ControlProteinasClient
{
    partial class ControlProteinasForm
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.cmbSelect = new System.Windows.Forms.ComboBox();
            this.lblSelect = new System.Windows.Forms.Label();
            this.gpbSuma = new System.Windows.Forms.GroupBox();
            this.lblMetaCount = new System.Windows.Forms.Label();
            this.lblTotalCount = new System.Windows.Forms.Label();
            this.lblMeta = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.btnAgregarProteina = new System.Windows.Forms.Button();
            this.txtBoxAgregar = new System.Windows.Forms.TextBox();
            this.lblAgregar = new System.Windows.Forms.Label();
            this.gpbAgregar = new System.Windows.Forms.GroupBox();
            this.btnAgregarUsuario = new System.Windows.Forms.Button();
            this.txtMeta = new System.Windows.Forms.TextBox();
            this.lblMetaUsuario = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.gpbSuma.SuspendLayout();
            this.gpbAgregar.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbSelect
            // 
            this.cmbSelect.FormattingEnabled = true;
            this.cmbSelect.Location = new System.Drawing.Point(12, 49);
            this.cmbSelect.Name = "cmbSelect";
            this.cmbSelect.Size = new System.Drawing.Size(174, 24);
            this.cmbSelect.TabIndex = 0;
            this.cmbSelect.SelectedIndexChanged += new System.EventHandler(this.OnUserChanged);
            // 
            // lblSelect
            // 
            this.lblSelect.AutoSize = true;
            this.lblSelect.Location = new System.Drawing.Point(13, 26);
            this.lblSelect.Name = "lblSelect";
            this.lblSelect.Size = new System.Drawing.Size(148, 17);
            this.lblSelect.TabIndex = 1;
            this.lblSelect.Text = "Seleccione un usuario";
            // 
            // gpbSuma
            // 
            this.gpbSuma.Controls.Add(this.lblMetaCount);
            this.gpbSuma.Controls.Add(this.lblTotalCount);
            this.gpbSuma.Controls.Add(this.lblMeta);
            this.gpbSuma.Controls.Add(this.lblTotal);
            this.gpbSuma.Controls.Add(this.btnAgregarProteina);
            this.gpbSuma.Controls.Add(this.txtBoxAgregar);
            this.gpbSuma.Controls.Add(this.lblAgregar);
            this.gpbSuma.Location = new System.Drawing.Point(316, 95);
            this.gpbSuma.Name = "gpbSuma";
            this.gpbSuma.Size = new System.Drawing.Size(295, 206);
            this.gpbSuma.TabIndex = 2;
            this.gpbSuma.TabStop = false;
            this.gpbSuma.Text = "Suma proteina";
            // 
            // lblMetaCount
            // 
            this.lblMetaCount.AutoSize = true;
            this.lblMetaCount.Location = new System.Drawing.Point(74, 154);
            this.lblMetaCount.Name = "lblMetaCount";
            this.lblMetaCount.Size = new System.Drawing.Size(16, 17);
            this.lblMetaCount.TabIndex = 6;
            this.lblMetaCount.Text = "0";
            // 
            // lblTotalCount
            // 
            this.lblTotalCount.AutoSize = true;
            this.lblTotalCount.Location = new System.Drawing.Point(74, 121);
            this.lblTotalCount.Name = "lblTotalCount";
            this.lblTotalCount.Size = new System.Drawing.Size(16, 17);
            this.lblTotalCount.TabIndex = 5;
            this.lblTotalCount.Text = "0";
            // 
            // lblMeta
            // 
            this.lblMeta.AutoSize = true;
            this.lblMeta.Location = new System.Drawing.Point(10, 154);
            this.lblMeta.Name = "lblMeta";
            this.lblMeta.Size = new System.Drawing.Size(43, 17);
            this.lblMeta.TabIndex = 4;
            this.lblMeta.Text = "Meta:";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(10, 121);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(44, 17);
            this.lblTotal.TabIndex = 3;
            this.lblTotal.Text = "Total:";
            // 
            // btnAgregarProteina
            // 
            this.btnAgregarProteina.Location = new System.Drawing.Point(10, 66);
            this.btnAgregarProteina.Name = "btnAgregarProteina";
            this.btnAgregarProteina.Size = new System.Drawing.Size(105, 37);
            this.btnAgregarProteina.TabIndex = 2;
            this.btnAgregarProteina.Text = "Agregar";
            this.btnAgregarProteina.UseVisualStyleBackColor = true;
            this.btnAgregarProteina.Click += new System.EventHandler(this.OnAddProtein);
            // 
            // txtBoxAgregar
            // 
            this.txtBoxAgregar.Location = new System.Drawing.Point(77, 31);
            this.txtBoxAgregar.Name = "txtBoxAgregar";
            this.txtBoxAgregar.Size = new System.Drawing.Size(186, 22);
            this.txtBoxAgregar.TabIndex = 1;
            // 
            // lblAgregar
            // 
            this.lblAgregar.AutoSize = true;
            this.lblAgregar.Location = new System.Drawing.Point(7, 31);
            this.lblAgregar.Name = "lblAgregar";
            this.lblAgregar.Size = new System.Drawing.Size(63, 17);
            this.lblAgregar.TabIndex = 0;
            this.lblAgregar.Text = "Agregar:";
            // 
            // gpbAgregar
            // 
            this.gpbAgregar.Controls.Add(this.btnAgregarUsuario);
            this.gpbAgregar.Controls.Add(this.txtMeta);
            this.gpbAgregar.Controls.Add(this.lblMetaUsuario);
            this.gpbAgregar.Controls.Add(this.txtNombre);
            this.gpbAgregar.Controls.Add(this.lblNombre);
            this.gpbAgregar.Location = new System.Drawing.Point(12, 126);
            this.gpbAgregar.Name = "gpbAgregar";
            this.gpbAgregar.Size = new System.Drawing.Size(295, 175);
            this.gpbAgregar.TabIndex = 7;
            this.gpbAgregar.TabStop = false;
            this.gpbAgregar.Text = "Agregar usuario nuevo";
            // 
            // btnAgregarUsuario
            // 
            this.btnAgregarUsuario.Location = new System.Drawing.Point(4, 123);
            this.btnAgregarUsuario.Name = "btnAgregarUsuario";
            this.btnAgregarUsuario.Size = new System.Drawing.Size(105, 37);
            this.btnAgregarUsuario.TabIndex = 5;
            this.btnAgregarUsuario.Text = "Agregar";
            this.btnAgregarUsuario.UseVisualStyleBackColor = true;
            this.btnAgregarUsuario.Click += new System.EventHandler(this.btnAgregarUsuario_Click);
            // 
            // txtMeta
            // 
            this.txtMeta.Location = new System.Drawing.Point(74, 85);
            this.txtMeta.Name = "txtMeta";
            this.txtMeta.Size = new System.Drawing.Size(186, 22);
            this.txtMeta.TabIndex = 4;
            // 
            // lblMetaUsuario
            // 
            this.lblMetaUsuario.AutoSize = true;
            this.lblMetaUsuario.Location = new System.Drawing.Point(6, 85);
            this.lblMetaUsuario.Name = "lblMetaUsuario";
            this.lblMetaUsuario.Size = new System.Drawing.Size(43, 17);
            this.lblMetaUsuario.TabIndex = 3;
            this.lblMetaUsuario.Text = "Meta:";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(74, 36);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(186, 22);
            this.txtNombre.TabIndex = 2;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(6, 36);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(62, 17);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "Nombre:";
            // 
            // ControlProteinasForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(623, 332);
            this.Controls.Add(this.gpbAgregar);
            this.Controls.Add(this.gpbSuma);
            this.Controls.Add(this.lblSelect);
            this.Controls.Add(this.cmbSelect);
            this.Name = "ControlProteinasForm";
            this.Text = "ControlProteinasForm";
            this.Load += new System.EventHandler(this.OnLoad);
            this.gpbSuma.ResumeLayout(false);
            this.gpbSuma.PerformLayout();
            this.gpbAgregar.ResumeLayout(false);
            this.gpbAgregar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbSelect;
        private System.Windows.Forms.Label lblSelect;
        private System.Windows.Forms.GroupBox gpbSuma;
        private System.Windows.Forms.Label lblMetaCount;
        private System.Windows.Forms.Label lblTotalCount;
        private System.Windows.Forms.Label lblMeta;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Button btnAgregarProteina;
        private System.Windows.Forms.TextBox txtBoxAgregar;
        private System.Windows.Forms.Label lblAgregar;
        private System.Windows.Forms.GroupBox gpbAgregar;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Button btnAgregarUsuario;
        private System.Windows.Forms.TextBox txtMeta;
        private System.Windows.Forms.Label lblMetaUsuario;
        private System.Windows.Forms.TextBox txtNombre;
    }
}

