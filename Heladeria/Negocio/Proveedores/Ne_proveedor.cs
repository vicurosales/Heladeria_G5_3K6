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
    internal class Ne_proveedor
    {

        public enum Respuesta { aceptado, denegado }
        public Be_acceso_datos _BD = new Be_acceso_datos();
        public string Pp_dni { get; set; }
        public string Pp_tipo_doc { get; set; }
        public string Pp_razon_social { get; set; }
        public string Pp_email { get; set; }
        public string Pp_telefono1 { get; set; }
        public string Pp_calle { get; set; }
        public string Pp_numero { get; set; }

        public string Pp_borrado { get; set; }




        public DataTable RecuperarTodos()
        {
            string sql = @"SELECT * "
            + " FROM Proveedores "
            + " order by razon_social ";
            return _BD.EjecutarSQL(sql);
        }

        public DataTable RecuperarTodosActivos()
        {
            string sql = @"SELECT * "
            + " FROM Proveedores where borrado=0"
            + " order by razon_social ";
            return _BD.EjecutarSQL(sql);
        }

        public DataTable Recuperar_Mixto(string patron)
        {
            string sql = @"SELECT * "
            + " FROM Proveedores "
            + " WHERE razon_social like '%" + patron.Trim() + "%'"
            + " OR email like '%" + patron.Trim() + "%'"
            + " OR telefono1 like '%" + patron.Trim() + "%'"
            + " OR calle like '%" + patron.Trim() + "%'"
            + " AND borrado = '0'"
            + " order by razon_social ";

            return _BD.EjecutarSQL(sql);
        }

        public DataTable Recuperar_Mixto_Todos(string patron)
        {
            string sql = @"SELECT * "
            + " FROM Proveedores "
            + " WHERE razon_social like '%" + patron.Trim() + "%'"
            + " OR email like '%" + patron.Trim() + "%'"
            + " OR telefono1 like '%" + patron.Trim() + "%'"
            + " OR calle like '%" + patron.Trim() + "%'"
            + " order by razon_social ";

            return _BD.EjecutarSQL(sql);
        }

        // esto me sirve para el Alta asi el id es unico e incremental
        public string Ultimo_Numero_Id_Usuario()
        {
            string sql = @"SELECT * FROM Usuarios";
            DataTable dt = _BD.EjecutarSQL(sql);
            return Convert.ToString(dt.Rows.Count + 1);

        }

        // este me va a servir para la modificacion
        public DataTable Recuperar_x_Id(string id)
        {
            string sql = @"SELECT * FROM Proveedores WHERE dni ='" + id + "'";
            return _BD.EjecutarSQL(sql);
        }

        public void Insertar()
        {
            try
            {
                string sqlInsertar = @"INSERT INTO Proveedores (dni,tipo_doc,razon_social,email,telefono1,calle,numero,borrado)"
                                + "VALUES(" + Pp_dni + ",'" + Pp_tipo_doc + "4" + ",'" + Pp_razon_social + "'" + ",'" + Pp_email + "'" + ",'" + Pp_telefono1 + "'" + ",'" + Pp_calle + "'" + ",'" + Pp_numero + "'" + ",'" + Pp_borrado + "'"
                                + ")";


                _BD.Insertar(sqlInsertar);

                MessageBox.Show("El Proveedor " + Pp_razon_social + " se ha cargado exitosamente en la base de datos");

            }
            catch (Exception)
            {

                MessageBox.Show("Error al cargar el Proveedor.");
            }

        }

        public void Modificar(string id_proveedor)
        {
            string sqlModifficar = @"UPDATE Proveedores SET "
                        + " razon_social = '" + Pp_razon_social + "'"
                        + ", email ='" + Pp_email + "'"
                        + ", telefono1 =" + Pp_telefono1
                        + ", calle ='" + Pp_calle + "'"
                        + ", numero ='" + Pp_numero + "'"

                        + " WHERE dni = " + id_proveedor;

            _BD.Modificar(sqlModifficar);
        }

        public void Borrar(string id)
        {
            string sqlDelete = @"UPDATE Proveedores SET"
                        + " borrado =" + 1

                        + " WHERE dni = " + id;
            _BD.Borrar(sqlDelete);
        }


        public DataTable Recuprar_x_Patron(string patron)
        {
            string sql = @"SELECT * "
            + " FROM Proveedores "
            + " WHERE razon_social like '%" + patron.Trim() + "%'"
            + " OR email like '%" + patron.Trim() + "%'"
            + " OR telefono1 like '%" + patron.Trim() + "%'"
            + " OR calle like '%" + patron.Trim() + "%'"
            + " AND borrado = 0"
            + " order by razon_social ";

            return _BD.EjecutarSQL(sql);
        }
    }
}
