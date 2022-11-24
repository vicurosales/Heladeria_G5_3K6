
namespace Heladeria.FronEnd
{
    partial class frm_ModificacionHelado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_ModificacionHelado));
            this.lbl_ModHelados = new System.Windows.Forms.Label();
            this.txt_stock = new Heladeria.Clases.TextBox01();
            this.txt_descripcion = new Heladeria.Clases.TextBox01();
            this.cmb_tipoHelado = new Heladeria.Clases.ComboBox01();
            this.lbl_Descripcion = new System.Windows.Forms.Label();
            this.lbl_Perfil = new System.Windows.Forms.Label();
            this.txt_nombre = new Heladeria.Clases.TextBox01();
            this.button_Aceptar = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label_nombre = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBox_IDhelado = new Heladeria.Clases.TextBox01();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_ModHelados
            // 
            this.lbl_ModHelados.AccessibleRole = System.Windows.Forms.AccessibleRole.IpAddress;
            this.lbl_ModHelados.AutoSize = true;
            this.lbl_ModHelados.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ModHelados.Location = new System.Drawing.Point(48, 54);
            this.lbl_ModHelados.Name = "lbl_ModHelados";
            this.lbl_ModHelados.Size = new System.Drawing.Size(277, 39);
            this.lbl_ModHelados.TabIndex = 11;
            this.lbl_ModHelados.Text = "Modificar Helado";
            this.lbl_ModHelados.Click += new System.EventHandler(this.lbl_ModHelados_Click);
            // 
            // txt_stock
            // 
            this.txt_stock.Enabled = false;
            this.txt_stock.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_stock.Location = new System.Drawing.Point(114, 127);
            this.txt_stock.Name = "txt_stock";
            this.txt_stock.Pp_mensaje_error = "";
            this.txt_stock.Pp_nombre_campo = null;
            this.txt_stock.Pp_nombre_tabla = null;
            this.txt_stock.Pp_validable = false;
            this.txt_stock.Size = new System.Drawing.Size(95, 24);
            this.txt_stock.TabIndex = 14;
            this.txt_stock.TextChanged += new System.EventHandler(this.txt_stock_TextChanged_1);
            // 
            // txt_descripcion
            // 
            this.txt_descripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_descripcion.Location = new System.Drawing.Point(169, 210);
            this.txt_descripcion.Name = "txt_descripcion";
            this.txt_descripcion.Pp_mensaje_error = "Nombre no cargado";
            this.txt_descripcion.Pp_nombre_campo = null;
            this.txt_descripcion.Pp_nombre_tabla = null;
            this.txt_descripcion.Pp_validable = false;
            this.txt_descripcion.Size = new System.Drawing.Size(429, 24);
            this.txt_descripcion.TabIndex = 2;
            this.txt_descripcion.TextChanged += new System.EventHandler(this.txt_descripcion_TextChanged_1);
            // 
            // cmb_tipoHelado
            // 
            this.cmb_tipoHelado.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_tipoHelado.FormattingEnabled = true;
            this.cmb_tipoHelado.Location = new System.Drawing.Point(467, 168);
            this.cmb_tipoHelado.Name = "cmb_tipoHelado";
            this.cmb_tipoHelado.Pp_ConSeleccion = false;
            this.cmb_tipoHelado.Pp_descripcion = "nombre";
            this.cmb_tipoHelado.Pp_MensajeError = "";
            this.cmb_tipoHelado.Pp_Pk = "cod_tipo";
            this.cmb_tipoHelado.Pp_tabla = "Tipo_Helado";
            this.cmb_tipoHelado.Size = new System.Drawing.Size(134, 26);
            this.cmb_tipoHelado.TabIndex = 4;
            this.cmb_tipoHelado.SelectedIndexChanged += new System.EventHandler(this.cmb_tipoHelado_SelectedIndexChanged_1);
            // 
            // lbl_Descripcion
            // 
            this.lbl_Descripcion.AutoSize = true;
            this.lbl_Descripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Descripcion.Location = new System.Drawing.Point(65, 210);
            this.lbl_Descripcion.Name = "lbl_Descripcion";
            this.lbl_Descripcion.Size = new System.Drawing.Size(91, 18);
            this.lbl_Descripcion.TabIndex = 4;
            this.lbl_Descripcion.Text = "Descripción:";
            this.lbl_Descripcion.Click += new System.EventHandler(this.lbl_Descripcion_Click_1);
            // 
            // lbl_Perfil
            // 
            this.lbl_Perfil.AutoSize = true;
            this.lbl_Perfil.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Perfil.Location = new System.Drawing.Point(349, 168);
            this.lbl_Perfil.Name = "lbl_Perfil";
            this.lbl_Perfil.Size = new System.Drawing.Size(112, 18);
            this.lbl_Perfil.TabIndex = 2;
            this.lbl_Perfil.Text = "Tipo de Helado:";
            this.lbl_Perfil.Click += new System.EventHandler(this.lbl_Perfil_Click_1);
            // 
            // txt_nombre
            // 
            this.txt_nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nombre.Location = new System.Drawing.Point(169, 168);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Pp_mensaje_error = "Contraseña no cargada";
            this.txt_nombre.Pp_nombre_campo = null;
            this.txt_nombre.Pp_nombre_tabla = null;
            this.txt_nombre.Pp_validable = false;
            this.txt_nombre.Size = new System.Drawing.Size(171, 24);
            this.txt_nombre.TabIndex = 1;
            this.txt_nombre.TextChanged += new System.EventHandler(this.txt_nombre_TextChanged_1);
            // 
            // button_Aceptar
            // 
            this.button_Aceptar.AccessibleRole = System.Windows.Forms.AccessibleRole.IpAddress;
            this.button_Aceptar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_Aceptar.BackgroundImage")));
            this.button_Aceptar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_Aceptar.Location = new System.Drawing.Point(223, 299);
            this.button_Aceptar.Name = "button_Aceptar";
            this.button_Aceptar.Size = new System.Drawing.Size(83, 81);
            this.button_Aceptar.TabIndex = 14;
            this.button_Aceptar.UseVisualStyleBackColor = true;
            this.button_Aceptar.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.AccessibleRole = System.Windows.Forms.AccessibleRole.IpAddress;
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.Location = new System.Drawing.Point(352, 299);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(86, 81);
            this.button2.TabIndex = 15;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // label_nombre
            // 
            this.label_nombre.AutoSize = true;
            this.label_nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_nombre.Location = new System.Drawing.Point(10, 64);
            this.label_nombre.Name = "label_nombre";
            this.label_nombre.Size = new System.Drawing.Size(66, 18);
            this.label_nombre.TabIndex = 16;
            this.label_nombre.Text = "Nombre:";
            this.label_nombre.Click += new System.EventHandler(this.label_nombre_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label_nombre);
            this.groupBox2.Controls.Add(this.textBox_IDhelado);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(55, 104);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(596, 177);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Realizar modificaciones de los datos de un helado.";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // textBox_IDhelado
            // 
            this.textBox_IDhelado.Enabled = false;
            this.textBox_IDhelado.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_IDhelado.Location = new System.Drawing.Point(114, 30);
            this.textBox_IDhelado.Name = "textBox_IDhelado";
            this.textBox_IDhelado.Pp_mensaje_error = "";
            this.textBox_IDhelado.Pp_nombre_campo = null;
            this.textBox_IDhelado.Pp_nombre_tabla = null;
            this.textBox_IDhelado.Pp_validable = false;
            this.textBox_IDhelado.Size = new System.Drawing.Size(171, 24);
            this.textBox_IDhelado.TabIndex = 18;
            this.textBox_IDhelado.TextChanged += new System.EventHandler(this.textBox_IDhelado_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(10, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 18);
            this.label3.TabIndex = 18;
            this.label3.Text = "ID helado";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // frm_ModificacionHelado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(709, 394);
            this.Controls.Add(this.button_Aceptar);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.txt_descripcion);
            this.Controls.Add(this.lbl_ModHelados);
            this.Controls.Add(this.cmb_tipoHelado);
            this.Controls.Add(this.txt_nombre);
            this.Controls.Add(this.lbl_Descripcion);
            this.Controls.Add(this.lbl_Perfil);
            this.Controls.Add(this.groupBox2);
            this.Name = "frm_ModificacionHelado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modificar un Helado";
            this.Load += new System.EventHandler(this.frm_ModificacionHelado_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_ModHelados;
        private System.Windows.Forms.GroupBox groupBox1;
        private Clases.TextBox01 txt_descripcion;
        private Clases.ComboBox01 cmb_tipoHelado;
        private System.Windows.Forms.Label lbl_Descripcion;
        private System.Windows.Forms.Label lbl_Perfil;
        private Clases.TextBox01 txt_stock;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_Nombre;
        private Clases.TextBox01 txt_nombre;
        private System.Windows.Forms.Button button_Aceptar;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label_nombre;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private Clases.TextBox01 textBox_IDhelado;
    }
}