using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace Heladeria.Negocio
{

    internal class Ne_Factura
    {

        public enum Respuesta { aceptado, denegado }
        public Be_acceso_datos _BD = new Be_acceso_datos();

        public string Pp_cod_helado { get; set; }
        public string Pp_nombre { get; set; }
        public string Pp_descripcion { get; set; }
        public string Pp_tipo_helado { get; set; }
        public string Pp_cantidad_stock { get; set; }

        public string Pp_borrado { get; set; }

    
        public DataTable RecuperarInactivos(Boolean estado)
        {
            string sql = @"SELECT h.*, t.nombre as tipo_helado "
            + " FROM Helado h join Tipo_Helado t "
            + " on h.tipo_helado = t.cod_tipo ";

            if (estado == true)
            {
                sql += " WHERE h.borrado = 1 ";
            }
            else { sql += " WHERE h.borrado = 0 "; }
            return _BD.EjecutarSQL(sql);
        }

        public int ObtenerUltimoID()
        {
            try
            {

                string sql = @"SELECT MAX (numero_factura)"
                    + " FROM Factura ";

                return _BD.EjecutarSQLInt(sql);
            }

            catch
                    (Exception ex)
            {
                return 0;
            }

        }

        public DataTable RecuperarFacturas()
        {
            string sql = @"SELECT * "
              + " FROM Factura f ";
                 

                return _BD.EjecutarSQL(sql);

            }

        public DataTable ObtenerEstadisticaVenta()
        {
            string sql = @"select u.nombre, count(f.numero_factura) as Cantidad
                    from Usuarios u inner join Factura f on f.cod_vendedor = u.id_usuario 
                    group by u.nombre";


            return _BD.EjecutarSQL(sql);

        }

        public DataTable RecuperarTodos()
            {
                string sql = @"SELECT h.cod_helado, h.nombre, h.descripcion, t.nombre as tipo_helado, h.cantidad_stock "
                + " FROM Helado h join Tipo_Helado t "
                + " on h.tipo_helado = t.cod_tipo "
                 + "AND h.borrado = 0";

                return _BD.EjecutarSQL(sql);
            }
            public DataTable Recuperar_x_Tipo(string tipo)
            {
                string sql = @"SELECT u.*, p.nombre as nombreTipo "
                + " FROM Helado u join Tipo_Helado p "
                + " on u.tipo_helado= p.cod_tipo "
                + " WHERE u.tipo_helado= " + tipo
                + "AND u.borrado = 0";

                return _BD.EjecutarSQL(sql);
            }
            public DataTable Recuprar_x_Patron(string patron)
            {
                string sql = @"SELECT u.*, p.nombre as n_Tipo "
                + " FROM Helado u join Tipo Helado p "
                + " on u.tipo_helado= p.cod_tipo "
                + " WHERE u.nombre like '%" + patron.Trim() + "%'"
                + "AND u.borrado = 0";

                return _BD.EjecutarSQL(sql);
            }
            public DataTable Recuperar_Mixto(string patron, string tipo_helado)
            {
                string sql = @"SELECT u.*, p.nombre as n_perfil "
                + " FROM Helado u join Tipo_Helado p "
                + " on u.tipo_helado = p.cod_tipo "
                + " WHERE u.nombre like '%" + patron.Trim() + "%'"
                + "AND u.tipo_helado= " + tipo_helado
                + "AND u.borrado = 0";

                return _BD.EjecutarSQL(sql);
            }

            //internal void Modificar()
            //{
            //    throw new NotImplementedException();
            //}

            // esto me sirve para el Alta asi el id es unico e incremental
            public string Ultimo_Numero_Id_Helado()
            {
                string sql = @"SELECT * FROM Helado";
                DataTable dt = _BD.EjecutarSQL(sql);
                return Convert.ToString(dt.Rows.Count + 1);

            }

            // este me va a servir para la modificacion
            public DataTable Recuperar_x_Id(string id)
            {

                string sql = @"SELECT * FROM Helado h WHERE h.cod_helado =" + id;
                return _BD.EjecutarSQL(sql);
            }

      

        public void Insertar()
            {
                try
                {
                    string sqlInsertar = @"INSERT INTO Helado (cod_helado,nombre,descripcion,tipo_helado,cantidad_stock,borrado)"
                                    + "VALUES(" + Pp_cod_helado + ",'" + Pp_nombre + "'" + ",'" + Pp_descripcion + "'" + "," + Pp_tipo_helado + "," + Pp_cantidad_stock + "," + Pp_borrado
                                    + ")";


                    _BD.Insertar(sqlInsertar);

                    MessageBox.Show("El Helado " + Pp_nombre + " se ha cargado exitosamente en la base de datos.");

                }
                catch (Exception)
                {

                    MessageBox.Show("Error al ingresar helado.");
                }

            }

            public void Modificar(string cod_helado)
            {
                try
                {

                    string sqlModifficar = @"UPDATE Helado SET "
                            + " nombre = '" + Pp_nombre + "',"
                            + " descripcion = '" + Pp_descripcion + "',"
                            + " tipo_helado = " + Pp_tipo_helado

                            + " WHERE cod_helado = " + cod_helado;


                    _BD.Modificar(sqlModifficar);
                    MessageBox.Show("El Helado " + Pp_nombre + " se ha modificado exitosamente.");


                }
                catch (Exception ex)
                {

                    MessageBox.Show("Error al modificar el helado.");
                }
            }

            public void borrar(string id)
            {
                string sqlLogicDelete = "update Helado set borrado = 1 where cod_helado =" + int.Parse(id);
                _BD.Borrar(sqlLogicDelete);
            }


            public bool AltaNuevaFactura(int id_factura, int codigo_tipo, string fecha, int cod_empleado, List<String[]> ListaDetalles)
            {
                SqlConnection conexion = new SqlConnection();
                string cadena_conexion = "Data Source=200.69.137.167,11333;Initial Catalog=BD3K6G05_2022;User ID=BD3K6G05_2022;Password=BDG05_8790";
                SqlTransaction objTransaccion = null;
                conexion.ConnectionString = cadena_conexion;


                try
                {
                    SqlCommand cmd = new SqlCommand();


                    string sqlInsertar = @"INSERT INTO Factura "
                                    + "VALUES(" + id_factura + "," + codigo_tipo + ",'" + fecha + "'," + cod_empleado
                                    + ")";

                    cmd.Transaction = objTransaccion;
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = sqlInsertar;

                    conexion.Open();

                    objTransaccion = conexion.BeginTransaction("AltaFactura");
                    cmd.Transaction = objTransaccion;


                    cmd.Connection = conexion;

                    cmd.ExecuteNonQuery();


                    foreach (string[] IdDetalle in ListaDetalles)
                    {

                        string consulta = @"INSERT INTO Detalle_Factura VALUES(" + IdDetalle[0] + "," + id_factura + "," + IdDetalle[1] + "," + IdDetalle[2] + ")";
                        //string consulta = @"INSERT INTO DetalleFactura"
                        //                  + "VALUES(" + cod_helado + "," + id_factura + "," + cantidad + "," + precio + ")";

                        cmd.CommandText = consulta;

                        cmd.ExecuteNonQuery();



                    }



                    objTransaccion.Commit();
                    MessageBox.Show("La factura ha sido cargada con exito");

                    return true;
                }


                catch (Exception ex)
                {
                    objTransaccion.Rollback();

                    MessageBox.Show("Ha ocurrido un error al cargar la factura.");
                    return false;
                }
                finally

                {

                    conexion.Close();
                }

            }
        }


    }





 

