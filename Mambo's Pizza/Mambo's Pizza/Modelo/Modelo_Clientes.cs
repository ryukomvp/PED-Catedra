﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;
using System.Data.SqlTypes;

namespace Mambo_s_Pizza.Modelo
{
    public class Modelo_Clientes
    {
        public static DataTable MostrarClientes()
        {
            DataTable dt = new DataTable();

            // Columnas basadas en tu modelo de usuarios
            dt.Columns.Add("IdCliente");
            dt.Columns.Add("IdUsuario");
            dt.Columns.Add("Direccion");
            dt.Columns.Add("IdMembresia");
            dt.Columns.Add("FechaExpiracion");

            Conexion conexionBD = new Conexion();

            using (SqlConnection con = conexionBD.AbrirConexion())
            {
                string query = @"SELECT IdCliente, IdUsuario, Direccion, IdMembresia, FechaExpiracion FROM Clientes";

                using (SqlCommand comando = new SqlCommand(query, con))
                {
                    using (SqlDataReader reader = comando.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            dt.Rows.Add(
                                reader["IdCliente"],
                                reader["IdUsuario"],
                                reader["Direccion"],
                                reader["IdMembresia"],
                                reader["FechaExpiracion"]
                            );
                        }
                    }
                }
            }
            return dt;
        }


        public static List<KeyValuePair<int, string>> CargarUsuariosClientes()
        {
            mensajes msg = new mensajes();
            Conexion conexionBD = new Conexion();
            using (SqlConnection con = conexionBD.AbrirConexion())
            {
                List<KeyValuePair<int, string>> lista = new List<KeyValuePair<int, string>>();
                try
                {
                    string query = @"SELECT IdUsuario, Nombre + ' ' + Apellido + ', ' + Usuario as NombreCompleto 
                            FROM Usuarios WHERE Rol = 'Cliente'
                            ORDER BY IdUsuario";

                    SqlCommand comando = new SqlCommand(query, con);
                    SqlDataReader reader = comando.ExecuteReader();

                    while (reader.Read())
                    {
                        lista.Add(new KeyValuePair<int, string>(
                            Convert.ToInt32(reader["IdUsuario"]),
                            reader["NombreCompleto"].ToString()
                        ));
                    }

                    return lista;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                    return null;
                }
            }
        }

        public static List<KeyValuePair<int, string>> CargarMembresiaCliente()
        {
            mensajes msg = new mensajes();
            Conexion conexionBD = new Conexion();
            using (SqlConnection con = conexionBD.AbrirConexion())
            {
                List<KeyValuePair<int, string>> lista = new List<KeyValuePair<int, string>>();
                try
                {
                    string query = @"SELECT DISTINCT m.IdMembresia, m.Membresia 
                            FROM Membresias m
                            INNER JOIN Clientes c ON m.IdMembresia = c.IdMembresia";

                    SqlCommand comando = new SqlCommand(query, con);
                    SqlDataReader reader = comando.ExecuteReader();

                    while (reader.Read())
                    {
                        lista.Add(new KeyValuePair<int, string>(
                            Convert.ToInt32(reader["IdMembresia"]),
                            reader["Membresia"].ToString()
                        ));
                    }

                    return lista;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                    return null;
                }
            }
        }

        public static int EncontrarIdCliente(int idUsuario)
        {
            Conexion conexionBD = new Conexion();
            using (SqlConnection con = conexionBD.AbrirConexion())
            {
                int id = 0;
                try
                {
                    string query = "SELECT [IdCliente] FROM [Clientes] WHERE IdUsuario = @idUsuario";
                    SqlCommand comando = new SqlCommand(query, con);
                    comando.Parameters.Add(new SqlParameter("@idUsuario", idUsuario));
                    SqlDataReader reader = comando.ExecuteReader();

                    if (!reader.HasRows)
                    {
                        Console.WriteLine("No se encontraron resultados para el cliente con id de usuario: " + idUsuario);
                        return 0;
                    }
                    while (reader.Read())
                    {
                        id = Convert.ToInt32(reader["IdCliente"]);
                    }
                    return id;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                    return -1;
                }

            }

        }

        public static string ObtenerMembresia(int idCliente)
        {
            mensajes msg = new mensajes();
            Conexion conexionBD = new Conexion();
            using (SqlConnection con = conexionBD.AbrirConexion())
            {
                string membresia = "";
                try
                {
                    string query = @"SELECT m.Membresia
                            FROM Clientes c
                            INNER JOIN Membresias m ON c.IdMembresia = m.IdMembresia
                            WHERE c.IdCliente = '" + idCliente + "'";

                    SqlCommand comando = new SqlCommand(query, con);
                    SqlDataReader reader = comando.ExecuteReader();

                    while (reader.Read())
                    {
                        membresia = reader["Membresia"].ToString();
                    }

                    return membresia;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                    return null;
                }
            }
        }

        public static string ObtenerUsuario(int idCliente)
        {
            mensajes msg = new mensajes();
            Conexion conexionBD = new Conexion();
            using (SqlConnection con = conexionBD.AbrirConexion())
            {
                string usuario = "";
                try
                {
                    string query = @"SELECT u.Nombre, u.Apellido, u.Usuario
                            FROM Usuarios u
                            INNER JOIN Clientes c ON u.IdUsuario = c.IdUsuario
                            WHERE c.IdCliente = '" + idCliente + "'";

                    SqlCommand comando = new SqlCommand(query, con);
                    SqlDataReader reader = comando.ExecuteReader();

                    while (reader.Read())
                    {
                        usuario = reader["Nombre"].ToString() + " " + reader["Apellido"] + ", " + reader["Usuario"];
                    }

                    return usuario;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                    return null;
                }
            }

        }

        public static DataTable ObtenerMembresia()
        {
            DataTable dt = new DataTable();

            // Configurar columnas
            dt.Columns.Add("IdMembresia", typeof(int));
            dt.Columns.Add("Membresia", typeof(string));

            Conexion conexionBD = new Conexion();

            using (SqlConnection con = conexionBD.AbrirConexion())
            {
                string query = @"SELECT u.IdMembresia, u.Membresia
                        FROM Clientes r
                        INNER JOIN Membresias u ON r.IdMembresia = u.IdMembresia
                        GROUP BY u.IdMembresia, u.Membresia";

                using (SqlCommand comando = new SqlCommand(query, con))
                {
                    using (SqlDataReader reader = comando.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            dt.Rows.Add(
                                reader.GetInt32(0),    
                                reader.GetString(1)   
                            );
                        }
                    }
                }
            }
            return dt;
        }

        public static bool AgregarCliente(int idUsuario, string Direccion, int idMembresia, DateTime fechaExp)
        {
            bool retorno = false;
            mensajes msg = new mensajes();

            // validacion de fecha
            if (fechaExp < DateTime.Now)
            {
                msg.fechaInvalida("Tabla: Clientes");
                return retorno;
            }

            Conexion conexionBD = new Conexion();

            using (SqlConnection con = conexionBD.AbrirConexion())
            {
                try
                {
                    string query = "INSERT INTO Clientes (IdUsuario, Direccion, IdMembresia, FechaExpiracion) " +
                                 "VALUES (@IdUsuario, @Direccion, @IdMembresia, @FechaExpiracion)";

                    SqlCommand comando = new SqlCommand(query, con);

                    comando.Parameters.AddWithValue("@IdUsuario", idUsuario);
                    comando.Parameters.AddWithValue("@Direccion", Direccion);
                    comando.Parameters.AddWithValue("@IdMembresia", idMembresia);
                    comando.Parameters.AddWithValue("@FechaExpiracion", fechaExp);

                    retorno = Convert.ToBoolean(comando.ExecuteNonQuery());
                    msg.exitoInsercion("Tabla: Clientes. ");
                    return retorno;
                }
                catch (SqlException ex)
                {
                    msg.errorInsercion(ex.Message, "Tabla: Clientes. ");
                    return retorno;
                }
                finally
                {
                    conexionBD.CerrarConexion();
                }
            }
        }

        public static bool AgregarClienteSinExpedicion(int idUsuario, string Direccion, int idMembresia, DateTime fechaExp)
        {
            bool retorno = false;
            mensajes msg = new mensajes();

            // validacion de fecha
            if (fechaExp < DateTime.Now)
            {
                msg.fechaInvalida("Tabla: Clientes");
                return retorno;
            }

            Conexion conexionBD = new Conexion();

            using (SqlConnection con = conexionBD.AbrirConexion())
            {
                try
                {
                    string query = "INSERT INTO Clientes (IdUsuario, Direccion, IdMembresia, FechaExpiracion) " +
                                 "VALUES (@IdUsuario, @Direccion, @IdMembresia, @FechaExpiracion)";

                    SqlCommand comando = new SqlCommand(query, con);

                    comando.Parameters.AddWithValue("@IdUsuario", idUsuario);
                    comando.Parameters.AddWithValue("@Direccion", Direccion);
                    comando.Parameters.AddWithValue("@IdMembresia", idMembresia);
                    comando.Parameters.AddWithValue("@FechaExpiracion", fechaExp);

                    retorno = Convert.ToBoolean(comando.ExecuteNonQuery());
                    msg.exitoInsercion("Tabla: Clientes. ");
                    return retorno;
                }
                catch (SqlException ex)
                {
                    msg.errorInsercion(ex.Message, "Tabla: Clientes. ");
                    return retorno;
                }
                finally
                {
                    conexionBD.CerrarConexion();
                }
            }
        }

        public static bool ActualizarCliente(int idCliente, string direccion, int idMembresia, DateTime fechaExp)
        {
            bool retorno = false;
            mensajes msg = new mensajes();

            // validacion de fecha
            if (fechaExp < DateTime.Now)
            {
                msg.fechaInvalida("Tabla: Clientes");
                return retorno;
            }

            Conexion conexionBD = new Conexion();

            using (SqlConnection con = conexionBD.AbrirConexion())
            {
                try
                {
                    string query = @"UPDATE Clientes 
                   SET Direccion = @Direccion, 
                       IdMembresia = @idMembresia, 
                       FechaExpiracion = @FechaExpiracion 
                   WHERE idCliente = @idCliente";

                    SqlCommand comando = new SqlCommand(query, con);
                    comando.Parameters.AddWithValue("@idCliente", idCliente);
                    comando.Parameters.AddWithValue("@Direccion", direccion);
                    comando.Parameters.AddWithValue("@idMembresia", idMembresia);
                    comando.Parameters.AddWithValue("@FechaExpiracion", fechaExp);

                    retorno = Convert.ToBoolean(comando.ExecuteNonQuery());
                    msg.exitoActualizacion("Tabla: Clientes.");
                    return retorno; // Retorna el número de filas afectadas
                }
                catch (SqlException ex)
                {
                    return retorno; // Retorna 0 si hay un error
                }
                finally
                {
                    conexionBD.CerrarConexion();
                }
            }
        }
        public static bool EliminarCliente(int idCliente)
        {
            bool retorno = false;
            mensajes msg = new mensajes();
            Conexion conexionBD = new Conexion();

            using (SqlConnection con = conexionBD.AbrirConexion())
            {
                try
                {
                    string query = "DELETE FROM Clientes WHERE IdCliente = @IdCliente";
                    SqlCommand comando = new SqlCommand(query, con);
                    comando.Parameters.AddWithValue("@IdCliente", idCliente);
                    retorno = Convert.ToBoolean(comando.ExecuteNonQuery());
                    return retorno;

                }
                catch (SqlException ex)
                {
                    msg.errorEliminacion(ex.Message, "Tabla: Clientes.");
                    return retorno = false; // Retorna 0 si hay un error
                }
                finally
                {
                    conexionBD.CerrarConexion();
                }
            }
        }

        
    }
}
