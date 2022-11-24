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
    internal class Ne_usuario
    {

        public enum Respuesta {aceptado , denegado }
        public Be_acceso_datos _BD = new Be_acceso_datos();
        public string Pp_apellido { get; set; }
        public string Pp_Cuil { get; set; }
        public string Pp_email { get; set; }
        public string Pp_estado { get; set; }
        public string Pp_nombres { get; set; }
        public string Pp_id_usuario { get; set; }
        public string Pp_password { get; set; }
        public string Pp_id_perfil { get; set; }
        public string Pp_borrado { get; set; }

        public Respuesta ValidarLogin(string nombre, string password) 
        {
            string sql = @"SELECT * FROM Usuarios 
                            WHERE nombre = '" + nombre + "'"
                        + " AND password = '" + password + "'";

            if (_BD.EjecutarSQL(sql).Rows.Count == 0)
                return Respuesta.denegado;
            else
                return Respuesta.aceptado;
        }

        public DataTable RecuperarTodos()
        {
            string sql = @"SELECT u.*, p.nombre as n_perfil "
            + " FROM Usuarios u join Perfiles p "
            + " on u.id_perfil = p.id_perfil "
            + " order by u.nombre ";       
            return _BD.EjecutarSQL(sql);
        }

        public DataTable RecuperarTodosActivos()
        {
            string sql = @"SELECT u.*, p.nombre as n_perfil "
            + " FROM Usuarios u join Perfiles p "
            + " on u.id_perfil = p.id_perfil where u.borrado=0"
            + " order by u.nombre ";
            return _BD.EjecutarSQL(sql);
        }

        public DataTable RecuperarTodosNoBorrados()
        {
            string sql = @"SELECT u.*, p.nombre as n_perfil "
            + " FROM Usuarios u join Perfiles p "
            + " on u.id_perfil = p.id_perfil "
            + " WHERE u.borrado = '0' order by u.nombre ";
            return _BD.EjecutarSQL(sql);
        }

        public DataTable Recuperar_x_Perfiles(string id_perfil)
        {
            string sql = @"SELECT u.*, p.nombre as n_perfil "
            + " FROM Usuarios u join Perfiles p "
            + " on u.id_perfil = p.id_perfil "
            + " WHERE u.id_perfil = " + id_perfil
            + " AND u.borrado = '0' order by u.nombre "; 

            return _BD.EjecutarSQL(sql);
        }
        public DataTable Recuprar_x_Patron(string patron)
        {
            string sql = @"SELECT u.*, p.nombre as n_perfil "
            + " FROM Usuarios u join Perfiles p "
            + " on u.id_perfil = p.id_perfil "
            + " WHERE u.nombre like '%" + patron.Trim() + "%'"
            + " order by u.nombre "; 
            return _BD.EjecutarSQL(sql);
        }

        public DataTable Recuprar_x_PatronActivo(string patron)
        {
            string sql = @"SELECT u.*, p.nombre as n_perfil "
            + " FROM Usuarios u join Perfiles p "
            + " on u.id_perfil = p.id_perfil "
            + " WHERE u.nombre like '%" + patron.Trim() + "%'"
            + " AND u.borrado = '0'order by u.nombre ";
            return _BD.EjecutarSQL(sql);
        }
        public DataTable Recuperar_Mixto(string patron, string id_perfil)
        {
            string sql = @"SELECT u.*, p.nombre as n_perfil "
            + " FROM Usuarios u join Perfiles p "
            + " on u.id_perfil = p.id_perfil "
            + " WHERE u.nombre like '%" + patron.Trim() + "%'"
            + "AND u.id_perfil = " + id_perfil
            + " order by u.nombre"; 
            return _BD.EjecutarSQL(sql);
        }

        public DataTable Recuperar_MixtoActivo(string patron, string id_perfil)
        {
            string sql = @"SELECT u.*, p.nombre as n_perfil "
            + " FROM Usuarios u join Perfiles p "
            + " on u.id_perfil = p.id_perfil "
            + " WHERE u.nombre like '%" + patron.Trim() + "%'"
            + "AND u.id_perfil = " + id_perfil
            + " AND u.borrado = '0' order by u.nombre";
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
            string sql = @"SELECT * FROM usuarios WHERE id_usuario ='" + id + "'";
            return _BD.EjecutarSQL(sql);
        }

        public void Insertar() 
        {
            try
            {
                string sqlInsertar = @"INSERT INTO Usuarios (id_usuario,password,nombre,apellido,id_perfil,email,CUIL,borrado)"
                                + "VALUES(" + Pp_id_usuario + ",'" + Pp_password + "'" + ",'" + Pp_nombres + "'" + ",'" + Pp_apellido + "'" + ",'" + Pp_id_perfil + "'" + ",'" + Pp_email + "'" + ",'" + Pp_Cuil + "'"+ ",'" + Pp_borrado + "'"
                                + ")";


                _BD.Insertar(sqlInsertar);

                MessageBox.Show("El Id_Usuario " + Pp_id_usuario + " se ha cargado exitosamente en la base de datos.");

            }
            catch (Exception)
            {

                MessageBox.Show("Ha ocurrido un error al cargar el nuevo usuario.");
            }
           
        }

        public void Modificar()
        {
            try { 
            string sqlModifficar = @"UPDATE usuarios SET "
                        + " password = '" + Pp_password + "'"
                        + ", nombre = '" + Pp_nombres + "'"
                        + ", apellido ='" + Pp_apellido + "'"
                        + ", id_perfil =" + Pp_id_perfil
                        + ", email ='" + Pp_email + "'"
                        + ", CUIL ='" + Pp_Cuil + "'"
                        + " WHERE id_usuario = " + Pp_id_usuario;

            _BD.Modificar(sqlModifficar);
            MessageBox.Show("El Id_Usuario " + Pp_id_usuario + " se ha modificado exitosamente en la base de datos.");

        }
            catch (Exception ex)
            {

                MessageBox.Show("Ha ocurrido un error al modificar el usuario.");
            }

}

public void Borrar(string id)
        {try { 
           string sqlDelete = "UPDATE USUARIOS SET borrado = 1  WHERE id_usuario =" + int.Parse(id);
            _BD.Borrar(sqlDelete);

                MessageBox.Show("El Id_Usuario " + Pp_id_usuario + " se ha eliminado exitosamente.");

            }
            catch (Exception)
            {

                MessageBox.Show("Ha ocurrido un error al eliminar el usuario.");
            }

        }
    }
    }

