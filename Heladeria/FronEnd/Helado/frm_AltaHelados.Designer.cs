
namespace Heladeria.FronEnd.Helado
{
    partial class frm_AltaHelados
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_AltaHelados));
            this.lbl_AltaUsuarios = new System.Windows.Forms.Label();
            this.lbl_NombreHaldo = new System.Windows.Forms.Label();
            this.lbl_Descripcion = new System.Windows.Forms.Label();
            this.lbl_StockInicial = new System.Windows.Forms.Label();
            this.lbl_TipoHelado = new System.Windows.Forms.Label();
            this.btn_Salir_Alta = new System.Windows.Forms.Button();
            this.btn_Alta_Usuario = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_codHelado = new Heladeria.Clases.TextBox01();
            this.txt_stock = new Heladeria.Clases.TextBox01();
            this.cmb_TipoHelado = new Heladeria.Clases.ComboBox01();
            this.txt_descripcion = new Heladeria.Clases.TextBox01();
            this.txt_nombreHelado = new Heladeria.Clases.TextBox01();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_AltaUsuarios
            // 
            this.lbl_AltaUsuarios.AutoSize = true;
            this.lbl_AltaUsuarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_AltaUsuarios.Location = new System.Drawing.Point(47, 42);
            this.lbl_AltaUsuarios.Name = "lbl_AltaUsuarios";
            this.lbl_AltaUsuarios.Size = new System.Drawing.Size(330, 39);
            this.lbl_AltaUsuarios.TabIndex = 3;
            this.lbl_AltaUsuarios.Text = "Registro de Helados";
            // 
            // lbl_NombreHaldo
            // 
            this.lbl_NombreHaldo.AutoSize = true;
            this.lbl_NombreHaldo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_NombreHaldo.Location = new System.Drawing.Point(18, 32);
            this.lbl_NombreHaldo.Name = "lbl_NombreHaldo";
            this.lbl_NombreHaldo.Size = new System.Drawing.Size(62, 18);
            this.lbl_NombreHaldo.TabIndex = 0;
            this.lbl_NombreHaldo.Text = "Nombre";
            // 
            // lbl_Descripcion
            // 
            this.lbl_Descripcion.AutoSize = true;
            this.lbl_Descripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Descripcion.Location = new System.Drawing.Point(18, 71);
            this.lbl_Descripcion.Name = "lbl_Descripcion";
            this.lbl_Descripcion.Size = new System.Drawing.Size(87, 18);
            this.lbl_Descripcion.TabIndex = 1;
            this.lbl_Descripcion.Text = "Descripción";
            // 
            // lbl_StockInicial
            // 
            this.lbl_StockInicial.AutoSize = true;
            this.lbl_StockInicial.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_StockInicial.Location = new System.Drawing.Point(18, 113);
            this.lbl_StockInicial.Name = "lbl_StockInicial";
            this.lbl_StockInicial.Size = new System.Drawing.Size(87, 18);
            this.lbl_StockInicial.TabIndex = 4;
            this.lbl_StockInicial.Text = "Stock Inicial";
            // 
            // lbl_TipoHelado
            // 
            this.lbl_TipoHelado.AutoSize = true;
            this.lbl_TipoHelado.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TipoHelado.Location = new System.Drawing.Point(271, 29);
            this.lbl_TipoHelado.Name = "lbl_TipoHelado";
            this.lbl_TipoHelado.Size = new System.Drawing.Size(112, 18);
            this.lbl_TipoHelado.TabIndex = 2;
            this.lbl_TipoHelado.Text = "Tipo de Helado:";
            // 
            // btn_Salir_Alta
            // 
            this.btn_Salir_Alta.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Salir_Alta.BackgroundImage")));
            this.btn_Salir_Alta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Salir_Alta.Location = new System.Drawing.Point(367, 287);
            this.btn_Salir_Alta.Name = "btn_Salir_Alta";
            this.btn_Salir_Alta.Size = new System.Drawing.Size(71, 66);
            this.btn_Salir_Alta.TabIndex = 6;
            this.btn_Salir_Alta.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_Salir_Alta.UseVisualStyleBackColor = true;
            this.btn_Salir_Alta.Click += new System.EventHandler(this.btn_Salir_Alta_Click);
            // 
            // btn_Alta_Usuario
            // 
            this.btn_Alta_Usuario.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Alta_Usuario.BackgroundImage")));
            this.btn_Alta_Usuario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Alta_Usuario.Location = new System.Drawing.Point(215, 287);
            this.btn_Alta_Usuario.Name = "btn_Alta_Usuario";
            this.btn_Alta_Usuario.Size = new System.Drawing.Size(69, 66);
            this.btn_Alta_Usuario.TabIndex = 5;
            this.btn_Alta_Usuario.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_Alta_Usuario.UseVisualStyleBackColor = true;
            this.btn_Alta_Usuario.Click += new System.EventHandler(this.btn_Alta_Usuario_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txt_codHelado);
            this.groupBox1.Controls.Add(this.txt_stock);
            this.groupBox1.Controls.Add(this.cmb_TipoHelado);
            this.groupBox1.Controls.Add(this.txt_descripcion);
            this.groupBox1.Controls.Add(this.txt_nombreHelado);
            this.groupBox1.Controls.Add(this.lbl_NombreHaldo);
            this.groupBox1.Controls.Add(this.lbl_Descripcion);
            this.groupBox1.Controls.Add(this.lbl_StockInicial);
            this.groupBox1.Controls.Add(this.lbl_TipoHelado);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(31, 102);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(561, 165);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cargar un nuevo Helado";
            // 
            // txt_codHelado
            // 
            this.txt_codHelado.Enabled = false;
            this.txt_codHelado.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_codHelado.Location = new System.Drawing.Point(434, 110);
            this.txt_codHelado.Name = "txt_codHelado";
            this.txt_codHelado.Pp_mensaje_error = null;
            this.txt_codHelado.Pp_nombre_campo = null;
            this.txt_codHelado.Pp_nombre_tabla = null;
            this.txt_codHelado.Pp_validable = false;
            this.txt_codHelado.Size = new System.Drawing.Size(110, 24);
            this.txt_codHelado.TabIndex = 5;
            this.txt_codHelado.Visible = false;
            // 
            // txt_stock
            // 
            this.txt_stock.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_stock.Location = new System.Drawing.Point(111, 110);
            this.txt_stock.Name = "txt_stock";
            this.txt_stock.Pp_mensaje_error = "Nombre no cargado";
            this.txt_stock.Pp_nombre_campo = null;
            this.txt_stock.Pp_nombre_tabla = null;
            this.txt_stock.Pp_validable = false;
            this.txt_stock.Size = new System.Drawing.Size(110, 24);
            this.txt_stock.TabIndex = 2;
            // 
            // cmb_TipoHelado
            // 
            this.cmb_TipoHelado.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_TipoHelado.FormattingEnabled = true;
            this.cmb_TipoHelado.Location = new System.Drawing.Point(389, 26);
            this.cmb_TipoHelado.Name = "cmb_TipoHelado";
            this.cmb_TipoHelado.Pp_ConSeleccion = false;
            this.cmb_TipoHelado.Pp_descripcion = "nombre";
            this.cmb_TipoHelado.Pp_MensajeError = "debe seleccionar un perfil";
            this.cmb_TipoHelado.Pp_Pk = "id_perfil";
            this.cmb_TipoHelado.Pp_tabla = "Perfiles";
            this.cmb_TipoHelado.Size = new System.Drawing.Size(155, 26);
            this.cmb_TipoHelado.TabIndex = 4;
            // 
            // txt_descripcion
            // 
            this.txt_descripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_descripcion.Location = new System.Drawing.Point(107, 70);
            this.txt_descripcion.Name = "txt_descripcion";
            this.txt_descripcion.Pp_mensaje_error = "Contraseña no cargada";
            this.txt_descripcion.Pp_nombre_campo = null;
            this.txt_descripcion.Pp_nombre_tabla = null;
            this.txt_descripcion.Pp_validable = false;
            this.txt_descripcion.Size = new System.Drawing.Size(437, 24);
            this.txt_descripcion.TabIndex = 1;
            // 
            // txt_nombreHelado
            // 
            this.txt_nombreHelado.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nombreHelado.Location = new System.Drawing.Point(107, 29);
            this.txt_nombreHelado.Name = "txt_nombreHelado";
            this.txt_nombreHelado.Pp_mensaje_error = null;
            this.txt_nombreHelado.Pp_nombre_campo = null;
            this.txt_nombreHelado.Pp_nombre_tabla = null;
            this.txt_nombreHelado.Pp_validable = false;
            this.txt_nombreHelado.Size = new System.Drawing.Size(110, 24);
            this.txt_nombreHelado.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(227, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 18);
            this.label1.TabIndex = 6;
            this.label1.Text = "Gr.";
            // 
            // frm_AltaHelados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 376);
            this.Controls.Add(this.lbl_AltaUsuarios);
            this.Controls.Add(this.btn_Salir_Alta);
            this.Controls.Add(this.btn_Alta_Usuario);
            this.Controls.Add(this.groupBox1);
            this.Name = "frm_AltaHelados";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro de Helados";
            this.Load += new System.EventHandler(this.frm_AltaHelados_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_AltaUsuarios;
        private Clases.TextBox01 txt_stock;
        private Clases.ComboBox01 cmb_TipoHelado;
        private Clases.TextBox01 txt_descripcion;
        private Clases.TextBox01 txt_nombreHelado;
        private System.Windows.Forms.Label lbl_NombreHaldo;
        private System.Windows.Forms.Label lbl_Descripcion;
        private System.Windows.Forms.Label lbl_StockInicial;
        private System.Windows.Forms.Label lbl_TipoHelado;
        private System.Windows.Forms.Button btn_Salir_Alta;
        private System.Windows.Forms.Button btn_Alta_Usuario;
        private System.Windows.Forms.GroupBox groupBox1;
        private Clases.TextBox01 txt_codHelado;
        private System.Windows.Forms.Label label1;
    }
}