
namespace Heladeria.FronEnd.Helado
{
    partial class frm_ABM_Helado
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_ABM_Helado));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgr_Helados = new System.Windows.Forms.DataGridView();
            this.cod_helado = new System.Windows.Forms.DataGridViewLinkColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewLinkColumn();
            this.descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipo_helado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidad_stock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.borrado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_3Puntos = new System.Windows.Forms.Button();
            this.lbl_Patron = new System.Windows.Forms.Label();
            this.btn_Buscar = new System.Windows.Forms.Button();
            this.txt_Patron = new System.Windows.Forms.TextBox();
            this.lbl_Tipo = new System.Windows.Forms.Label();
            this.cmb_TipoHelado = new Heladeria.Clases.ComboBox01();
            this.heladoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bD3K6G05_2022DataSet = new Heladeria.BD3K6G05_2022DataSet();
            this.lbl_ABM = new System.Windows.Forms.Label();
            this.btn_Salir = new System.Windows.Forms.Button();
            this.btn_Baja = new System.Windows.Forms.Button();
            this.btn_Modificar = new System.Windows.Forms.Button();
            this.btn_Alta = new System.Windows.Forms.Button();
            this.heladoTableAdapter = new Heladeria.BD3K6G05_2022DataSetTableAdapters.HeladoTableAdapter();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgr_Helados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.heladoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bD3K6G05_2022DataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dgr_Helados);
            this.groupBox1.Controls.Add(this.btn_3Puntos);
            this.groupBox1.Controls.Add(this.lbl_Patron);
            this.groupBox1.Controls.Add(this.btn_Buscar);
            this.groupBox1.Controls.Add(this.txt_Patron);
            this.groupBox1.Controls.Add(this.lbl_Tipo);
            this.groupBox1.Controls.Add(this.cmb_TipoHelado);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(79, 92);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(659, 321);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtros";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(592, 277);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 18);
            this.label2.TabIndex = 21;
            this.label2.Text = "X";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(445, 277);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 18);
            this.label1.TabIndex = 20;
            this.label1.Text = "Cantidad de registros:";
            // 
            // dgr_Helados
            // 
            this.dgr_Helados.AllowUserToAddRows = false;
            this.dgr_Helados.AllowUserToDeleteRows = false;
            this.dgr_Helados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgr_Helados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cod_helado,
            this.Nombre,
            this.descripcion,
            this.tipo_helado,
            this.cantidad_stock,
            this.borrado});
            this.dgr_Helados.Location = new System.Drawing.Point(6, 124);
            this.dgr_Helados.Name = "dgr_Helados";
            this.dgr_Helados.ReadOnly = true;
            this.dgr_Helados.Size = new System.Drawing.Size(644, 150);
            this.dgr_Helados.TabIndex = 16;
            this.dgr_Helados.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgr_Usuarios_CellContentClick);
            // 
            // cod_helado
            // 
            this.cod_helado.HeaderText = "ID";
            this.cod_helado.Name = "cod_helado";
            this.cod_helado.ReadOnly = true;
            this.cod_helado.Visible = false;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            // 
            // descripcion
            // 
            this.descripcion.HeaderText = "Descripción";
            this.descripcion.Name = "descripcion";
            this.descripcion.ReadOnly = true;
            // 
            // tipo_helado
            // 
            this.tipo_helado.HeaderText = "Tipo de Helado";
            this.tipo_helado.Name = "tipo_helado";
            this.tipo_helado.ReadOnly = true;
            // 
            // cantidad_stock
            // 
            this.cantidad_stock.HeaderText = "Stock (Kg)";
            this.cantidad_stock.Name = "cantidad_stock";
            this.cantidad_stock.ReadOnly = true;
            // 
            // borrado
            // 
            this.borrado.HeaderText = "Borrado";
            this.borrado.Name = "borrado";
            this.borrado.ReadOnly = true;
            this.borrado.Visible = false;
            // 
            // btn_3Puntos
            // 
            this.btn_3Puntos.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_3Puntos.Location = new System.Drawing.Point(211, 63);
            this.btn_3Puntos.Name = "btn_3Puntos";
            this.btn_3Puntos.Size = new System.Drawing.Size(39, 30);
            this.btn_3Puntos.TabIndex = 2;
            this.btn_3Puntos.Text = "...";
            this.btn_3Puntos.UseVisualStyleBackColor = true;
            this.btn_3Puntos.Click += new System.EventHandler(this.btn_3Puntos_Click);
            // 
            // lbl_Patron
            // 
            this.lbl_Patron.AutoSize = true;
            this.lbl_Patron.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Patron.Location = new System.Drawing.Point(6, 29);
            this.lbl_Patron.Name = "lbl_Patron";
            this.lbl_Patron.Size = new System.Drawing.Size(59, 18);
            this.lbl_Patron.TabIndex = 3;
            this.lbl_Patron.Text = "Buscar:";
            // 
            // btn_Buscar
            // 
            this.btn_Buscar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Buscar.BackgroundImage")));
            this.btn_Buscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Buscar.Location = new System.Drawing.Point(272, 27);
            this.btn_Buscar.Name = "btn_Buscar";
            this.btn_Buscar.Size = new System.Drawing.Size(71, 66);
            this.btn_Buscar.TabIndex = 3;
            this.btn_Buscar.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_Buscar.UseVisualStyleBackColor = true;
            this.btn_Buscar.Click += new System.EventHandler(this.btn_Buscar_Click);
            // 
            // txt_Patron
            // 
            this.txt_Patron.Location = new System.Drawing.Point(84, 29);
            this.txt_Patron.Name = "txt_Patron";
            this.txt_Patron.Size = new System.Drawing.Size(121, 24);
            this.txt_Patron.TabIndex = 0;
            // 
            // lbl_Tipo
            // 
            this.lbl_Tipo.AutoSize = true;
            this.lbl_Tipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Tipo.Location = new System.Drawing.Point(6, 63);
            this.lbl_Tipo.Name = "lbl_Tipo";
            this.lbl_Tipo.Size = new System.Drawing.Size(41, 18);
            this.lbl_Tipo.TabIndex = 4;
            this.lbl_Tipo.Text = "Tipo:";
            this.lbl_Tipo.Click += new System.EventHandler(this.lbl_Perfiles_Click);
            // 
            // cmb_TipoHelado
            // 
            this.cmb_TipoHelado.FormattingEnabled = true;
            this.cmb_TipoHelado.Location = new System.Drawing.Point(84, 64);
            this.cmb_TipoHelado.Name = "cmb_TipoHelado";
            this.cmb_TipoHelado.Pp_ConSeleccion = true;
            this.cmb_TipoHelado.Pp_descripcion = "nombre";
            this.cmb_TipoHelado.Pp_MensajeError = null;
            this.cmb_TipoHelado.Pp_Pk = "cod_tipo";
            this.cmb_TipoHelado.Pp_tabla = "Tipo_Helado";
            this.cmb_TipoHelado.Size = new System.Drawing.Size(121, 26);
            this.cmb_TipoHelado.TabIndex = 1;
            this.cmb_TipoHelado.SelectedIndexChanged += new System.EventHandler(this.cmb_Perfil_SelectedIndexChanged);
            // 
            // heladoBindingSource
            // 
            this.heladoBindingSource.DataMember = "Helado";
            this.heladoBindingSource.DataSource = this.bD3K6G05_2022DataSet;
            // 
            // bD3K6G05_2022DataSet
            // 
            this.bD3K6G05_2022DataSet.DataSetName = "BD3K6G05_2022DataSet";
            this.bD3K6G05_2022DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lbl_ABM
            // 
            this.lbl_ABM.AutoSize = true;
            this.lbl_ABM.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ABM.Location = new System.Drawing.Point(63, 37);
            this.lbl_ABM.Name = "lbl_ABM";
            this.lbl_ABM.Size = new System.Drawing.Size(320, 39);
            this.lbl_ABM.TabIndex = 2;
            this.lbl_ABM.Text = "Gestión de Helados";
            // 
            // btn_Salir
            // 
            this.btn_Salir.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Salir.BackgroundImage")));
            this.btn_Salir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Salir.Location = new System.Drawing.Point(674, 424);
            this.btn_Salir.Name = "btn_Salir";
            this.btn_Salir.Size = new System.Drawing.Size(71, 66);
            this.btn_Salir.TabIndex = 8;
            this.btn_Salir.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_Salir.UseVisualStyleBackColor = true;
            this.btn_Salir.Click += new System.EventHandler(this.btn_Salir_Click);
            // 
            // btn_Baja
            // 
            this.btn_Baja.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Baja.BackgroundImage")));
            this.btn_Baja.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Baja.Enabled = false;
            this.btn_Baja.Location = new System.Drawing.Point(240, 424);
            this.btn_Baja.Name = "btn_Baja";
            this.btn_Baja.Size = new System.Drawing.Size(71, 66);
            this.btn_Baja.TabIndex = 7;
            this.btn_Baja.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_Baja.UseVisualStyleBackColor = true;
            this.btn_Baja.Click += new System.EventHandler(this.btn_Baja_Click);
            // 
            // btn_Modificar
            // 
            this.btn_Modificar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Modificar.BackgroundImage")));
            this.btn_Modificar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Modificar.Enabled = false;
            this.btn_Modificar.Location = new System.Drawing.Point(163, 424);
            this.btn_Modificar.Name = "btn_Modificar";
            this.btn_Modificar.Size = new System.Drawing.Size(71, 66);
            this.btn_Modificar.TabIndex = 6;
            this.btn_Modificar.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_Modificar.UseVisualStyleBackColor = true;
            this.btn_Modificar.Click += new System.EventHandler(this.btn_Modificar_Click);
            // 
            // btn_Alta
            // 
            this.btn_Alta.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Alta.BackgroundImage")));
            this.btn_Alta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Alta.Location = new System.Drawing.Point(86, 424);
            this.btn_Alta.Name = "btn_Alta";
            this.btn_Alta.Size = new System.Drawing.Size(71, 66);
            this.btn_Alta.TabIndex = 5;
            this.btn_Alta.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_Alta.UseVisualStyleBackColor = true;
            this.btn_Alta.Click += new System.EventHandler(this.btn_Alta_Click);
            // 
            // heladoTableAdapter
            // 
            this.heladoTableAdapter.ClearBeforeFill = true;
            // 
            // frm_ABM_Helado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 502);
            this.Controls.Add(this.btn_Salir);
            this.Controls.Add(this.btn_Baja);
            this.Controls.Add(this.btn_Modificar);
            this.Controls.Add(this.btn_Alta);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lbl_ABM);
            this.Name = "frm_ABM_Helado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
            this.Text = "Gestión de Helados";
            this.Load += new System.EventHandler(this.frm_ABM_Helado_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgr_Helados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.heladoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bD3K6G05_2022DataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgr_Helados;
        private System.Windows.Forms.Label lbl_Patron;
        private System.Windows.Forms.Button btn_Buscar;
        private System.Windows.Forms.TextBox txt_Patron;
        private System.Windows.Forms.Label lbl_ABM;
        private System.Windows.Forms.Button btn_Salir;
        private System.Windows.Forms.Button btn_Baja;
        private System.Windows.Forms.Button btn_Modificar;
        private System.Windows.Forms.Button btn_Alta;
        private System.Windows.Forms.Button btn_3Puntos;
        private System.Windows.Forms.Label lbl_Tipo;
        private Clases.ComboBox01 cmb_TipoHelado;
        private BD3K6G05_2022DataSet bD3K6G05_2022DataSet;
        private System.Windows.Forms.BindingSource heladoBindingSource;
        private BD3K6G05_2022DataSetTableAdapters.HeladoTableAdapter heladoTableAdapter;
        private System.Windows.Forms.DataGridViewLinkColumn Cod_helado;
        private System.Windows.Forms.DataGridViewLinkColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipo_helado;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidad_stock;
        private System.Windows.Forms.DataGridViewTextBoxColumn borrado;
        private System.Windows.Forms.DataGridViewLinkColumn cod_helado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}