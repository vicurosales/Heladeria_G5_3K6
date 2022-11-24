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
    public partial class frm_ModificacionUsuarios : Form
    {
        public string Id_Usuario { get; set; }
        public frm_ModificacionUsuarios()
        {
            InitializeComponent();
        }

        private void frm_ModificacionUsuarios_Load(object sender, EventArgs e)
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
            TratamientoEspeciales Tratamiento = new TratamientoEspeciales();

            if (Tratamiento.Validar(this.Controls) == TratamientoEspeciales.Resultado.correcto)
            {
                Ne_usuario usuario = new Ne_usuario();
                usuario.Pp_apellido = txt_apellido_usuario.Text;
                usuario.Pp_Cuil = txt_cuil_usuario.Text;
                usuario.Pp_email = txt_email_usuario.Text;
                usuario.Pp_nombres = txt_nombre_usuario.Text;
                usuario.Pp_id_usuario = Id_Usuario;
                usuario.Pp_password = txt_contraseña.Text;
                usuario.Pp_id_perfil = cmb_perfil_usuario.SelectedValue.ToString();
                usuario.Pp_borrado = "1";

                usuario.Modificar();
                MessageBox.Show("Se cambiaron los datos correctamente", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.Close();
            }
            else
            {
                MessageBox.Show("No se pudo modificar el usuario");
                return;
            }
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
