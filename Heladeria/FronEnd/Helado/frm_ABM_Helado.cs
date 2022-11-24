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
   
    public partial class frm_ABM_Helado : Form
    {

     public string codigo_helado { get; set; }


        public frm_ABM_Helado()
        {
            InitializeComponent();
           
            Ne_helado helado = new Ne_helado();
            {
                DataTable tabla = new DataTable();
                tabla = helado.RecuperarTodos();
                CargarGrilla(tabla);
                habitarControles();
                return;
            }
        
        }

        private void dgr_Usuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void lbl_Perfiles_Click(object sender, EventArgs e)
        {

        }

        private void cmb_Perfil_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void frm_ABM_Helado_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'bD3K6G05_2022DataSet.Helado' Puede moverla o quitarla según sea necesario.
            this.heladoTableAdapter.Fill(this.bD3K6G05_2022DataSet.Helado);
            Ne_helado helado = new Ne_helado();
            cmb_TipoHelado.Pp_tabla = "Tipo_Helado";
            cmb_TipoHelado.Pp_Pk = "cod_tipo";
            cmb_TipoHelado.Pp_descripcion = "nombre";
            cmb_TipoHelado.CargarCombo();
            cmb_TipoHelado.SelectedItem = null;

        }

        private void btn_Buscar_Click(object sender, EventArgs e)
        {
            Ne_helado helado = new Ne_helado();
            DataTable tabla = new DataTable();
            tabla = helado.RecuperarTodos();
            CargarGrilla(tabla);

            if (this.txt_Patron.Text == "" && this.cmb_TipoHelado.SelectedIndex == -1)
            {
                CargarGrilla(helado.RecuperarTodos());
                habitarControles();
                return;
            }


            if (this.txt_Patron.Text != ""  && this.cmb_TipoHelado.SelectedIndex != -1)
            {
                CargarGrilla(helado.Recuperar_Mixto(this.txt_Patron.Text, this.cmb_TipoHelado.SelectedValue.ToString()));
                habitarControles();
                return;
            }
            if (this.cmb_TipoHelado.SelectedIndex != -1 && this.txt_Patron.Text == "")
            {
                CargarGrilla(helado.Recuperar_x_Tipo(this.cmb_TipoHelado.SelectedValue.ToString())) ;
                habitarControles();
                return;
            }

            if (this.cmb_TipoHelado.SelectedIndex == -1 && this.txt_Patron.Text != "")
            {
                CargarGrilla(helado.Recuprar_x_Patron(this.txt_Patron.Text));
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
            if (this.dgr_Helados.Rows.Count != 0) 
                this.dgr_Helados.Rows.Clear();
            for (int i = 0; i < tabla.Rows.Count; i++)
            {
                this.dgr_Helados.Rows.Add();
                this.dgr_Helados.Rows[i].Cells[0].Value = tabla.Rows[i]["cod_helado"].ToString();
                this.dgr_Helados.Rows[i].Cells[1].Value = tabla.Rows[i]["nombre"].ToString();
                this.dgr_Helados.Rows[i].Cells[2].Value = tabla.Rows[i]["descripcion"].ToString();
                this.dgr_Helados.Rows[i].Cells[3].Value = tabla.Rows[i]["tipo_helado"].ToString();
                this.dgr_Helados.Rows[i].Cells[4].Value = tabla.Rows[i]["cantidad_stock"].ToString();
                this.dgr_Helados.Rows[i].Cells["cod_helado"].Value = tabla.Rows[i]["cod_helado"].ToString();
                label2.Text = tabla.Rows.Count.ToString();
            }
        }

        private void chk_Todos_Usuarios_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btn_3Puntos_Click(object sender, EventArgs e)
        {

        }

        private void btn_Alta_Click(object sender, EventArgs e)
        {
            frm_AltaHelados frm_Alta_Helados = new frm_AltaHelados();
            frm_Alta_Helados.ShowDialog();
            Ne_helado helado = new Ne_helado();
            DataTable tabla = new DataTable();
            tabla = helado.RecuperarTodos();
            CargarGrilla(tabla);

        }

        private void btn_Salir_Click(object sender, EventArgs e)
        {
          
                this.Close();
            }

        private void btn_Baja_Click(object sender, EventArgs e)
        {
            frm_BorrarHelados borrar = new frm_BorrarHelados();
            codigo_helado = dgr_Helados.CurrentRow.Cells["cod_helado"].Value.ToString();
            borrar.cod_helado = codigo_helado;
            borrar.ShowDialog();

            

            dgr_Helados.ClearSelection();
            Ne_helado helado = new Ne_helado();
            DataTable tabla = new DataTable();
            tabla = helado.RecuperarTodos();
            CargarGrilla(tabla);
        }

        private void btn_Modificar_Click(object sender, EventArgs e)
        {

            frm_ModificacionHelado modificar = new frm_ModificacionHelado();
            codigo_helado = dgr_Helados.CurrentRow.Cells["cod_helado"].Value.ToString();
            modificar.cod_helado = codigo_helado;
            modificar.ShowDialog();
            this.btn_Buscar_Click(null, null);
            
            dgr_Helados.ClearSelection();
            Ne_helado helado = new Ne_helado();
            DataTable tabla = new DataTable();
            tabla = helado.RecuperarTodos();
            CargarGrilla(tabla);
        }

        private void chk_Activos_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
    }

