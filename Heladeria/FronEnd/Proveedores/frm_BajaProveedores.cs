using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Heladeria.Negocio;
using Heladeria.Clases;

namespace Heladeria.FronEnd.Proveedores
{
    public partial class frm_BajaProveedores : Form
    {
        internal string cod_proveedor;

        public string Cod_proveedor { get; set; }
        public frm_BajaProveedores()
        {
            InitializeComponent();
        }

        private void MostrarDatos(DataTable tabla)
        {
            textBox_cuit.Text = tabla.Rows[0]["dni"].ToString();
            txt_razon_social.Text = tabla.Rows[0]["razon_social"].ToString();
            txt_numero.Text = tabla.Rows[0]["numero"].ToString();
            textBox_email.Text = tabla.Rows[0]["email"].ToString();
            textBox_telefono.Text = tabla.Rows[0]["telefono1"].ToString();
            textBox_calle.Text = tabla.Rows[0]["calle"].ToString();



        }


        private void frm_BajaProveedores_Load(object sender, EventArgs e)
        {
            Ne_proveedor proveedor = new Ne_proveedor();
            MostrarDatos(proveedor.Recuperar_x_Id(cod_proveedor));

        }

        private void button_Aceptar_Click(object sender, EventArgs e)
        {
            Ne_proveedor proveedor = new Ne_proveedor();
            if (MessageBox.Show("¿Está seguro de que desea borrar al proveedor?", "IMPORTANTE", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                proveedor.Borrar(cod_proveedor);
                MessageBox.Show("Se ha borrado el registro exitosamente.");
                this.Close();
            }
        }



    }
}

