
namespace Heladeria.FronEnd
{
    partial class frm_ABM_Proveedor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_ABM_Proveedor));
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btn_Buscar = new System.Windows.Forms.Button();
            this.txt_Patron = new System.Windows.Forms.TextBox();
            this.chk_Todos_Usuarios = new System.Windows.Forms.CheckBox();
            this.btn_Salir = new System.Windows.Forms.Button();
            this.btn_Baja = new System.Windows.Forms.Button();
            this.btn_Modificar = new System.Windows.Forms.Button();
            this.btn_Alta = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgr_Proveedores = new System.Windows.Forms.DataGridView();
            this.dni = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.razon_social = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefono1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.calle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbl_Patron = new System.Windows.Forms.Label();
            this.lbl_ABM = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgr_Proveedores)).BeginInit();
            this.SuspendLayout();
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
            this.toolTip1.SetToolTip(this.btn_Buscar, "Boton para inicar la busqueda ");
            this.btn_Buscar.UseVisualStyleBackColor = true;
            this.btn_Buscar.Click += new System.EventHandler(this.btn_Buscar_Click);
            // 
            // txt_Patron
            // 
            this.txt_Patron.Location = new System.Drawing.Point(84, 29);
            this.txt_Patron.Name = "txt_Patron";
            this.txt_Patron.Size = new System.Drawing.Size(121, 24);
            this.txt_Patron.TabIndex = 0;
            this.toolTip1.SetToolTip(this.txt_Patron, "Puede ingresar un texto completo o una fraccion del mismo para buscar en el nombr" +
        "e d");
            // 
            // chk_Todos_Usuarios
            // 
            this.chk_Todos_Usuarios.AutoSize = true;
            this.chk_Todos_Usuarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chk_Todos_Usuarios.Location = new System.Drawing.Point(9, 96);
            this.chk_Todos_Usuarios.Name = "chk_Todos_Usuarios";
            this.chk_Todos_Usuarios.Size = new System.Drawing.Size(183, 22);
            this.chk_Todos_Usuarios.TabIndex = 5;
            this.chk_Todos_Usuarios.Text = "Todos los Proveedores";
            this.toolTip1.SetToolTip(this.chk_Todos_Usuarios, "Selecciona todos los usuarios de la BD");
            this.chk_Todos_Usuarios.UseVisualStyleBackColor = true;
            // 
            // btn_Salir
            // 
            this.btn_Salir.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Salir.BackgroundImage")));
            this.btn_Salir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Salir.Location = new System.Drawing.Point(687, 407);
            this.btn_Salir.Name = "btn_Salir";
            this.btn_Salir.Size = new System.Drawing.Size(71, 66);
            this.btn_Salir.TabIndex = 10;
            this.btn_Salir.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.toolTip1.SetToolTip(this.btn_Salir, "Salir");
            this.btn_Salir.UseVisualStyleBackColor = true;
            this.btn_Salir.Click += new System.EventHandler(this.btn_Salir_Click_1);
            // 
            // btn_Baja
            // 
            this.btn_Baja.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Baja.BackgroundImage")));
            this.btn_Baja.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Baja.Enabled = false;
            this.btn_Baja.Location = new System.Drawing.Point(259, 407);
            this.btn_Baja.Name = "btn_Baja";
            this.btn_Baja.Size = new System.Drawing.Size(71, 66);
            this.btn_Baja.TabIndex = 9;
            this.btn_Baja.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.toolTip1.SetToolTip(this.btn_Baja, "Boton para eliminar un usuario");
            this.btn_Baja.UseVisualStyleBackColor = true;
            this.btn_Baja.Click += new System.EventHandler(this.btn_Baja_Click_1);
            // 
            // btn_Modificar
            // 
            this.btn_Modificar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Modificar.BackgroundImage")));
            this.btn_Modificar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Modificar.Enabled = false;
            this.btn_Modificar.Location = new System.Drawing.Point(182, 407);
            this.btn_Modificar.Name = "btn_Modificar";
            this.btn_Modificar.Size = new System.Drawing.Size(71, 66);
            this.btn_Modificar.TabIndex = 8;
            this.btn_Modificar.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.toolTip1.SetToolTip(this.btn_Modificar, "Boton para editar un usuario");
            this.btn_Modificar.UseVisualStyleBackColor = true;
            this.btn_Modificar.Click += new System.EventHandler(this.btn_Modificar_Click_1);
            // 
            // btn_Alta
            // 
            this.btn_Alta.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Alta.BackgroundImage")));
            this.btn_Alta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Alta.Location = new System.Drawing.Point(105, 407);
            this.btn_Alta.Name = "btn_Alta";
            this.btn_Alta.Size = new System.Drawing.Size(71, 66);
            this.btn_Alta.TabIndex = 7;
            this.btn_Alta.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.toolTip1.SetToolTip(this.btn_Alta, "Boton para agregar un usuario");
            this.btn_Alta.UseVisualStyleBackColor = true;
            this.btn_Alta.Click += new System.EventHandler(this.btn_Alta_Click_1);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dgr_Proveedores);
            this.groupBox1.Controls.Add(this.lbl_Patron);
            this.groupBox1.Controls.Add(this.btn_Buscar);
            this.groupBox1.Controls.Add(this.txt_Patron);
            this.groupBox1.Controls.Add(this.chk_Todos_Usuarios);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(105, 80);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(659, 321);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtros";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(526, 283);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 18);
            this.label2.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(371, 283);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 18);
            this.label1.TabIndex = 19;
            this.label1.Text = "Cantidad de registros:";
            // 
            // dgr_Proveedores
            // 
            this.dgr_Proveedores.AllowUserToAddRows = false;
            this.dgr_Proveedores.AllowUserToDeleteRows = false;
            this.dgr_Proveedores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgr_Proveedores.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dni,
            this.razon_social,
            this.Email,
            this.telefono1,
            this.calle,
            this.numero});
            this.dgr_Proveedores.Location = new System.Drawing.Point(6, 124);
            this.dgr_Proveedores.Name = "dgr_Proveedores";
            this.dgr_Proveedores.ReadOnly = true;
            this.dgr_Proveedores.Size = new System.Drawing.Size(644, 150);
            this.dgr_Proveedores.TabIndex = 16;
            // 
            // dni
            // 
            this.dni.HeaderText = "CUIT";
            this.dni.Name = "dni";
            this.dni.ReadOnly = true;
            // 
            // razon_social
            // 
            this.razon_social.HeaderText = "Razón Social";
            this.razon_social.Name = "razon_social";
            this.razon_social.ReadOnly = true;
            // 
            // Email
            // 
            this.Email.HeaderText = "Email";
            this.Email.Name = "Email";
            this.Email.ReadOnly = true;
            // 
            // telefono1
            // 
            this.telefono1.HeaderText = "Teléfono";
            this.telefono1.Name = "telefono1";
            this.telefono1.ReadOnly = true;
            // 
            // calle
            // 
            this.calle.HeaderText = "Calle";
            this.calle.Name = "calle";
            this.calle.ReadOnly = true;
            // 
            // numero
            // 
            this.numero.HeaderText = "Número";
            this.numero.Name = "numero";
            this.numero.ReadOnly = true;
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
            // lbl_ABM
            // 
            this.lbl_ABM.AutoSize = true;
            this.lbl_ABM.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ABM.Location = new System.Drawing.Point(89, 25);
            this.lbl_ABM.Name = "lbl_ABM";
            this.lbl_ABM.Size = new System.Drawing.Size(390, 39);
            this.lbl_ABM.TabIndex = 6;
            this.lbl_ABM.Text = "Gestión de Proveedores";
            // 
            // frm_ABM_Proveedor
            // 
            this.ClientSize = new System.Drawing.Size(853, 498);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_Salir);
            this.Controls.Add(this.btn_Baja);
            this.Controls.Add(this.btn_Modificar);
            this.Controls.Add(this.btn_Alta);
            this.Controls.Add(this.lbl_ABM);
            this.Name = "frm_ABM_Proveedor";
            this.Text = "Gestión de Proveedores";
            this.Load += new System.EventHandler(this.frm_ABM_Proveedor_Load_2);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgr_Proveedores)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button btn_Buscar;
        private System.Windows.Forms.TextBox txt_Patron;
        private System.Windows.Forms.CheckBox chk_Todos_Usuarios;
        private System.Windows.Forms.Button btn_Salir;
        private System.Windows.Forms.Button btn_Baja;
        private System.Windows.Forms.Button btn_Modificar;
        private System.Windows.Forms.Button btn_Alta;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgr_Proveedores;
        private System.Windows.Forms.Label lbl_Patron;
        private System.Windows.Forms.Label lbl_ABM;
        private System.Windows.Forms.DataGridViewTextBoxColumn dni;
        private System.Windows.Forms.DataGridViewTextBoxColumn razon_social;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefono1;
        private System.Windows.Forms.DataGridViewTextBoxColumn calle;
        private System.Windows.Forms.DataGridViewTextBoxColumn numero;
    }
}