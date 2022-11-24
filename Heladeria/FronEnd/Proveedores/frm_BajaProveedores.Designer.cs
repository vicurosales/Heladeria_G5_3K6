
namespace Heladeria.FronEnd.Proveedores
{
    partial class frm_BajaProveedores
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_BajaProveedores));
            this.lbl_ModProveedores = new System.Windows.Forms.Label();
            this.button_Aceptar = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.lbl_mail = new System.Windows.Forms.Label();
            this.label_razon_social = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBox_email = new Heladeria.Clases.TextBox01();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_calle = new Heladeria.Clases.TextBox01();
            this.txt_razon_social = new Heladeria.Clases.TextBox01();
            this.txt_numero = new Heladeria.Clases.TextBox01();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_telefono = new Heladeria.Clases.TextBox01();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_cuit = new Heladeria.Clases.TextBox01();
            this.lbl_cuit = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_ModProveedores
            // 
            this.lbl_ModProveedores.AccessibleRole = System.Windows.Forms.AccessibleRole.IpAddress;
            this.lbl_ModProveedores.AutoSize = true;
            this.lbl_ModProveedores.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ModProveedores.Location = new System.Drawing.Point(99, 45);
            this.lbl_ModProveedores.Name = "lbl_ModProveedores";
            this.lbl_ModProveedores.Size = new System.Drawing.Size(339, 39);
            this.lbl_ModProveedores.TabIndex = 28;
            this.lbl_ModProveedores.Text = "Baja de Proveedores";
            // 
            // button_Aceptar
            // 
            this.button_Aceptar.AccessibleRole = System.Windows.Forms.AccessibleRole.IpAddress;
            this.button_Aceptar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_Aceptar.BackgroundImage")));
            this.button_Aceptar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_Aceptar.Location = new System.Drawing.Point(264, 324);
            this.button_Aceptar.Name = "button_Aceptar";
            this.button_Aceptar.Size = new System.Drawing.Size(82, 81);
            this.button_Aceptar.TabIndex = 29;
            this.button_Aceptar.UseVisualStyleBackColor = true;
            this.button_Aceptar.Click += new System.EventHandler(this.button_Aceptar_Click);
            // 
            // button2
            // 
            this.button2.AccessibleRole = System.Windows.Forms.AccessibleRole.IpAddress;
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.Location = new System.Drawing.Point(396, 324);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(84, 81);
            this.button2.TabIndex = 30;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // lbl_mail
            // 
            this.lbl_mail.AutoSize = true;
            this.lbl_mail.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_mail.Location = new System.Drawing.Point(10, 102);
            this.lbl_mail.Name = "lbl_mail";
            this.lbl_mail.Size = new System.Drawing.Size(49, 18);
            this.lbl_mail.TabIndex = 22;
            this.lbl_mail.Text = "Email:";
            // 
            // label_razon_social
            // 
            this.label_razon_social.AutoSize = true;
            this.label_razon_social.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_razon_social.Location = new System.Drawing.Point(10, 64);
            this.label_razon_social.Name = "label_razon_social";
            this.label_razon_social.Size = new System.Drawing.Size(101, 18);
            this.label_razon_social.TabIndex = 16;
            this.label_razon_social.Text = "Razón Social:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBox_email);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.textBox_calle);
            this.groupBox2.Controls.Add(this.lbl_mail);
            this.groupBox2.Controls.Add(this.txt_razon_social);
            this.groupBox2.Controls.Add(this.txt_numero);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.textBox_telefono);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label_razon_social);
            this.groupBox2.Controls.Add(this.textBox_cuit);
            this.groupBox2.Controls.Add(this.lbl_cuit);
            this.groupBox2.Location = new System.Drawing.Point(106, 95);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(596, 223);
            this.groupBox2.TabIndex = 31;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Eliminar a un Proveedor.";
            // 
            // textBox_email
            // 
            this.textBox_email.Enabled = false;
            this.textBox_email.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_email.Location = new System.Drawing.Point(114, 96);
            this.textBox_email.Name = "textBox_email";
            this.textBox_email.Pp_mensaje_error = "Nombre no cargado";
            this.textBox_email.Pp_nombre_campo = null;
            this.textBox_email.Pp_nombre_tabla = null;
            this.textBox_email.Pp_validable = false;
            this.textBox_email.Size = new System.Drawing.Size(171, 24);
            this.textBox_email.TabIndex = 32;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(377, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 18);
            this.label3.TabIndex = 33;
            this.label3.Text = "Número:";
            // 
            // textBox_calle
            // 
            this.textBox_calle.Enabled = false;
            this.textBox_calle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_calle.Location = new System.Drawing.Point(114, 138);
            this.textBox_calle.Name = "textBox_calle";
            this.textBox_calle.Pp_mensaje_error = "Nombre no cargado";
            this.textBox_calle.Pp_nombre_campo = null;
            this.textBox_calle.Pp_nombre_tabla = null;
            this.textBox_calle.Pp_validable = false;
            this.textBox_calle.Size = new System.Drawing.Size(222, 24);
            this.textBox_calle.TabIndex = 30;
            // 
            // txt_razon_social
            // 
            this.txt_razon_social.Enabled = false;
            this.txt_razon_social.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_razon_social.Location = new System.Drawing.Point(114, 60);
            this.txt_razon_social.Name = "txt_razon_social";
            this.txt_razon_social.Pp_mensaje_error = "Contraseña no cargada";
            this.txt_razon_social.Pp_nombre_campo = null;
            this.txt_razon_social.Pp_nombre_tabla = null;
            this.txt_razon_social.Pp_validable = false;
            this.txt_razon_social.Size = new System.Drawing.Size(451, 24);
            this.txt_razon_social.TabIndex = 18;
            // 
            // txt_numero
            // 
            this.txt_numero.Enabled = false;
            this.txt_numero.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_numero.Location = new System.Drawing.Point(445, 141);
            this.txt_numero.Name = "txt_numero";
            this.txt_numero.Pp_mensaje_error = "Nombre no cargado";
            this.txt_numero.Pp_nombre_campo = null;
            this.txt_numero.Pp_nombre_tabla = null;
            this.txt_numero.Pp_validable = false;
            this.txt_numero.Size = new System.Drawing.Size(120, 24);
            this.txt_numero.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(10, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 18);
            this.label2.TabIndex = 31;
            this.label2.Text = "Calle";
            // 
            // textBox_telefono
            // 
            this.textBox_telefono.Enabled = false;
            this.textBox_telefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_telefono.Location = new System.Drawing.Point(413, 101);
            this.textBox_telefono.Name = "textBox_telefono";
            this.textBox_telefono.Pp_mensaje_error = "Nombre no cargado";
            this.textBox_telefono.Pp_nombre_campo = null;
            this.textBox_telefono.Pp_nombre_tabla = null;
            this.textBox_telefono.Pp_validable = false;
            this.textBox_telefono.Size = new System.Drawing.Size(152, 24);
            this.textBox_telefono.TabIndex = 28;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(329, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 18);
            this.label1.TabIndex = 29;
            this.label1.Text = "Teléfono:";
            // 
            // textBox_cuit
            // 
            this.textBox_cuit.Enabled = false;
            this.textBox_cuit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_cuit.Location = new System.Drawing.Point(114, 30);
            this.textBox_cuit.Name = "textBox_cuit";
            this.textBox_cuit.Pp_mensaje_error = "";
            this.textBox_cuit.Pp_nombre_campo = null;
            this.textBox_cuit.Pp_nombre_tabla = null;
            this.textBox_cuit.Pp_validable = false;
            this.textBox_cuit.Size = new System.Drawing.Size(171, 24);
            this.textBox_cuit.TabIndex = 18;
            // 
            // lbl_cuit
            // 
            this.lbl_cuit.AutoSize = true;
            this.lbl_cuit.Enabled = false;
            this.lbl_cuit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cuit.Location = new System.Drawing.Point(10, 30);
            this.lbl_cuit.Name = "lbl_cuit";
            this.lbl_cuit.Size = new System.Drawing.Size(46, 18);
            this.lbl_cuit.TabIndex = 18;
            this.lbl_cuit.Text = "CUIT:";
            // 
            // frm_BajaProveedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_ModProveedores);
            this.Controls.Add(this.button_Aceptar);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.groupBox2);
            this.Name = "frm_BajaProveedores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Eliminar un Proveedor";
            this.Load += new System.EventHandler(this.frm_BajaProveedores_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_ModProveedores;
        private System.Windows.Forms.Button button_Aceptar;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label lbl_mail;
        private System.Windows.Forms.Label label_razon_social;
        private System.Windows.Forms.GroupBox groupBox2;
        private Clases.TextBox01 textBox_email;
        private System.Windows.Forms.Label label3;
        private Clases.TextBox01 textBox_calle;
        private Clases.TextBox01 txt_razon_social;
        private Clases.TextBox01 txt_numero;
        private System.Windows.Forms.Label label2;
        private Clases.TextBox01 textBox_telefono;
        private System.Windows.Forms.Label label1;
        private Clases.TextBox01 textBox_cuit;
        private System.Windows.Forms.Label lbl_cuit;
    }
}