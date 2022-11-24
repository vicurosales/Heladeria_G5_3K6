using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Heladeria.FronEnd;
using Heladeria.Negocio;


namespace Heladeria.FronEnd
{
    public partial class frm_ABM_Usuario : Form
    {
        public string Id_Usuario { get; set; }
        public frm_ABM_Usuario()
        {
            InitializeComponent();

            Ne_usuario ne_Usuario = new Ne_usuario();
            {
                DataTable tabla = new DataTable();
                tabla = ne_Usuario.RecuperarTodosActivos();
                CargarGrilla(tabla);
                habitarControles();
                return;
            }
        }
        private void btn_Salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frm_ABM_Usuario_Load(object sender, EventArgs e)
        {
            cmb_Perfil.CargarCombo();
            cmb_Perfil.SelectedIndex = -1;
            
        }

        private void btn_3Puntos_Click(object sender, EventArgs e)
        {
            cmb_Perfil.SelectedIndex = -1;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void cmb_Perfil_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void chk_Todos_Usuarios_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btn_Buscar_Click(object sender, EventArgs e)
        {
            Ne_usuario ne_Usuario = new Ne_usuario();

            if ( this.txt_Patron.Text == string.Empty && this.cmb_Perfil.SelectedIndex == -1 && chk_Todos_Usuarios.Checked == false ) 
            {
                DataTable tabla = new DataTable();
                tabla = ne_Usuario.RecuperarTodosActivos();
                CargarGrilla(tabla);
                habitarControles();
                return;
            }
            if (this.chk_Todos_Usuarios.Checked == true && this.txt_Patron.Text == string.Empty && this.cmb_Perfil.SelectedIndex == -1)
            {
                DataTable tabla = new DataTable();
                tabla = ne_Usuario.RecuperarTodos();
                CargarGrilla(tabla);
                habitarControles();
                return;
            }

            if (this.chk_Todos_Usuarios.Checked == true && this.cmb_Perfil.SelectedIndex != -1 && this.txt_Patron.Text != "")
            {
                CargarGrilla(ne_Usuario.Recuperar_Mixto(this.txt_Patron.Text, this.cmb_Perfil.SelectedValue.ToString()));
                habitarControles();
                return;
            }

            if (this.chk_Todos_Usuarios.Checked == false && this.cmb_Perfil.SelectedIndex != -1  && this.txt_Patron.Text != "")
            {
                CargarGrilla(ne_Usuario.Recuperar_MixtoActivo(this.txt_Patron.Text,this.cmb_Perfil.SelectedValue.ToString()));
                habitarControles();
                return;
            }
            
            if (this.txt_Patron.Text != "" && this.cmb_Perfil.SelectedIndex == -1 && this.chk_Todos_Usuarios.Checked == false)
            {
                CargarGrilla(ne_Usuario.Recuprar_x_PatronActivo(this.txt_Patron.Text));
                habitarControles();
            }

            
        }

        private void habitarControles()
        {
            btn_Modificar.Enabled = true;
            btn_Baja.Enabled = true;
        }
        private void CargarGrilla(DataTable tabla)
        {
            this.dgr_Usuarios.Rows.Clear();
            for (int i = 0; i < tabla.Rows.Count; i++)
            {
                this.dgr_Usuarios.Rows.Add();
                this.dgr_Usuarios.Rows[i].Cells[0].Value = tabla.Rows[i]["id_usuario"].ToString();
                this.dgr_Usuarios.Rows[i].Cells[1].Value = tabla.Rows[i]["password"].ToString();
                this.dgr_Usuarios.Rows[i].Cells[2].Value = tabla.Rows[i]["nombre"].ToString();
                this.dgr_Usuarios.Rows[i].Cells[3].Value = tabla.Rows[i]["apellido"].ToString();
                this.dgr_Usuarios.Rows[i].Cells[4].Value = tabla.Rows[i]["n_perfil"].ToString();
                this.dgr_Usuarios.Rows[i].Cells[5].Value = tabla.Rows[i]["email"].ToString();
                this.dgr_Usuarios.Rows[i].Cells["id_usuario"].Value = tabla.Rows[i]["id_usuario"].ToString();
                label2.Text = tabla.Rows.Count.ToString() ;

            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_Alta_Click(object sender, EventArgs e)
        {
            frm_AltaUsuarios frm_Alta_Usuarios = new frm_AltaUsuarios();
            frm_Alta_Usuarios.ShowDialog();

            Ne_usuario ne_Usuario = new Ne_usuario();
            {
                DataTable tabla = new DataTable();
                tabla = ne_Usuario.RecuperarTodosActivos();
                CargarGrilla(tabla);
                habitarControles();
                return;
            }
        }

        //private void dgr_Usuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        //{

        //    Id_Usuario = dgr_Usuarios.CurrentRow.Cells["Id_Usuario"].Value.ToString();


        //} esto estaba xq funcaba pero no por defecto

        private void btn_Modificar_Click(object sender, EventArgs e)
        {
            frm_ModificacionUsuarios modificar = new frm_ModificacionUsuarios();
            Id_Usuario = dgr_Usuarios.CurrentRow.Cells["Id_Usuario"].Value.ToString();
            modificar.Id_Usuario = Id_Usuario;
            modificar.ShowDialog();
            this.btn_Buscar_Click(null, null);


            Ne_usuario ne_Usuario = new Ne_usuario();
            {
                DataTable tabla = new DataTable();
                tabla = ne_Usuario.RecuperarTodosActivos();
                CargarGrilla(tabla);
                habitarControles();
                return;
            }
        }

        private void dgr_Usuarios_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            frm_MostrarUsuarios mostrar = new frm_MostrarUsuarios();
            mostrar.Id_Usuario = dgr_Usuarios.CurrentRow.Cells["Id_Usuario"].Value.ToString();
            mostrar.ShowDialog();
        }

        private void btn_Baja_Click(object sender, EventArgs e)
        {
            frm_BorrarUsuarios borrar = new frm_BorrarUsuarios();
            Id_Usuario = dgr_Usuarios.CurrentRow.Cells["Id_Usuario"].Value.ToString();
            borrar.Id_Usuario = Id_Usuario;
            borrar.ShowDialog();


            Ne_usuario ne_Usuario = new Ne_usuario();
            {
                DataTable tabla = new DataTable();
                tabla = ne_Usuario.RecuperarTodosActivos();
                CargarGrilla(tabla);
                habitarControles();
                return;
            }
        }

        private void lbl_ABM_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_Patron_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbl_Patron_Click(object sender, EventArgs e)
        {

        }

        private void lbl_Perfiles_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void chk_Activos_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }
    }
}
