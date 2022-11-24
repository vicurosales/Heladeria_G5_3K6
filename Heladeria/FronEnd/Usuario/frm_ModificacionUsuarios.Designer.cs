namespace Heladeria.FronEnd
{
    partial class frm_ModificacionUsuarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_ModificacionUsuarios));
            this.lbl_IdUsuario = new System.Windows.Forms.Label();
            this.lbl_Password = new System.Windows.Forms.Label();
            this.lbl_Perfil = new System.Windows.Forms.Label();
            this.lbl_Email = new System.Windows.Forms.Label();
            this.lbl_Nombre = new System.Windows.Forms.Label();
            this.lbl_Apellido = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_cuil_usuario = new Heladeria.Clases.TextBox01();
            this.txt_apellido_usuario = new Heladeria.Clases.TextBox01();
            this.txt_nombre_usuario = new Heladeria.Clases.TextBox01();
            this.cmb_perfil_usuario = new Heladeria.Clases.ComboBox01();
            this.txt_email_usuario = new Heladeria.Clases.TextBox01();
            this.txt_contraseña = new Heladeria.Clases.TextBox01();
            this.txt_Id_user = new Heladeria.Clases.TextBox01();
            this.lbl_Cuil = new System.Windows.Forms.Label();
            this.lbl_ModificarUsuarios = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btn_Aceptar = new System.Windows.Forms.Button();
            this.btn_Cancelar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_IdUsuario
            // 
            this.lbl_IdUsuario.AutoSize = true;
            this.lbl_IdUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_IdUsuario.Location = new System.Drawing.Point(18, 32);
            this.lbl_IdUsuario.Name = "lbl_IdUsuario";
            this.lbl_IdUsuario.Size = new System.Drawing.Size(82, 18);
            this.lbl_IdUsuario.TabIndex = 0;
            this.lbl_IdUsuario.Text = "ID Usuario:";
            // 
            // lbl_Password
            // 
            this.lbl_Password.AutoSize = true;
            this.lbl_Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Password.Location = new System.Drawing.Point(18, 71);
            this.lbl_Password.Name = "lbl_Password";
            this.lbl_Password.Size = new System.Drawing.Size(89, 18);
            this.lbl_Password.TabIndex = 1;
            this.lbl_Password.Text = "Contraseña:";
            // 
            // lbl_Perfil
            // 
            this.lbl_Perfil.AutoSize = true;
            this.lbl_Perfil.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Perfil.Location = new System.Drawing.Point(335, 30);
            this.lbl_Perfil.Name = "lbl_Perfil";
            this.lbl_Perfil.Size = new System.Drawing.Size(45, 18);
            this.lbl_Perfil.TabIndex = 2;
            this.lbl_Perfil.Text = "Perfil:";
            // 
            // lbl_Email
            // 
            this.lbl_Email.AutoSize = true;
            this.lbl_Email.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Email.Location = new System.Drawing.Point(326, 71);
            this.lbl_Email.Name = "lbl_Email";
            this.lbl_Email.Size = new System.Drawing.Size(54, 18);
            this.lbl_Email.TabIndex = 3;
            this.lbl_Email.Text = "E-Mail:";
            // 
            // lbl_Nombre
            // 
            this.lbl_Nombre.AutoSize = true;
            this.lbl_Nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Nombre.Location = new System.Drawing.Point(35, 113);
            this.lbl_Nombre.Name = "lbl_Nombre";
            this.lbl_Nombre.Size = new System.Drawing.Size(66, 18);
            this.lbl_Nombre.TabIndex = 4;
            this.lbl_Nombre.Text = "Nombre:";
            // 
            // lbl_Apellido
            // 
            this.lbl_Apellido.AutoSize = true;
            this.lbl_Apellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Apellido.Location = new System.Drawing.Point(38, 158);
            this.lbl_Apellido.Name = "lbl_Apellido";
            this.lbl_Apellido.Size = new System.Drawing.Size(63, 18);
            this.lbl_Apellido.TabIndex = 5;
            this.lbl_Apellido.Text = "Apellido:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_cuil_usuario);
            this.groupBox1.Controls.Add(this.txt_apellido_usuario);
            this.groupBox1.Controls.Add(this.txt_nombre_usuario);
            this.groupBox1.Controls.Add(this.cmb_perfil_usuario);
            this.groupBox1.Controls.Add(this.txt_email_usuario);
            this.groupBox1.Controls.Add(this.txt_contraseña);
            this.groupBox1.Controls.Add(this.txt_Id_user);
            this.groupBox1.Controls.Add(this.lbl_Cuil);
            this.groupBox1.Controls.Add(this.lbl_IdUsuario);
            this.groupBox1.Controls.Add(this.lbl_Apellido);
            this.groupBox1.Controls.Add(this.lbl_Password);
            this.groupBox1.Controls.Add(this.lbl_Nombre);
            this.groupBox1.Controls.Add(this.lbl_Perfil);
            this.groupBox1.Controls.Add(this.lbl_Email);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(31, 85);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(577, 206);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Modificar Usuario";
            // 
            // txt_cuil_usuario
            // 
            this.txt_cuil_usuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_cuil_usuario.Location = new System.Drawing.Point(387, 108);
            this.txt_cuil_usuario.Name = "txt_cuil_usuario";
            this.txt_cuil_usuario.Pp_mensaje_error = "Cuil no cargado";
            this.txt_cuil_usuario.Pp_nombre_campo = null;
            this.txt_cuil_usuario.Pp_nombre_tabla = null;
            this.txt_cuil_usuario.Pp_validable = false;
            this.txt_cuil_usuario.Size = new System.Drawing.Size(165, 24);
            this.txt_cuil_usuario.TabIndex = 6;
            this.toolTip1.SetToolTip(this.txt_cuil_usuario, "CUIL del usuario");
            // 
            // txt_apellido_usuario
            // 
            this.txt_apellido_usuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_apellido_usuario.Location = new System.Drawing.Point(107, 152);
            this.txt_apellido_usuario.Name = "txt_apellido_usuario";
            this.txt_apellido_usuario.Pp_mensaje_error = "Apellido no cargado";
            this.txt_apellido_usuario.Pp_nombre_campo = null;
            this.txt_apellido_usuario.Pp_nombre_tabla = null;
            this.txt_apellido_usuario.Pp_validable = false;
            this.txt_apellido_usuario.Size = new System.Drawing.Size(174, 24);
            this.txt_apellido_usuario.TabIndex = 3;
            this.toolTip1.SetToolTip(this.txt_apellido_usuario, "Apellido del usuario");
            // 
            // txt_nombre_usuario
            // 
            this.txt_nombre_usuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nombre_usuario.Location = new System.Drawing.Point(107, 110);
            this.txt_nombre_usuario.Name = "txt_nombre_usuario";
            this.txt_nombre_usuario.Pp_mensaje_error = "Nombre no cargado";
            this.txt_nombre_usuario.Pp_nombre_campo = null;
            this.txt_nombre_usuario.Pp_nombre_tabla = null;
            this.txt_nombre_usuario.Pp_validable = false;
            this.txt_nombre_usuario.Size = new System.Drawing.Size(174, 24);
            this.txt_nombre_usuario.TabIndex = 2;
            this.toolTip1.SetToolTip(this.txt_nombre_usuario, "Nombre del usuario");
            // 
            // cmb_perfil_usuario
            // 
            this.cmb_perfil_usuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_perfil_usuario.FormattingEnabled = true;
            this.cmb_perfil_usuario.Location = new System.Drawing.Point(388, 27);
            this.cmb_perfil_usuario.Name = "cmb_perfil_usuario";
            this.cmb_perfil_usuario.Pp_ConSeleccion = false;
            this.cmb_perfil_usuario.Pp_descripcion = "nombre";
            this.cmb_perfil_usuario.Pp_MensajeError = "debe seleccionar un perfil";
            this.cmb_perfil_usuario.Pp_Pk = "id_perfil";
            this.cmb_perfil_usuario.Pp_tabla = "Perfiles";
            this.cmb_perfil_usuario.Size = new System.Drawing.Size(164, 26);
            this.cmb_perfil_usuario.TabIndex = 4;
            this.toolTip1.SetToolTip(this.cmb_perfil_usuario, "Seleccione el perfil de usuario");
            // 
            // txt_email_usuario
            // 
            this.txt_email_usuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_email_usuario.Location = new System.Drawing.Point(387, 66);
            this.txt_email_usuario.Name = "txt_email_usuario";
            this.txt_email_usuario.Pp_mensaje_error = "Mail no cargado";
            this.txt_email_usuario.Pp_nombre_campo = null;
            this.txt_email_usuario.Pp_nombre_tabla = null;
            this.txt_email_usuario.Pp_validable = false;
            this.txt_email_usuario.Size = new System.Drawing.Size(165, 24);
            this.txt_email_usuario.TabIndex = 5;
            this.toolTip1.SetToolTip(this.txt_email_usuario, "Correo electronico del usuario");
            // 
            // txt_contraseña
            // 
            this.txt_contraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_contraseña.Location = new System.Drawing.Point(107, 70);
            this.txt_contraseña.Name = "txt_contraseña";
            this.txt_contraseña.Pp_mensaje_error = "Contraseña no cargada";
            this.txt_contraseña.Pp_nombre_campo = null;
            this.txt_contraseña.Pp_nombre_tabla = null;
            this.txt_contraseña.Pp_validable = false;
            this.txt_contraseña.Size = new System.Drawing.Size(174, 24);
            this.txt_contraseña.TabIndex = 1;
            this.toolTip1.SetToolTip(this.txt_contraseña, "Coloque una contraseña para su usuario");
            // 
            // txt_Id_user
            // 
            this.txt_Id_user.Enabled = false;
            this.txt_Id_user.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Id_user.Location = new System.Drawing.Point(107, 29);
            this.txt_Id_user.Name = "txt_Id_user";
            this.txt_Id_user.Pp_mensaje_error = null;
            this.txt_Id_user.Pp_nombre_campo = null;
            this.txt_Id_user.Pp_nombre_tabla = null;
            this.txt_Id_user.Pp_validable = false;
            this.txt_Id_user.Size = new System.Drawing.Size(174, 24);
            this.txt_Id_user.TabIndex = 0;
            this.toolTip1.SetToolTip(this.txt_Id_user, "Id de usuario asignado");
            // 
            // lbl_Cuil
            // 
            this.lbl_Cuil.AutoSize = true;
            this.lbl_Cuil.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Cuil.Location = new System.Drawing.Point(335, 111);
            this.lbl_Cuil.Name = "lbl_Cuil";
            this.lbl_Cuil.Size = new System.Drawing.Size(45, 18);
            this.lbl_Cuil.TabIndex = 6;
            this.lbl_Cuil.Text = "CUIL:";
            // 
            // lbl_ModificarUsuarios
            // 
            this.lbl_ModificarUsuarios.AutoSize = true;
            this.lbl_ModificarUsuarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ModificarUsuarios.Location = new System.Drawing.Point(47, 25);
            this.lbl_ModificarUsuarios.Name = "lbl_ModificarUsuarios";
            this.lbl_ModificarUsuarios.Size = new System.Drawing.Size(306, 39);
            this.lbl_ModificarUsuarios.TabIndex = 0;
            this.lbl_ModificarUsuarios.Text = "Modificar Usuarios";
            // 
            // btn_Aceptar
            // 
            this.btn_Aceptar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Aceptar.BackgroundImage")));
            this.btn_Aceptar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Aceptar.Location = new System.Drawing.Point(192, 310);
            this.btn_Aceptar.Name = "btn_Aceptar";
            this.btn_Aceptar.Size = new System.Drawing.Size(79, 66);
            this.btn_Aceptar.TabIndex = 3;
            this.btn_Aceptar.UseVisualStyleBackColor = true;
            this.btn_Aceptar.Click += new System.EventHandler(this.btn_Aceptar_Click);
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Cancelar.BackgroundImage")));
            this.btn_Cancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Cancelar.Location = new System.Drawing.Point(360, 310);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Size = new System.Drawing.Size(79, 66);
            this.btn_Cancelar.TabIndex = 4;
            this.btn_Cancelar.UseVisualStyleBackColor = true;
            this.btn_Cancelar.Click += new System.EventHandler(this.btn_Cancelar_Click);
            // 
            // frm_ModificacionUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(679, 388);
            this.Controls.Add(this.btn_Cancelar);
            this.Controls.Add(this.btn_Aceptar);
            this.Controls.Add(this.lbl_ModificarUsuarios);
            this.Controls.Add(this.groupBox1);
            this.Name = "frm_ModificacionUsuarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Modificar Usuarios";
            this.Load += new System.EventHandler(this.frm_ModificacionUsuarios_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_IdUsuario;
        private System.Windows.Forms.Label lbl_Password;
        private System.Windows.Forms.Label lbl_Perfil;
        private System.Windows.Forms.Label lbl_Email;
        private System.Windows.Forms.Label lbl_Nombre;
        private System.Windows.Forms.Label lbl_Apellido;
        private System.Windows.Forms.GroupBox groupBox1;
        private Clases.TextBox01 txt_Id_user;
        private System.Windows.Forms.Label lbl_Cuil;
        private Clases.TextBox01 txt_cuil_usuario;
        private Clases.TextBox01 txt_apellido_usuario;
        private Clases.TextBox01 txt_nombre_usuario;
        private Clases.TextBox01 txt_email_usuario;
        private Clases.TextBox01 txt_contraseña;
        private Clases.ComboBox01 cmb_perfil_usuario;
        private System.Windows.Forms.Label lbl_ModificarUsuarios;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button btn_Aceptar;
        private System.Windows.Forms.Button btn_Cancelar;
    }
}