using Heladeria.Clases;
using Heladeria.Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Heladeria.FronEnd.Helado
{
    public partial class frm_AltaProveedores : Form
    {
        public frm_AltaProveedores()
        {
            InitializeComponent();
        }


        private void btn_Alta_Helado_Load(object sender, EventArgs e)
        {



        }

        private void btn_Alta_Usuario_Click(object sender, EventArgs e)
        {

        }

        private void btn_Salir_Alta_Click(object sender, EventArgs e)
        {
            this.Close();
        }

          private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_AltaProveedores));
            this.lbl_ModProveedores = new System.Windows.Forms.Label();
            this.button_Aceptar = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBox_email = new Heladeria.Clases.TextBox01();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_calle = new Heladeria.Clases.TextBox01();
            this.lbl_mail = new System.Windows.Forms.Label();
            this.txt_razon_social = new Heladeria.Clases.TextBox01();
            this.txt_numero = new Heladeria.Clases.TextBox01();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_telefono = new Heladeria.Clases.TextBox01();
            this.label1 = new System.Windows.Forms.Label();
            this.label_razon_social = new System.Windows.Forms.Label();
            this.txt_cuit = new Heladeria.Clases.TextBox01();
            this.lbl_cuit = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_ModProveedores
            // 
            this.lbl_ModProveedores.AccessibleRole = System.Windows.Forms.AccessibleRole.IpAddress;
            this.lbl_ModProveedores.AutoSize = true;
            this.lbl_ModProveedores.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ModProveedores.Location = new System.Drawing.Point(116, 46);
            this.lbl_ModProveedores.Name = "lbl_ModProveedores";
            this.lbl_ModProveedores.Size = new System.Drawing.Size(365, 39);
            this.lbl_ModProveedores.TabIndex = 28;
            this.lbl_ModProveedores.Text = "Registrar Proveedores";
            // 
            // button_Aceptar
            // 
            this.button_Aceptar.AccessibleRole = System.Windows.Forms.AccessibleRole.IpAddress;
            this.button_Aceptar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_Aceptar.BackgroundImage")));
            this.button_Aceptar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_Aceptar.Location = new System.Drawing.Point(281, 325);
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
            this.button2.Location = new System.Drawing.Point(413, 325);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(84, 81);
            this.button2.TabIndex = 30;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
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
            this.groupBox2.Controls.Add(this.txt_cuit);
            this.groupBox2.Controls.Add(this.lbl_cuit);
            this.groupBox2.Location = new System.Drawing.Point(123, 96);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(596, 223);
            this.groupBox2.TabIndex = 31;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Realizar el registro de un Proveedor.";
            // 
            // textBox_email
            // 
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
            // txt_razon_social
            // 
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
            // txt_cuit
            // 
            this.txt_cuit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_cuit.Location = new System.Drawing.Point(114, 30);
            this.txt_cuit.Name = "txt_cuit";
            this.txt_cuit.Pp_mensaje_error = "";
            this.txt_cuit.Pp_nombre_campo = null;
            this.txt_cuit.Pp_nombre_tabla = null;
            this.txt_cuit.Pp_validable = false;
            this.txt_cuit.Size = new System.Drawing.Size(171, 24);
            this.txt_cuit.TabIndex = 18;
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
            // frm_AltaProveedores
            // 
            this.ClientSize = new System.Drawing.Size(835, 452);
            this.Controls.Add(this.lbl_ModProveedores);
            this.Controls.Add(this.button_Aceptar);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.groupBox2);
            this.Name = "frm_AltaProveedores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registrar un Proveedor";
            this.Load += new System.EventHandler(this.frm_AltaProveedores_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void frm_AltaProveedores_Load(object sender, EventArgs e)
        {

        }

        private Label lbl_ModProveedores;
        private Button button_Aceptar;
        private Button button2;
        private GroupBox groupBox2;
        private TextBox01 textBox_email;
        private Label label3;
        private TextBox01 textBox_calle;
        private Label lbl_mail;
        private TextBox01 txt_razon_social;
        private TextBox01 txt_numero;
        private Label label2;
        private TextBox01 textBox_telefono;
        private Label label1;
        private Label label_razon_social;
        private TextBox01 txt_cuit;
        private Label lbl_cuit;

        private void button_Aceptar_Click(object sender, EventArgs e)
        {
            TratamientoEspeciales Tratamiento = new TratamientoEspeciales();

            if (Tratamiento.Validar(this.Controls) == TratamientoEspeciales.Resultado.correcto)
            {
                Ne_proveedor proveedor = new Ne_proveedor();
                proveedor.Pp_dni = txt_cuit.Text;
                proveedor.Pp_razon_social = txt_razon_social.Text;
                proveedor.Pp_numero = txt_numero.Text;
                proveedor.Pp_calle = textBox_calle.Text;
                proveedor.Pp_email = textBox_email.Text;
                proveedor.Pp_telefono1 = textBox_telefono.Text;

                proveedor.Insertar();
                this.Close();

            }

            else
            {
                MessageBox.Show("Ocurrió un error al registrar el proveedor.");
                return;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Seguro que desea salir? Se perderán los cambios.", "IMPORTANTE", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                this.Close();
        }
    }
}
