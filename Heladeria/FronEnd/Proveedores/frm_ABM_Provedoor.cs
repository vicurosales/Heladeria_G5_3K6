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
using Heladeria.FronEnd.Helado;
using Heladeria.FronEnd.Proveedores;
using Heladeria.Negocio;


namespace Heladeria.FronEnd
{
    public partial class frm_ABM_Proveedor : Form
    {
        public string Id_Proveedor { get; set; }
        public frm_ABM_Proveedor()
        {
            InitializeComponent();

            Ne_proveedor ne_Proveedor = new Ne_proveedor();
            {
                DataTable tabla = new DataTable();
                tabla = ne_Proveedor.RecuperarTodosActivos();
                CargarGrilla(tabla);
                habitarControles();
                return;
            }
        }
        private void btn_Salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frm_ABM_Proveedor_Load(object sender, EventArgs e)
        {


        }

        private void btn_3Puntos_Click(object sender, EventArgs e)
        {
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
            Ne_proveedor ne_Proveedor = new Ne_proveedor();


            if (this.chk_Todos_Usuarios.Checked == true && this.txt_Patron.Text == "")
            {
                DataTable tabla = new DataTable();
                tabla = ne_Proveedor.RecuperarTodos();
                CargarGrilla(tabla);
                habitarControles();
                return;
            }
                    
            if (this.txt_Patron.Text != "" && chk_Todos_Usuarios.Checked == false)
            {
                CargarGrilla(ne_Proveedor.Recuprar_x_Patron(this.txt_Patron.Text));
                habitarControles();
                return;
            }

            if (this.txt_Patron.Text == "" && chk_Todos_Usuarios.Checked == false)
            {
                CargarGrilla(ne_Proveedor.RecuperarTodosActivos());
                habitarControles();
                return;
            }


            if (this.txt_Patron.Text != "" && chk_Todos_Usuarios.Checked == true)
            {
                CargarGrilla(ne_Proveedor.Recuperar_Mixto_Todos(this.txt_Patron.Text));
                habitarControles();
                return;
            }
        }

        private void habitarControles()
        {
            btn_Modificar.Enabled = true;
            btn_Baja.Enabled = true;
        }
        private void CargarGrilla(DataTable tabla)
        {
            this.dgr_Proveedores.Rows.Clear();
            for (int i = 0; i < tabla.Rows.Count; i++)
            {
                this.dgr_Proveedores.Rows.Add();
                this.dgr_Proveedores.Rows[i].Cells[0].Value = tabla.Rows[i]["dni"].ToString();
                this.dgr_Proveedores.Rows[i].Cells[1].Value = tabla.Rows[i]["razon_social"].ToString();
                this.dgr_Proveedores.Rows[i].Cells[2].Value = tabla.Rows[i]["email"].ToString();
                this.dgr_Proveedores.Rows[i].Cells[3].Value = tabla.Rows[i]["telefono1"].ToString();
                this.dgr_Proveedores.Rows[i].Cells[4].Value = tabla.Rows[i]["calle"].ToString();
                this.dgr_Proveedores.Rows[i].Cells[5].Value = tabla.Rows[i]["numero"].ToString();
                label2.Text = tabla.Rows.Count.ToString();

            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_Alta_Click(object sender, EventArgs e)
        {
        }
        private void btn_Modificar_Click(object sender, EventArgs e)
        {

        }

        private void dgr_Usuarios_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_Baja_Click(object sender, EventArgs e)
        {

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

        private void frm_ABM_Proveedor_Load_1(object sender, EventArgs e)
        {

        }

        private void frm_ABM_Proveedor_Load_2(object sender, EventArgs e)
        {

        }

        private void btn_Modificar_Click_1(object sender, EventArgs e)
        {
            frm_Modificacion_Proveedor modificar = new frm_Modificacion_Proveedor();
            Id_Proveedor = dgr_Proveedores.CurrentRow.Cells["dni"].Value.ToString();
            modificar.cod_proveedor = Id_Proveedor;
            modificar.ShowDialog();
            this.btn_Buscar_Click(null, null);

            Ne_proveedor ne_Proveedor = new Ne_proveedor();


            DataTable tabla = new DataTable();
            tabla = ne_Proveedor.RecuperarTodosActivos();
            CargarGrilla(tabla);
            habitarControles();
            return;

        }

        private void btn_Salir_Click_1(object sender, EventArgs e)
        {
            this.Close();

        }

        private void btn_Alta_Click_1(object sender, EventArgs e)
        {
            frm_AltaProveedores frm_AltaProveedores = new frm_AltaProveedores();
            frm_AltaProveedores.ShowDialog();

            Ne_proveedor ne_Proveedor = new Ne_proveedor();

            DataTable tabla = new DataTable();
            tabla = ne_Proveedor.RecuperarTodosActivos();
            CargarGrilla(tabla);
            habitarControles();
            return;
        }

        private void btn_Baja_Click_1(object sender, EventArgs e)
        {



            Ne_proveedor ne_Proveedor = new Ne_proveedor();

            frm_BajaProveedores borrar = new frm_BajaProveedores();
            Id_Proveedor = dgr_Proveedores.CurrentRow.Cells["dni"].Value.ToString();
            borrar.cod_proveedor = Id_Proveedor;
            borrar.ShowDialog();
            this.btn_Buscar_Click(null, null);


            DataTable tabla = new DataTable();
                tabla = ne_Proveedor.RecuperarTodosActivos();
                CargarGrilla(tabla);
                habitarControles();
                return;
            }
        }
    }


