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
    public partial class frm_BorrarHelados : Form
    {
        public DataGridViewLinkColumn Cod_helado { get; internal set; }
        public string cod_helado { get; set; }
        public frm_BorrarHelados()
        {
            InitializeComponent();
        }



            private void frm_BorrarHelados_Load(object sender, EventArgs e)
        {
            Ne_helado usuario = new Ne_helado();
            cmb_tipoHelado.CargarCombo();
            MostrarDatos(usuario.Recuperar_x_Id(cod_helado));
        }


        private void MostrarDatos(DataTable tabla)
        {

            cmb_tipoHelado.SelectedValue = int.Parse(tabla.Rows[0]["tipo_helado"].ToString());
            txt_cod_helado.Text = tabla.Rows[0]["cod_helado"].ToString();
            txt_descripcion.Text = tabla.Rows[0]["descripcion"].ToString();
            txt_nombre.Text = tabla.Rows[0]["nombre"].ToString();
        }



        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btn_Aceptar_Click(object sender, EventArgs e)
        {
            Ne_helado helado = new Ne_helado();
            if (MessageBox.Show("Esta Seguro de Borrar?", "IMPORTANTE", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                helado.borrar(cod_helado);
                MessageBox.Show("Se ha eliminado el helado correctamente.");
                this.Close();
         
            }



           
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }






    }
