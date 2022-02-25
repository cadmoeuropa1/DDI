using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace CapaDatos
{
    public class CD_Interlocutor
    {
        public List<Interlocutor> Listar()
        {
            List<Interlocutor> lista = new List<Interlocutor>();
            using (SqlConnection oConexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("select i.IdInterlocutor,i.Login,i.Clave, r.IdRol ,i.Nombre,i.Direccion,i.Telefono, r.Descripcion as DesRol from Interlocutor i inner join Rol r ON i.IdRol = r.IdRol");
                    SqlCommand cmd = new SqlCommand(query.ToString(), oConexion);
                    cmd.CommandType = CommandType.Text;

                    oConexion.Open();
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            lista.Add(new Interlocutor()
                            {
                                IdInterlocutor = Convert.ToInt32(dr["IdInterlocutor"]),
                                Login = dr["Login"].ToString(),
                                Clave = dr["Clave"].ToString(),
                                oRol = new Rol() { IdRol = Convert.ToInt32(dr["IdRol"]), Descripcion = dr["DesRol"].ToString() },
                                Nombre = dr["Direccion"].ToString(),
                                Direccion = dr["Telefono"].ToString(),
                                
                            });
                        }
                    }
                }
                catch (Exception ex)
                {
                    lista = new List<Interlocutor>();
                }
            }

            return lista;
        }

        public int Registrar(Interlocutor obj, out String Mensaje)
        {
            int idInterlocutorGenerado = 0;
            Mensaje = string.Empty;

            try
            {
                using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
                {
                    SqlCommand cmd = new SqlCommand("SP_RegistrarInterlocutor", oconexion);
                    cmd.Parameters.AddWithValue("IdRol", obj.oRol.IdRol);
                    cmd.Parameters.AddWithValue("Nombre", obj.Nombre);
                    cmd.Parameters.AddWithValue("Direccion", obj.Direccion);
                    cmd.Parameters.AddWithValue("Telefono", obj.Telefono);
                    cmd.Parameters.Add("IdInterlocutorResultado", SqlDbType.Int).Direction = ParameterDirection.Output;
                    cmd.CommandType = CommandType.StoredProcedure;

                    oconexion.Open();

                    cmd.ExecuteNonQuery();

                    idInterlocutorGenerado = Convert.ToInt32(cmd.Parameters["IdInterlocutorResultado"].Value);
                }
            }
            catch (Exception ex)
            {
                idInterlocutorGenerado = 0;
                Mensaje = ex.Message;
            }
            return idInterlocutorGenerado;
        }

        public bool Editar(Interlocutor obj, out String Mensaje)
        {
            bool respuesta = false;
            Mensaje = string.Empty;

            try
            {
                using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
                {
                    SqlCommand cmd = new SqlCommand("SP_ModificarInterlocutor", oconexion);
                    cmd.Parameters.AddWithValue("IdInterlocutor", obj.IdInterlocutor);
                    cmd.Parameters.AddWithValue("IdRol", obj.IdRol);
                    cmd.Parameters.AddWithValue("Nombre", obj.Nombre);
                    cmd.Parameters.AddWithValue("Direccion", obj.Direccion);
                    cmd.Parameters.AddWithValue("IdPersonaModificacion", obj.IdInterlocutorModificacion);
                    cmd.Parameters.Add("Respuesta", SqlDbType.Int).Direction = ParameterDirection.Output;
                    cmd.CommandType = CommandType.StoredProcedure;

                    oconexion.Open();

                    cmd.ExecuteNonQuery();

                    respuesta = Convert.ToBoolean(cmd.Parameters["Respuesta"].Value);
                }
            }
            catch (Exception ex)
            {
                respuesta = false;
                Mensaje = ex.Message;
            }
            return respuesta;
        }

        public bool Eliminar(Interlocutor obj)
        {
            bool respuesta = false;

            try
            {
                using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
                {
                    SqlCommand cmd = new SqlCommand("SP_EliminarInterlocutor", oconexion);
                    cmd.Parameters.AddWithValue("IdInterlocutor", obj.IdInterlocutor);
                    cmd.Parameters.AddWithValue("IdUsuarioModificacion", obj.IdInterlocutorModificacion);
                    cmd.Parameters.Add("Respuesta", SqlDbType.Int).Direction = ParameterDirection.Output;
                    cmd.CommandType = CommandType.StoredProcedure;
                    oconexion.Open();

                    cmd.ExecuteNonQuery();

                    respuesta = Convert.ToBoolean(cmd.Parameters["Respuesta"].Value);
                }
            }
            catch (Exception ex)
            {
                respuesta = false;
            }
            return respuesta;
        }

        public List<Interlocutor> ListarDataGrid()
        {
                List<Interlocutor> lista = new List<Interlocutor>();
                using (SqlConnection oConexion = new SqlConnection(Conexion.cadena))
                {
                    try
                    {
                        StringBuilder query = new StringBuilder();
                        query.AppendLine("select i.IdInterlocutor, r.IdRol ,i.Nombre,i.Direccion,i.Telefono, r.Descripcion as DesRol from Interlocutor i inner join Rol r ON i.IdRol = r.IdRol");
                        query.AppendLine(" WHERE r.IdRol != 1 AND r.IdRol != 2");
                        SqlCommand cmd = new SqlCommand(query.ToString(), oConexion);
                        cmd.CommandType = CommandType.Text;

                        oConexion.Open();
                        using (SqlDataReader dr = cmd.ExecuteReader())
                        {
                            while (dr.Read())
                            {
                            lista.Add(new Interlocutor()
                            {
                                IdInterlocutor = Convert.ToInt32(dr["IdInterlocutor"]),
                                oRol = new Rol() { IdRol = Convert.ToInt32(dr["IdRol"]), Descripcion = dr["DesRol"].ToString() },
                                Nombre = dr["Nombre"].ToString(),
                                Direccion = dr["Direccion"].ToString(),
                                Telefono = dr["Telefono"].ToString()
                            });
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        lista = new List<Interlocutor>();
                    }
                }

                return lista;
            }
    }
}
