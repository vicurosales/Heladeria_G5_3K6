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
    public partial class frm_MostrarUsuarios : Form
    {
        public string Id_Usuario { get; set; }
        public frm_MostrarUsuarios()
        {
            InitializeComponent();
        }

        private void frm_MostrarUsuarios_Load(object sender, EventArgs e)
        {
            Ne_usuario usuario = new Ne_usuario();
            cmb_perfil_usuario.CargarCombo();
            MostrarDatos(usuario.Recuperar_x_Id(Id_Usuario));
        }
        private void MostrarDatos(DataTable tabla)
        {
           
            cmb_perfil_usuario.SelectedValue = int.Parse(tabla.Rows[0]["id_perfil"].ToString());
            txt_nombre_usuario.Text = tabla.Rows[0]["nombre"].ToString();
            txt_apellido_usuario.Text = tabla.Rows[0]["apellido"].ToString();
            txt_contraseña.Text = tabla.Rows[0]["password"].ToString();
            txt_cuil_usuario.Text = tabla.Rows[0]["CUIL"].ToString();
            txt_email_usuario.Text = tabla.Rows[0]["email"].ToString();
            txt_Id_user.Text = tabla.Rows[0]["id_usuario"].ToString();

        }


        private void btn_Aceptar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
