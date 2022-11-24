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
    public partial class frm_AltaUsuarios : Form
    {
        public frm_AltaUsuarios()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btn_Salir_Alta_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frm_AltaUsuarios_Load(object sender, EventArgs e)
        {
            Ne_usuario usuario = new Ne_usuario();    
            cmb_perfil_usuario.CargarCombo();
            txt_Id_user.Text =usuario.Ultimo_Numero_Id_Usuario(); 
            
            
        }

        private void btn_Alta_Usuario_Click(object sender, EventArgs e)
        {
            TratamientoEspeciales Tratamiento = new TratamientoEspeciales();
            
            if (Tratamiento.Validar(this.Controls) == TratamientoEspeciales.Resultado.correcto)
            {
                Ne_usuario usuario = new Ne_usuario();
                usuario.Pp_apellido = txt_apellido_usuario.Text;
                usuario.Pp_Cuil = txt_cuil_usuario.Text;
                usuario.Pp_email = txt_email_usuario.Text;
                usuario.Pp_nombres = txt_nombre_usuario.Text;
                usuario.Pp_id_usuario = txt_Id_user.Text;
                usuario.Pp_password = txt_contraseña.Text;
                usuario.Pp_id_perfil = cmb_perfil_usuario.SelectedValue.ToString();
                usuario.Pp_borrado = "1";

                usuario.Insertar();
                this.Close();

            }

            else
            {
                MessageBox.Show("No se pudo grabar el usuario");
                return;
            }
        }

        private void cmb_perfil_usuario_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lbl_IdUsuario_Click(object sender, EventArgs e)
        {

        }

        private void lbl_Password_Click(object sender, EventArgs e)
        {

        }

        private void lbl_Nombre_Click(object sender, EventArgs e)
        {

        }

        private void lbl_Apellido_Click(object sender, EventArgs e)
        {

        }

        private void txt_apellido_usuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_nombre_usuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_contraseña_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbl_Perfil_Click(object sender, EventArgs e)
        {

        }

        private void lbl_Email_Click(object sender, EventArgs e)
        {

        }

        private void lbl_Cuil_Click(object sender, EventArgs e)
        {

        }

        private void lbl_Estado_Click(object sender, EventArgs e)
        {

        }

        private void cmb_estado_usuario_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txt_cuil_usuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_email_usuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_Id_user_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
