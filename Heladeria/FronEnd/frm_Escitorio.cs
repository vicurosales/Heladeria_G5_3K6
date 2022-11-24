using Heladeria.FronEnd;
using Heladeria.FronEnd.Factura;
using Heladeria.FronEnd.Helado;
using Heladeria.Reporte;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Heladeria
{
 
    
    public partial class frm_Escritorio : Form
    {
     
        public frm_Escritorio()
        {
         
            InitializeComponent();
        }

        private void frm_Escritorio_Load(object sender, EventArgs e)
        {
            frm_Login login = new frm_Login();
            
            login.ShowDialog();

            txtUser.Text = Sesion.usuario_logueado;
        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_ABM_Usuario usuarios = new frm_ABM_Usuario();
            usuarios.ShowDialog();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ayudaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("App Heladeria V2.1", "PAVI2022", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void aBMToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frm_ABM_Helado usuarios = new frm_ABM_Helado();
            usuarios.ShowDialog();
         
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            frm_ABM_Proveedor factura = new frm_ABM_Proveedor();
            factura.ShowDialog();
        }

        private void nuevaFacturaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_ABM_Factura factura = new frm_ABM_Factura();
            factura.ShowDialog();
        }

        private void presupuestoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void reportesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void reporteDeVentasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReporteVentas ventana = new ReporteVentas();
            ventana.ShowDialog();
        }

        private void estadísticaDeVentasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReporteEstadistica ventana = new ReporteEstadistica();
            ventana.ShowDialog();
        }
    }
}
