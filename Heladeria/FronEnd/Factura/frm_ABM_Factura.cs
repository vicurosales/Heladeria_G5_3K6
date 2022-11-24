using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using Heladeria.Negocio;


namespace Heladeria.FronEnd.Factura
{
    public partial class frm_ABM_Factura : Form
    {
        public string cod_helado;
        public frm_ABM_Factura()
        {
            InitializeComponent();
        }

        private void frm_ABM_Factura_Load(object sender, EventArgs e)
        {
            CargarFecha();
            ObtenerUltimoNroFactura();
            comboBox_tipoFactura.CargarCombo();
            comboBox_tipoFactura.SelectedIndex = -1;
            comboBox_helados.CargarComboSinBorrado();
            comboBox_helados.SelectedIndex = -1;
            comboBoxVendedores.CargarComboSinBorrado();
            comboBoxVendedores.SelectedIndex = -1;

            

        }
        private void CargarFecha()
        {
            txt_fecha.Text = DateTime.Now.ToShortDateString();

        }

        private void ObtenerUltimoNroFactura()
        {
            Ne_Factura factura = new Ne_Factura();

            int id = factura.ObtenerUltimoID();

            textBox_Numero.Text = (id + 1).ToString();

        }
        private void txt_fecha_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox_Numero_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        private void RecuperarHelado()
        {

        }

        private void MostrarDatos(DataTable tabla)
        {



        }

        private void comboBox_tipoFactura_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        int monto = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            //int idhelado = Int32.Parse(comboBox_helados.SelectedValue.Pp_Pk);
            int idhelado = int.Parse(comboBox_helados.SelectedValue.ToString());
            if (grillaDetalle.Rows.Count != 1)
            {
                for (int i = 0; i < (int.Parse(grillaDetalle.Rows.Count.ToString()) - 1); i++)
                {

                    if (comboBox_helados.SelectedValue.ToString() != grillaDetalle.Rows[i].Cells["id_helado"].Value.ToString())
                    {
                        int ejem = 0;
                        if (int.TryParse(textCantidad.Text, out ejem))
                        {
                            int precio1 = 0;
                            precio1 = (5 * int.Parse(textCantidad.Text));

                            grillaDetalle.Rows.Add(idhelado, comboBox_helados.Text, textCantidad.Text, precio.ToString());
                            textCantidad.Text = "";
                            comboBox_helados.SelectedIndex = -1;


                            montoTotal.Text = precio1.ToString();

                        }

                        else
                        {
                            textCantidad.Text = "";
                            MessageBox.Show("Las cantidades deben ser numéricas.");

                        }
                    }

                    else
                    {


                        grillaDetalle.Rows[i].Cells["Cantidad"].Value = Convert.ToInt32(grillaDetalle.Rows[i].Cells["Cantidad"].Value) + (int.Parse(textCantidad.Text));

                        int montonuevo = 0;
                        montonuevo = (5 * Convert.ToInt32(grillaDetalle.Rows[i].Cells["Cantidad"].Value));
                        montoTotal.Text = montonuevo.ToString();


                        grillaDetalle.Rows[i].Cells["Precio"].Value = (montonuevo);


                        textCantidad.Text = "";
                        comboBox_helados.SelectedIndex = -1;
                       
                    }


                }
            }
            else
            {
                int ejem = 0;
                if (int.TryParse(textCantidad.Text, out ejem))
                {
                    int precio = 0;
                    precio = (5 * int.Parse(textCantidad.Text));

                    grillaDetalle.Rows.Add(idhelado, comboBox_helados.Text, textCantidad.Text, precio.ToString());
                    textCantidad.Text = "";
                    comboBox_helados.SelectedIndex = -1;

                    monto = monto + (precio);
                    montoTotal.Text = monto.ToString();

                }

                else
                {
                    textCantidad.Text = "";
                    MessageBox.Show("Las cantidades deben ser numéricas.");

                }
            }


        }

        private void grillaDetalle_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            RecuperarHelado();
        }

        private void textCantidad_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
 


        private void btn_Alta_Usuario_Click(object sender, EventArgs e)
        {
            
            if (comboBox_tipoFactura.SelectedValue != null)
            { 
          
            if (comboBoxVendedores.SelectedValue != null)
            { 
                    if (grillaDetalle.Rows.Count > 1)
                    {

                        List<String[]> list = new List<String[]>();
                        for (int i = 0; i < (int.Parse(grillaDetalle.Rows.Count.ToString()) - 1); i++)
                        {
                            string[] array = new string[3];
                            array[0] = (grillaDetalle.Rows[i].Cells["id_helado"].Value.ToString());
                            array[1] = (grillaDetalle.Rows[i].Cells["Cantidad"].Value.ToString());
                            array[2] = (grillaDetalle.Rows[i].Cells["Precio"].Value.ToString());
                            list.Add(array);

                            
                            //Ya está cargada la lista

                        }


                        Ne_Factura factura = new Ne_Factura();

                        factura.AltaNuevaFactura((int.Parse(textBox_Numero.Text)), int.Parse(comboBox_tipoFactura.SelectedValue.ToString()), (txt_fecha.Text), int.Parse(comboBoxVendedores.SelectedValue.ToString()), list);

                        this.Close();
                    }
                    else
                    {

                        MessageBox.Show("Debe cargar al menos un detalle.");
                    }
                    }

                    else
                    {
                        
                        MessageBox.Show("Se debe especificar el vendedor.");

                    }

            }
            else
            {
                    MessageBox.Show("Se debe especificar el tipo de Factura.");
                }

  
            }

        private void btn_Salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void montoTotal_TextChanged(object sender, EventArgs e)
        {

        }

        private void detalle_Enter(object sender, EventArgs e)
        {

        }
    }

    }
