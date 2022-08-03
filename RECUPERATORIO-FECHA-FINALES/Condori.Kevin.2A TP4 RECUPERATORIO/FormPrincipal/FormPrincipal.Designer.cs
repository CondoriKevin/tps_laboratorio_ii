
namespace FormPrincipal
{
    partial class FrmPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.Label lblTela;
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblCliente = new System.Windows.Forms.Label();
            this.lblMaquina = new System.Windows.Forms.Label();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.lblCalidadTela = new System.Windows.Forms.Label();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.Maquina = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tela = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtgvView = new System.Windows.Forms.DataGridView();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnExportar = new System.Windows.Forms.Button();
            this.cmbMaquina = new System.Windows.Forms.ComboBox();
            this.cmbTela = new System.Windows.Forms.ComboBox();
            this.cmbCalidadTela = new System.Windows.Forms.ComboBox();
            this.btnOkEditar = new System.Windows.Forms.Button();
            this.lblFiltroVer = new System.Windows.Forms.Label();
            this.cmbFiltroTabla = new System.Windows.Forms.ComboBox();
            this.btnVerTelas = new System.Windows.Forms.Button();
            this.rchInfoTemporal = new System.Windows.Forms.RichTextBox();
            this.lblInforme = new System.Windows.Forms.Label();
            this.cmbCliente = new System.Windows.Forms.ComboBox();
            lblTela = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvView)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTela
            // 
            lblTela.AutoSize = true;
            lblTela.Location = new System.Drawing.Point(52, 151);
            lblTela.Name = "lblTela";
            lblTela.Size = new System.Drawing.Size(27, 15);
            lblTela.TabIndex = 3;
            lblTela.Text = "Tela";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Location = new System.Drawing.Point(286, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(114, 15);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Confeccion de Ropa";
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Location = new System.Drawing.Point(52, 64);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(44, 15);
            this.lblCliente.TabIndex = 1;
            this.lblCliente.Text = "Cliente";
            // 
            // lblMaquina
            // 
            this.lblMaquina.AutoSize = true;
            this.lblMaquina.Location = new System.Drawing.Point(52, 106);
            this.lblMaquina.Name = "lblMaquina";
            this.lblMaquina.Size = new System.Drawing.Size(54, 15);
            this.lblMaquina.TabIndex = 2;
            this.lblMaquina.Text = "Maquina";
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Location = new System.Drawing.Point(52, 196);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(55, 15);
            this.lblCantidad.TabIndex = 4;
            this.lblCantidad.Text = "Cantidad";
            // 
            // lblCalidadTela
            // 
            this.lblCalidadTela.AutoSize = true;
            this.lblCalidadTela.Location = new System.Drawing.Point(52, 248);
            this.lblCalidadTela.Name = "lblCalidadTela";
            this.lblCalidadTela.Size = new System.Drawing.Size(70, 15);
            this.lblCalidadTela.TabIndex = 5;
            this.lblCalidadTela.Text = "Calidad Tela";
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(140, 188);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(125, 23);
            this.txtCantidad.TabIndex = 9;
            this.txtCantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCantidad_KeyPress);
            // 
            // Maquina
            // 
            this.Maquina.HeaderText = "Maquina";
            this.Maquina.Name = "Maquina";
            // 
            // Tela
            // 
            this.Tela.HeaderText = "Tela";
            this.Tela.Name = "Tela";
            // 
            // Cliente
            // 
            this.Cliente.HeaderText = "Cliente";
            this.Cliente.Name = "Cliente";
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            // 
            // dtgvView
            // 
            this.dtgvView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvView.Location = new System.Drawing.Point(287, 60);
            this.dtgvView.Name = "dtgvView";
            this.dtgvView.Size = new System.Drawing.Size(657, 203);
            this.dtgvView.TabIndex = 11;
            this.dtgvView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvView_CellClick);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(52, 289);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(213, 82);
            this.btnAgregar.TabIndex = 12;
            this.btnAgregar.Text = "Agregar Trabajo";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(286, 289);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(213, 38);
            this.btnEliminar.TabIndex = 13;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(616, 289);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(213, 38);
            this.btnEditar.TabIndex = 14;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnExportar
            // 
            this.btnExportar.Location = new System.Drawing.Point(505, 289);
            this.btnExportar.Name = "btnExportar";
            this.btnExportar.Size = new System.Drawing.Size(105, 38);
            this.btnExportar.TabIndex = 15;
            this.btnExportar.Text = "XML-TXT";
            this.btnExportar.UseVisualStyleBackColor = true;
            this.btnExportar.Click += new System.EventHandler(this.btnExportar_Click);
            // 
            // cmbMaquina
            // 
            this.cmbMaquina.FormattingEnabled = true;
            this.cmbMaquina.Location = new System.Drawing.Point(140, 98);
            this.cmbMaquina.Name = "cmbMaquina";
            this.cmbMaquina.Size = new System.Drawing.Size(125, 23);
            this.cmbMaquina.TabIndex = 16;
            this.cmbMaquina.SelectedIndexChanged += new System.EventHandler(this.cmbMaquina_SelectedIndexChanged);
            // 
            // cmbTela
            // 
            this.cmbTela.FormattingEnabled = true;
            this.cmbTela.Location = new System.Drawing.Point(140, 143);
            this.cmbTela.Name = "cmbTela";
            this.cmbTela.Size = new System.Drawing.Size(125, 23);
            this.cmbTela.TabIndex = 17;
            // 
            // cmbCalidadTela
            // 
            this.cmbCalidadTela.FormattingEnabled = true;
            this.cmbCalidadTela.Location = new System.Drawing.Point(140, 240);
            this.cmbCalidadTela.Name = "cmbCalidadTela";
            this.cmbCalidadTela.Size = new System.Drawing.Size(125, 23);
            this.cmbCalidadTela.TabIndex = 18;
            // 
            // btnOkEditar
            // 
            this.btnOkEditar.Location = new System.Drawing.Point(616, 333);
            this.btnOkEditar.Name = "btnOkEditar";
            this.btnOkEditar.Size = new System.Drawing.Size(213, 38);
            this.btnOkEditar.TabIndex = 19;
            this.btnOkEditar.Text = "OkEditar";
            this.btnOkEditar.UseVisualStyleBackColor = true;
            this.btnOkEditar.Click += new System.EventHandler(this.btnOkEditar_Click);
            // 
            // lblFiltroVer
            // 
            this.lblFiltroVer.AutoSize = true;
            this.lblFiltroVer.Location = new System.Drawing.Point(961, 98);
            this.lblFiltroVer.Name = "lblFiltroVer";
            this.lblFiltroVer.Size = new System.Drawing.Size(70, 15);
            this.lblFiltroVer.TabIndex = 20;
            this.lblFiltroVer.Text = "Filtrar Tabla:";
            // 
            // cmbFiltroTabla
            // 
            this.cmbFiltroTabla.FormattingEnabled = true;
            this.cmbFiltroTabla.Location = new System.Drawing.Point(969, 136);
            this.cmbFiltroTabla.Name = "cmbFiltroTabla";
            this.cmbFiltroTabla.Size = new System.Drawing.Size(123, 23);
            this.cmbFiltroTabla.TabIndex = 21;
            // 
            // btnVerTelas
            // 
            this.btnVerTelas.Location = new System.Drawing.Point(973, 186);
            this.btnVerTelas.Name = "btnVerTelas";
            this.btnVerTelas.Size = new System.Drawing.Size(118, 77);
            this.btnVerTelas.TabIndex = 22;
            this.btnVerTelas.Text = "Ver Telas";
            this.btnVerTelas.UseVisualStyleBackColor = true;
            this.btnVerTelas.Click += new System.EventHandler(this.btnVerTelas_Click);
            // 
            // rchInfoTemporal
            // 
            this.rchInfoTemporal.Location = new System.Drawing.Point(1121, 60);
            this.rchInfoTemporal.Name = "rchInfoTemporal";
            this.rchInfoTemporal.Size = new System.Drawing.Size(379, 276);
            this.rchInfoTemporal.TabIndex = 23;
            this.rchInfoTemporal.Text = "";
            // 
            // lblInforme
            // 
            this.lblInforme.AutoSize = true;
            this.lblInforme.Location = new System.Drawing.Point(1121, 18);
            this.lblInforme.Name = "lblInforme";
            this.lblInforme.Size = new System.Drawing.Size(123, 15);
            this.lblInforme.TabIndex = 24;
            this.lblInforme.Text = "Actualizacion Informe";
            this.lblInforme.Click += new System.EventHandler(this.lblInforme_Click);
            // 
            // cmbCliente
            // 
            this.cmbCliente.FormattingEnabled = true;
            this.cmbCliente.Location = new System.Drawing.Point(140, 56);
            this.cmbCliente.Name = "cmbCliente";
            this.cmbCliente.Size = new System.Drawing.Size(125, 23);
            this.cmbCliente.TabIndex = 25;
            this.cmbCliente.SelectedIndexChanged += new System.EventHandler(this.cmbCliente_SelectedIndexChanged);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OliveDrab;
            this.ClientSize = new System.Drawing.Size(1514, 382);
            this.Controls.Add(this.cmbCliente);
            this.Controls.Add(this.lblInforme);
            this.Controls.Add(this.rchInfoTemporal);
            this.Controls.Add(this.btnVerTelas);
            this.Controls.Add(this.cmbFiltroTabla);
            this.Controls.Add(this.lblFiltroVer);
            this.Controls.Add(this.btnOkEditar);
            this.Controls.Add(this.cmbCalidadTela);
            this.Controls.Add(this.cmbTela);
            this.Controls.Add(this.cmbMaquina);
            this.Controls.Add(this.btnExportar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.dtgvView);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.lblCalidadTela);
            this.Controls.Add(this.lblCantidad);
            this.Controls.Add(lblTela);
            this.Controls.Add(this.lblMaquina);
            this.Controls.Add(this.lblCliente);
            this.Controls.Add(this.lblTitulo);
            this.Name = "FrmPrincipal";
            this.Text = "Condori.Kevin.2A TP3 (RECUPERATORIO)";
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.Label lblMaquina;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.Label lblCalidadTela;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Maquina;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tela;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridView dtgvView;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnExportar;
        private System.Windows.Forms.ComboBox cmbMaquina;
        private System.Windows.Forms.ComboBox cmbTela;
        private System.Windows.Forms.ComboBox cmbCalidadTela;
        private System.Windows.Forms.Button btnOkEditar;
        private System.Windows.Forms.Label lblFiltroVer;
        private System.Windows.Forms.ComboBox cmbFiltroTabla;
        private System.Windows.Forms.Button btnVerTelas;
        private System.Windows.Forms.RichTextBox rchInfoTemporal;
        private System.Windows.Forms.Label lblInforme;
        private System.Windows.Forms.ComboBox cmbCliente;
    }
}

