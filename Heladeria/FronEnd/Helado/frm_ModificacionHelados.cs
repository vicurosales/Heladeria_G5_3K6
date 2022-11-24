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
    public partial class frm_ModificacionHelado : Form
    {
        internal string cod_helado;

        public string Cod_helado { get; set; }
        public frm_ModificacionHelado()
        {
            InitializeComponent();
        }

        private void frm_ModificacionHelado_Load_1(object sender, EventArgs e)
        {
            Ne_helado helado = new Ne_helado();
            cmb_tipoHelado.CargarCombo();
            MostrarDatos(helado.Recuperar_x_Id(cod_helado));
        }

        private void MostrarDatos(DataTable tabla)
        {
            textBox_IDhelado.Text = tabla.Rows[0]["cod_helado"].ToString();
            cmb_tipoHelado.SelectedValue = int.Parse(tabla.Rows[0]["tipo_helado"].ToString());
            txt_nombre.Text = tabla.Rows[0]["nombre"].ToString();
            txt_descripcion.Text = tabla.Rows[0]["descripcion"].ToString();
            txt_stock.Text = tabla.Rows[0]["cantidad_stock"].ToString();


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
            TratamientoEspeciales Tratamiento = new TratamientoEspeciales();

            if (Tratamiento.Validar(this.Controls) == TratamientoEspeciales.Resultado.correcto)
            {
                Ne_helado helado = new Ne_helado();
                helado.Pp_nombre = txt_nombre.Text;
                helado.Pp_descripcion = txt_descripcion.Text;
                helado.Pp_tipo_helado = cmb_tipoHelado.SelectedValue.ToString();

                helado.Pp_borrado = "0";

                if (MessageBox.Show("Esta seguro de que desea realizar los cambios?", "IMPORTANTE", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    helado.Modificar(cod_helado);
                    this.Close();
                }
            }
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

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void frm_ModificacionHelado_Load(object sender, EventArgs e)
        {
            Ne_helado helado = new Ne_helado();
            cmb_tipoHelado.CargarCombo();
            MostrarDatos(helado.Recuperar_x_Id(cod_helado));
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

            TratamientoEspeciales Tratamiento = new TratamientoEspeciales();

            if (Tratamiento.Validar(this.Controls) == TratamientoEspeciales.Resultado.correcto)
            {
                Ne_helado helado = new Ne_helado();
                helado.Pp_cod_helado = textBox_IDhelado.Text;
                helado.Pp_nombre = txt_nombre.Text;
                helado.Pp_descripcion = txt_descripcion.Text;
                helado.Pp_tipo_helado = cmb_tipoHelado.SelectedValue.ToString();
                helado.Pp_borrado = "0";

                helado.Modificar(helado.Pp_cod_helado);
                this.Close();
            }
            else
            {
                MessageBox.Show("No se pudieron modificar los datos.");
                return;
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("No se realizaron cambios.", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            this.Close();
            
        }

        private void txt_stock_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void txt_descripcion_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void cmb_tipoHelado_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void lbl_Descripcion_Click_1(object sender, EventArgs e)
        {

        }

        private void lbl_Perfil_Click_1(object sender, EventArgs e)
        {

        }

        private void txt_nombre_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void lbl_ModHelados_Click(object sender, EventArgs e)
        {

        }

        private void label_nombre_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void textBox_IDhelado_TextChanged(object sender, EventArgs e)
        {

        }
    }
    
}
