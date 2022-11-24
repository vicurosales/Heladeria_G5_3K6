
namespace Heladeria.FronEnd.Factura
{
    partial class frm_ABM_Factura
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_ABM_Factura));
            this.lbl_ABM = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.detalle = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.grillaDetalle = new System.Windows.Forms.DataGridView();
            this.id_helado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Helado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_Alta_Usuario = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_Salir = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.comboBoxVendedores = new Heladeria.Clases.ComboBox01();
            this.montoTotal = new Heladeria.Clases.TextBox01();
            this.textCantidad = new Heladeria.Clases.TextBox01();
            this.comboBox_helados = new Heladeria.Clases.ComboBox01();
            this.comboBox_tipoFactura = new Heladeria.Clases.ComboBox01();
            this.textBox_Numero = new Heladeria.Clases.TextBox01();
            this.txt_fecha = new Heladeria.Clases.TextBox01();
            this.detalle.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grillaDetalle)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_ABM
            // 
            this.lbl_ABM.AutoSize = true;
            this.lbl_ABM.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ABM.Location = new System.Drawing.Point(59, 21);
            this.lbl_ABM.Name = "lbl_ABM";
            this.lbl_ABM.Size = new System.Drawing.Size(135, 39);
            this.lbl_ABM.TabIndex = 1;
            this.lbl_ABM.Text = "Factura";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Fecha";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(207, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "N° de Factura";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(389, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Tipo de Factura";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // detalle
            // 
            this.detalle.Controls.Add(this.label7);
            this.detalle.Controls.Add(this.groupBox1);
            this.detalle.Controls.Add(this.button1);
            this.detalle.Controls.Add(this.grillaDetalle);
            this.detalle.Controls.Add(this.textCantidad);
            this.detalle.Controls.Add(this.label5);
            this.detalle.Controls.Add(this.comboBox_helados);
            this.detalle.Controls.Add(this.label4);
            this.detalle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.detalle.Location = new System.Drawing.Point(44, 133);
            this.detalle.Name = "detalle";
            this.detalle.Size = new System.Drawing.Size(713, 354);
            this.detalle.TabIndex = 8;
            this.detalle.TabStop = false;
            this.detalle.Text = "Detalle";
            this.detalle.Enter += new System.EventHandler(this.detalle_Enter);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(521, 45);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 17);
            this.label7.TabIndex = 19;
            this.label7.Text = "(Gr.)";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.montoTotal);
            this.groupBox1.Location = new System.Drawing.Point(466, 307);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 41);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Monto Total";
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Location = new System.Drawing.Point(590, 40);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(35, 30);
            this.button1.TabIndex = 12;
            this.button1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // grillaDetalle
            // 
            this.grillaDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grillaDetalle.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_helado,
            this.Helado,
            this.cantidad,
            this.precio});
            this.grillaDetalle.Location = new System.Drawing.Point(45, 130);
            this.grillaDetalle.Name = "grillaDetalle";
            this.grillaDetalle.Size = new System.Drawing.Size(621, 148);
            this.grillaDetalle.TabIndex = 17;
            this.grillaDetalle.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grillaDetalle_CellContentClick);
            // 
            // id_helado
            // 
            this.id_helado.HeaderText = "id_helado";
            this.id_helado.Name = "id_helado";
            this.id_helado.ReadOnly = true;
            this.id_helado.Visible = false;
            // 
            // Helado
            // 
            this.Helado.HeaderText = "Helado";
            this.Helado.Name = "Helado";
            // 
            // cantidad
            // 
            this.cantidad.HeaderText = "Cantidad (Gr.)";
            this.cantidad.Name = "cantidad";
            // 
            // precio
            // 
            this.precio.HeaderText = "Precio ($)";
            this.precio.Name = "precio";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(379, 44);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Cantidad";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(51, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Helado:";
            // 
            // btn_Alta_Usuario
            // 
            this.btn_Alta_Usuario.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Alta_Usuario.BackgroundImage")));
            this.btn_Alta_Usuario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Alta_Usuario.Location = new System.Drawing.Point(685, 509);
            this.btn_Alta_Usuario.Name = "btn_Alta_Usuario";
            this.btn_Alta_Usuario.Size = new System.Drawing.Size(72, 64);
            this.btn_Alta_Usuario.TabIndex = 11;
            this.btn_Alta_Usuario.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_Alta_Usuario.UseVisualStyleBackColor = true;
            this.btn_Alta_Usuario.Click += new System.EventHandler(this.btn_Alta_Usuario_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(583, 94);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Vendedor";
            // 
            // btn_Salir
            // 
            this.btn_Salir.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Salir.BackgroundImage")));
            this.btn_Salir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Salir.Location = new System.Drawing.Point(44, 509);
            this.btn_Salir.Name = "btn_Salir";
            this.btn_Salir.Size = new System.Drawing.Size(71, 64);
            this.btn_Salir.TabIndex = 14;
            this.btn_Salir.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_Salir.UseVisualStyleBackColor = true;
            this.btn_Salir.Click += new System.EventHandler(this.btn_Salir_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(80, 15);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(16, 17);
            this.label8.TabIndex = 20;
            this.label8.Text = "$";
            // 
            // comboBoxVendedores
            // 
            this.comboBoxVendedores.FormattingEnabled = true;
            this.comboBoxVendedores.Location = new System.Drawing.Point(643, 91);
            this.comboBoxVendedores.Name = "comboBoxVendedores";
            this.comboBoxVendedores.Pp_ConSeleccion = false;
            this.comboBoxVendedores.Pp_descripcion = "nombre";
            this.comboBoxVendedores.Pp_MensajeError = null;
            this.comboBoxVendedores.Pp_Pk = "id_usuario";
            this.comboBoxVendedores.Pp_tabla = "Usuarios";
            this.comboBoxVendedores.Size = new System.Drawing.Size(114, 21);
            this.comboBoxVendedores.TabIndex = 13;
            // 
            // montoTotal
            // 
            this.montoTotal.Enabled = false;
            this.montoTotal.Location = new System.Drawing.Point(102, 12);
            this.montoTotal.Name = "montoTotal";
            this.montoTotal.Pp_mensaje_error = null;
            this.montoTotal.Pp_nombre_campo = null;
            this.montoTotal.Pp_nombre_tabla = null;
            this.montoTotal.Pp_validable = false;
            this.montoTotal.Size = new System.Drawing.Size(92, 23);
            this.montoTotal.TabIndex = 19;
            this.montoTotal.TextChanged += new System.EventHandler(this.montoTotal_TextChanged);
            // 
            // textCantidad
            // 
            this.textCantidad.Location = new System.Drawing.Point(464, 41);
            this.textCantidad.Name = "textCantidad";
            this.textCantidad.Pp_mensaje_error = null;
            this.textCantidad.Pp_nombre_campo = null;
            this.textCantidad.Pp_nombre_tabla = null;
            this.textCantidad.Pp_validable = false;
            this.textCantidad.Size = new System.Drawing.Size(51, 23);
            this.textCantidad.TabIndex = 10;
            this.textCantidad.TextChanged += new System.EventHandler(this.textCantidad_TextChanged);
            // 
            // comboBox_helados
            // 
            this.comboBox_helados.FormattingEnabled = true;
            this.comboBox_helados.Location = new System.Drawing.Point(106, 38);
            this.comboBox_helados.Name = "comboBox_helados";
            this.comboBox_helados.Pp_ConSeleccion = false;
            this.comboBox_helados.Pp_descripcion = "nombre";
            this.comboBox_helados.Pp_MensajeError = null;
            this.comboBox_helados.Pp_Pk = "cod_helado";
            this.comboBox_helados.Pp_tabla = "Helado";
            this.comboBox_helados.Size = new System.Drawing.Size(201, 24);
            this.comboBox_helados.TabIndex = 9;
            // 
            // comboBox_tipoFactura
            // 
            this.comboBox_tipoFactura.FormattingEnabled = true;
            this.comboBox_tipoFactura.Location = new System.Drawing.Point(477, 91);
            this.comboBox_tipoFactura.Name = "comboBox_tipoFactura";
            this.comboBox_tipoFactura.Pp_ConSeleccion = false;
            this.comboBox_tipoFactura.Pp_descripcion = "nombre";
            this.comboBox_tipoFactura.Pp_MensajeError = null;
            this.comboBox_tipoFactura.Pp_Pk = "codigo_tipo";
            this.comboBox_tipoFactura.Pp_tabla = "Tipo_Factura";
            this.comboBox_tipoFactura.Size = new System.Drawing.Size(89, 21);
            this.comboBox_tipoFactura.TabIndex = 7;
            this.comboBox_tipoFactura.SelectedIndexChanged += new System.EventHandler(this.comboBox_tipoFactura_SelectedIndexChanged);
            // 
            // textBox_Numero
            // 
            this.textBox_Numero.Enabled = false;
            this.textBox_Numero.Location = new System.Drawing.Point(286, 91);
            this.textBox_Numero.Name = "textBox_Numero";
            this.textBox_Numero.Pp_mensaje_error = null;
            this.textBox_Numero.Pp_nombre_campo = null;
            this.textBox_Numero.Pp_nombre_tabla = null;
            this.textBox_Numero.Pp_validable = false;
            this.textBox_Numero.Size = new System.Drawing.Size(65, 20);
            this.textBox_Numero.TabIndex = 5;
            this.textBox_Numero.TextChanged += new System.EventHandler(this.textBox_Numero_TextChanged);
            // 
            // txt_fecha
            // 
            this.txt_fecha.Enabled = false;
            this.txt_fecha.Location = new System.Drawing.Point(89, 91);
            this.txt_fecha.Name = "txt_fecha";
            this.txt_fecha.Pp_mensaje_error = null;
            this.txt_fecha.Pp_nombre_campo = null;
            this.txt_fecha.Pp_nombre_tabla = null;
            this.txt_fecha.Pp_validable = false;
            this.txt_fecha.Size = new System.Drawing.Size(100, 20);
            this.txt_fecha.TabIndex = 3;
            this.txt_fecha.TextChanged += new System.EventHandler(this.txt_fecha_TextChanged);
            // 
            // frm_ABM_Factura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 595);
            this.Controls.Add(this.btn_Salir);
            this.Controls.Add(this.comboBoxVendedores);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.detalle);
            this.Controls.Add(this.comboBox_tipoFactura);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox_Numero);
            this.Controls.Add(this.btn_Alta_Usuario);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_fecha);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_ABM);
            this.Name = "frm_ABM_Factura";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_ABM_Factura";
            this.Load += new System.EventHandler(this.frm_ABM_Factura_Load);
            this.detalle.ResumeLayout(false);
            this.detalle.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grillaDetalle)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_ABM;
        private System.Windows.Forms.Label label1;
        private Clases.TextBox01 txt_fecha;
        private Clases.TextBox01 textBox_Numero;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private Clases.ComboBox01 comboBox_tipoFactura;
        private System.Windows.Forms.GroupBox detalle;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView grillaDetalle;
        private Clases.TextBox01 textCantidad;
        private System.Windows.Forms.Label label5;
        private Clases.ComboBox01 comboBox_helados;
        private System.Windows.Forms.Button btn_Alta_Usuario;
        private System.Windows.Forms.Label label6;
        private Clases.ComboBox01 comboBoxVendedores;
        private System.Windows.Forms.Button btn_Salir;
        private System.Windows.Forms.GroupBox groupBox1;
        private Clases.TextBox01 montoTotal;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_helado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Helado;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn precio;
        private System.Windows.Forms.Label label8;
    }
}