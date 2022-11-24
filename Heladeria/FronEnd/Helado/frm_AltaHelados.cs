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
    public partial class frm_AltaHelados : Form
    {
        public frm_AltaHelados()
        {
            InitializeComponent();
        }


        private void btn_Alta_Helado_Load(object sender, EventArgs e)
        {
            
                      

        }

        private void btn_Alta_Usuario_Click(object sender, EventArgs e)
        {

          
            TratamientoEspeciales Tratamiento = new TratamientoEspeciales();

            if (Tratamiento.Validar(this.Controls) == TratamientoEspeciales.Resultado.correcto)
            {
                Ne_helado helado = new Ne_helado();

                helado.Pp_cod_helado = txt_codHelado.Text;
                helado.Pp_nombre = txt_nombreHelado.Text;
                helado.Pp_descripcion = txt_descripcion.Text;
                helado.Pp_cantidad_stock = txt_stock.Text;
                helado.Pp_tipo_helado = cmb_TipoHelado.SelectedValue.ToString();
                helado.Pp_borrado = "0";

           
                helado.Insertar();
                this.Close();


                return;


            }

            else
            {
                MessageBox.Show("Ocurrió un error al registrar el usuario.");
                return;
            }
        }


       
        private void btn_Salir_Alta_Click(object sender, EventArgs e)
        {
            MessageBox.Show("No se guardaron los cambios.");

            this.Close();
        }

        private void frm_AltaHelados_Load(object sender, EventArgs e)
        {
            Ne_helado helado = new Ne_helado();
            cmb_TipoHelado.Pp_tabla = "Tipo_Helado";
            cmb_TipoHelado.Pp_Pk = "cod_tipo";
            cmb_TipoHelado.Pp_descripcion = "nombre";
            cmb_TipoHelado.CargarCombo();
            txt_codHelado.Text = helado.Ultimo_Numero_Id_Helado();


        }
    }
}
