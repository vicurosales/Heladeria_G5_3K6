
namespace Heladeria.FronEnd.Helado
{
    partial class frm_BorrarHelados
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_BorrarHelados));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_descripcion = new Heladeria.Clases.TextBox01();
            this.cmb_tipoHelado = new Heladeria.Clases.ComboBox01();
            this.txt_nombre = new Heladeria.Clases.TextBox01();
            this.txt_cod_helado = new Heladeria.Clases.TextBox01();
            this.lbl_IdUsuario = new System.Windows.Forms.Label();
            this.lbl_Nombre = new System.Windows.Forms.Label();
            this.lbl_Descripcion = new System.Windows.Forms.Label();
            this.lbl_Perfil = new System.Windows.Forms.Label();
            this.lbl_BorrarUsuarios = new System.Windows.Forms.Label();
            this.btn_Aceptar = new System.Windows.Forms.Button();
            this.btn_Cancelar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.IpAddress;
            this.groupBox1.Controls.Add(this.txt_descripcion);
            this.groupBox1.Controls.Add(this.cmb_tipoHelado);
            this.groupBox1.Controls.Add(this.txt_nombre);
            this.groupBox1.Controls.Add(this.txt_cod_helado);
            this.groupBox1.Controls.Add(this.lbl_IdUsuario);
            this.groupBox1.Controls.Add(this.lbl_Nombre);
            this.groupBox1.Controls.Add(this.lbl_Descripcion);
            this.groupBox1.Controls.Add(this.lbl_Perfil);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(31, 93);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(572, 175);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Realizar la baja de un helado.";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // txt_descripcion
            // 
            this.txt_descripcion.Enabled = false;
            this.txt_descripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_descripcion.Location = new System.Drawing.Point(122, 113);
            this.txt_descripcion.Name = "txt_descripcion";
            this.txt_descripcion.Pp_mensaje_error = "Nombre no cargado";
            this.txt_descripcion.Pp_nombre_campo = null;
            this.txt_descripcion.Pp_nombre_tabla = null;
            this.txt_descripcion.Pp_validable = false;
            this.txt_descripcion.Size = new System.Drawing.Size(404, 24);
            this.txt_descripcion.TabIndex = 2;
            // 
            // cmb_tipoHelado
            // 
            this.cmb_tipoHelado.Enabled = false;
            this.cmb_tipoHelado.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_tipoHelado.FormattingEnabled = true;
            this.cmb_tipoHelado.Location = new System.Drawing.Point(417, 32);
            this.cmb_tipoHelado.Name = "cmb_tipoHelado";
            this.cmb_tipoHelado.Pp_ConSeleccion = false;
            this.cmb_tipoHelado.Pp_descripcion = "nombre";
            this.cmb_tipoHelado.Pp_MensajeError = "";
            this.cmb_tipoHelado.Pp_Pk = "cod_tipo";
            this.cmb_tipoHelado.Pp_tabla = "Tipo_Helado";
            this.cmb_tipoHelado.Size = new System.Drawing.Size(109, 26);
            this.cmb_tipoHelado.TabIndex = 4;
            // 
            // txt_nombre
            // 
            this.txt_nombre.Enabled = false;
            this.txt_nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nombre.Location = new System.Drawing.Point(122, 71);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Pp_mensaje_error = "Contraseña no cargada";
            this.txt_nombre.Pp_nombre_campo = null;
            this.txt_nombre.Pp_nombre_tabla = null;
            this.txt_nombre.Pp_validable = false;
            this.txt_nombre.Size = new System.Drawing.Size(232, 24);
            this.txt_nombre.TabIndex = 1;
            // 
            // txt_cod_helado
            // 
            this.txt_cod_helado.Enabled = false;
            this.txt_cod_helado.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_cod_helado.Location = new System.Drawing.Point(122, 29);
            this.txt_cod_helado.Name = "txt_cod_helado";
            this.txt_cod_helado.Pp_mensaje_error = null;
            this.txt_cod_helado.Pp_nombre_campo = null;
            this.txt_cod_helado.Pp_nombre_tabla = null;
            this.txt_cod_helado.Pp_validable = false;
            this.txt_cod_helado.Size = new System.Drawing.Size(110, 24);
            this.txt_cod_helado.TabIndex = 0;
            // 
            // lbl_IdUsuario
            // 
            this.lbl_IdUsuario.AutoSize = true;
            this.lbl_IdUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_IdUsuario.Location = new System.Drawing.Point(18, 32);
            this.lbl_IdUsuario.Name = "lbl_IdUsuario";
            this.lbl_IdUsuario.Size = new System.Drawing.Size(74, 18);
            this.lbl_IdUsuario.TabIndex = 0;
            this.lbl_IdUsuario.Text = "ID helado:";
            // 
            // lbl_Nombre
            // 
            this.lbl_Nombre.AutoSize = true;
            this.lbl_Nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Nombre.Location = new System.Drawing.Point(18, 71);
            this.lbl_Nombre.Name = "lbl_Nombre";
            this.lbl_Nombre.Size = new System.Drawing.Size(66, 18);
            this.lbl_Nombre.TabIndex = 1;
            this.lbl_Nombre.Text = "Nombre:";
            // 
            // lbl_Descripcion
            // 
            this.lbl_Descripcion.AutoSize = true;
            this.lbl_Descripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Descripcion.Location = new System.Drawing.Point(18, 113);
            this.lbl_Descripcion.Name = "lbl_Descripcion";
            this.lbl_Descripcion.Size = new System.Drawing.Size(91, 18);
            this.lbl_Descripcion.TabIndex = 4;
            this.lbl_Descripcion.Text = "Descripción:";
            // 
            // lbl_Perfil
            // 
            this.lbl_Perfil.AutoSize = true;
            this.lbl_Perfil.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Perfil.Location = new System.Drawing.Point(299, 32);
            this.lbl_Perfil.Name = "lbl_Perfil";
            this.lbl_Perfil.Size = new System.Drawing.Size(112, 18);
            this.lbl_Perfil.TabIndex = 2;
            this.lbl_Perfil.Text = "Tipo de Helado:";
            // 
            // lbl_BorrarUsuarios
            // 
            this.lbl_BorrarUsuarios.AccessibleRole = System.Windows.Forms.AccessibleRole.IpAddress;
            this.lbl_BorrarUsuarios.AutoSize = true;
            this.lbl_BorrarUsuarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_BorrarUsuarios.Location = new System.Drawing.Point(47, 33);
            this.lbl_BorrarUsuarios.Name = "lbl_BorrarUsuarios";
            this.lbl_BorrarUsuarios.Size = new System.Drawing.Size(269, 39);
            this.lbl_BorrarUsuarios.TabIndex = 7;
            this.lbl_BorrarUsuarios.Text = "Baja de Helados";
            // 
            // btn_Aceptar
            // 
            this.btn_Aceptar.AccessibleRole = System.Windows.Forms.AccessibleRole.IpAddress;
            this.btn_Aceptar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Aceptar.BackgroundImage")));
            this.btn_Aceptar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Aceptar.Location = new System.Drawing.Point(204, 266);
            this.btn_Aceptar.Name = "btn_Aceptar";
            this.btn_Aceptar.Size = new System.Drawing.Size(83, 81);
            this.btn_Aceptar.TabIndex = 8;
            this.btn_Aceptar.UseVisualStyleBackColor = true;
            this.btn_Aceptar.Click += new System.EventHandler(this.btn_Aceptar_Click);
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.AccessibleRole = System.Windows.Forms.AccessibleRole.IpAddress;
            this.btn_Cancelar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Cancelar.BackgroundImage")));
            this.btn_Cancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Cancelar.Location = new System.Drawing.Point(333, 266);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Size = new System.Drawing.Size(86, 81);
            this.btn_Cancelar.TabIndex = 9;
            this.btn_Cancelar.UseVisualStyleBackColor = true;
            this.btn_Cancelar.Click += new System.EventHandler(this.btn_Cancelar_Click);
            // 
            // frm_BorrarHelados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 359);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lbl_BorrarUsuarios);
            this.Controls.Add(this.btn_Aceptar);
            this.Controls.Add(this.btn_Cancelar);
            this.Name = "frm_BorrarHelados";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Eliminar un Helado";
            this.Load += new System.EventHandler(this.frm_BorrarHelados_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private Clases.TextBox01 txt_descripcion;
        private Clases.ComboBox01 cmb_tipoHelado;
        private Clases.TextBox01 txt_nombre;
        private Clases.TextBox01 txt_cod_helado;
        private System.Windows.Forms.Label lbl_IdUsuario;
        private System.Windows.Forms.Label lbl_Nombre;
        private System.Windows.Forms.Label lbl_Descripcion;
        private System.Windows.Forms.Label lbl_Perfil;
        private System.Windows.Forms.Label lbl_BorrarUsuarios;
        private System.Windows.Forms.Button btn_Aceptar;
        private System.Windows.Forms.Button btn_Cancelar;
    }
}