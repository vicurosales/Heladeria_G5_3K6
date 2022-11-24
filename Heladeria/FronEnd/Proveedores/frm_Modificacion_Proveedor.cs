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

namespace Heladeria.FronEnd
{
    public partial class frm_Modificacion_Proveedor : Form
    {
        internal string cod_proveedor;

        public string Cod_proveedor { get; set; }
        public frm_Modificacion_Proveedor()
        {
            InitializeComponent();
        }

        private void frm_ModificacionHelado_Load_1(object sender, EventArgs e)
        {
            Ne_proveedor proveedor = new Ne_proveedor();
         
            MostrarDatos(proveedor.Recuperar_x_Id(cod_proveedor));
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






        private void lbl_BorrarUsuarios_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btn_Aceptar_Click_1(object sender, EventArgs e)
        {

        }
        private void btn_Cancelar_Click_1(object sender, EventArgs e)
        {


        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txt_stock_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txt_descripcion_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbl_Descripcion_Click(object sender, EventArgs e)
        {

        }

        private void lbl_Perfil_Click(object sender, EventArgs e)
        {

        }

        private void txt_nombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmb_tipoHelado_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lbl_Nombre_Click(object sender, EventArgs e)
        {

        }

        private void frm_ModificacionHelado_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("No se realizaron cambios.", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            this.Close();

        }

        private void frm_Modificacion_Proveedor_Load(object sender, EventArgs e)
        {
            Ne_proveedor proveedor = new Ne_proveedor();
            MostrarDatos(proveedor.Recuperar_x_Id(cod_proveedor));
        }


        private void button_Aceptar_Click(object sender, EventArgs e)
        {
            TratamientoEspeciales Tratamiento = new TratamientoEspeciales();

            if (Tratamiento.Validar(this.Controls) == TratamientoEspeciales.Resultado.correcto)
            {
                Ne_proveedor proveedor = new Ne_proveedor();
                proveedor.Pp_razon_social = txt_razon_social.Text;
                proveedor.Pp_numero = txt_numero.Text;
                proveedor.Pp_calle = textBox_calle.Text;
                proveedor.Pp_email = textBox_email.Text;
                proveedor.Pp_telefono1 = textBox_telefono.Text;


                proveedor.Pp_borrado = "0";

                if (MessageBox.Show("Esta seguro de que desea realizar los cambios?", "IMPORTANTE", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    proveedor.Modificar(cod_proveedor);
                    this.Close();
                }
            }
        }

        private void button2_Click_2(object sender, EventArgs e)
        {
                if(MessageBox.Show("¿Seguro que desea salir? Se perderán los cambios.", "IMPORTANTE", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                this.Close();
            }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
    }


