using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
                    query.AppendLine("select i.IdInterlocutor,i.Login,i.Clave,i.IdRol,i.Nombre,i.Direccion,i.Telefono from Interlocutor i");
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
                                Login = dr["Documento"].ToString(),
                                Clave = dr["NombreCompleto"].ToString(),
                                IdRol = Convert.ToInt32(dr["IdTipoPersona"]),
                                Nombre = dr["Correo"].ToString(),
                                Direccion = dr["Correo"].ToString(),
                                Telefono = dr["IdTipoPersona"].ToString(),
                                Estado = Convert.ToBoolean(dr["Estado"]),
                                
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
