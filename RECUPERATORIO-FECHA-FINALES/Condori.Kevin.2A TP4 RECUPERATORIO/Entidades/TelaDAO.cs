using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class TelaADO
    {

        static SqlConnection conexion;
        static SqlCommand comando;
        static SqlDataReader lector;

        static TelaADO()
        {
            TelaADO.conexion = new SqlConnection(@"Data Source = .; Initial Catalog = Costura;Integrated security = true");
            TelaADO.comando = new SqlCommand();

            TelaADO.comando.CommandType = CommandType.Text;
            comando.Connection = TelaADO.conexion;

        }
        /// <summary>
        /// Obtengo todos los registros de la base de datos
        /// </summary>
        /// <returns></returns>
        public static List<Tela> SelectTela()
        {
            List<Tela> listaTela = new List<Tela>();

            try
            {
                //string query = "SELECT * FROM 2"; // -> PARA PROBAR LA EXCEPCION
                string query = "SELECT * FROM Materiales";
                comando.CommandText = query;

                if (TelaADO.conexion.State != ConnectionState.Open &&
                    TelaADO.conexion.State != ConnectionState.Connecting)
                {
                    TelaADO.conexion.Open();
                }

                TelaADO.lector = TelaADO.comando.ExecuteReader();

                while (TelaADO.lector.Read())
                {
                    //Tela nuevaCostura = new Tela();
                    if (lector["Tela"].ToString() == "Nacional")
                    {
                        Nacional nuevaCostura = new Nacional();
                        TelaADO.AgregarTela(listaTela, nuevaCostura);
                    }
                    else if (lector["Tela"].ToString() == "Importada")
                    {
                        Importada nuevaCostura = new Importada();
                        TelaADO.AgregarTela(listaTela, nuevaCostura);
                    }
                    else
                    {
                        continue; //tengo que poner una excepcion
                    }
                }

            }
            catch (Exception )
            {
                listaTela = null;
                throw new SqlExcepcion("No se encontro la tabla en la Base de Datos");
            }
            finally
            {
                if (TelaADO.conexion.State != ConnectionState.Closed)
                {
                    TelaADO.conexion.Close();
                }
            }
            return listaTela;
        }
        /// <summary>
        /// Obtiene los registros de la BD y evalua que tipo de tela es
        /// </summary>
        /// <param name="telaTipo"></param>
        /// <returns></returns>
        public static List<Tela> SelectTelaImportadaONacional(string telaTipo)
        {
            List<Tela> listaTela = new List<Tela>();
            string query = "SELECT * FROM Materiales WHERE Tela = @tela";
            TelaADO.comando.CommandText = query;
            TelaADO.comando.Parameters.AddWithValue("@tela", telaTipo);
            try
            {
                if (TelaADO.conexion.State != ConnectionState.Open &&
                    TelaADO.conexion.State != ConnectionState.Connecting)
                {
                    TelaADO.conexion.Open();
                }

                TelaADO.lector = TelaADO.comando.ExecuteReader();

                while (TelaADO.lector.Read())
                {
                    //Tela nuevaCostura = new Tela();
                    if (lector["Tela"].ToString() == "Nacional")
                    {
                        Nacional nuevaCostura = new Nacional();
                        TelaADO.AgregarTela(listaTela, nuevaCostura);
                    }
                    else if (lector["Tela"].ToString() == "Importada")
                    {
                        Importada nuevaCostura = new Importada();
                        TelaADO.AgregarTela(listaTela, nuevaCostura);
                    }
                    else
                    {
                        continue;
                    }
                }

            }
            catch (Exception )
            {
                listaTela = null;
                throw ;
            }
            finally
            {
                if (TelaADO.conexion.State != ConnectionState.Closed)
                {
                    TelaADO.conexion.Close();
                }
                TelaADO.comando.Parameters.Clear();
            }
            return listaTela;
        }
        /// <summary>
        /// Agrega un tela a la lista de Tela
        /// </summary>
        /// <param name="listaTela"></param>
        /// <param name="nuevaCostura"></param>
        public static void AgregarTela(List<Tela> listaTela, Tela nuevaCostura)
        {
            nuevaCostura.Id = (int)lector["Id"];
            nuevaCostura.Tela1 = lector["Tela"].ToString();
            nuevaCostura.Maquina = lector["Maquina"].ToString();
            nuevaCostura.Cliente = lector["Cliente"].ToString();
            nuevaCostura.Cantidad = (int)lector["Cantidad"];
            nuevaCostura.CalidadTela = lector["CalidadTela"].ToString();

            listaTela.Add(nuevaCostura);
        }
        /// <summary>
        /// Modifica la costura recibida por parametro en la tabla de la base de datos
        /// </summary>
        /// <param name="costura"></param>
        /// <returns></returns>
        public static bool UpdateTela(Tela costura)
        {
            bool seModifico = false;
            string consulta = "UPDATE Materiales SET Tela=@tela, Maquina=@maquina, Cliente=@cliente, Cantidad=@cantidad, CalidadTela=@calidadTela WHERE Id=@id";
            TelaADO.comando.CommandText = consulta;
            TelaADO.comando.Parameters.AddWithValue("@tela", costura.Tela1);
            TelaADO.comando.Parameters.AddWithValue("@maquina", costura.Maquina);
            TelaADO.comando.Parameters.AddWithValue("@cliente", costura.Cliente);
            TelaADO.comando.Parameters.AddWithValue("@cantidad", costura.Cantidad);
            TelaADO.comando.Parameters.AddWithValue("@calidadTela", costura.CalidadTela);
            TelaADO.comando.Parameters.AddWithValue("@id", costura.Id);

            try
            {
                if (TelaADO.conexion.State != ConnectionState.Open &&
                    TelaADO.conexion.State != ConnectionState.Connecting)
                {
                    TelaADO.conexion.Open();
                }
                int filasAfectadas = TelaADO.comando.ExecuteNonQuery();
                if (filasAfectadas > 0)
                {
                    seModifico = true;
                }
            }
            catch (Exception )
            {
                throw ;
            }
            finally
            {
                if (TelaADO.conexion.State != ConnectionState.Closed)
                {
                    TelaADO.conexion.Close();
                }
                TelaADO.comando.Parameters.Clear();
            }
            return seModifico;
        }
        /// <summary>
        /// Inserta la tela recibida por parametro en la tabla de la base de datos.
        /// </summary>
        /// <param name="costura"></param>
        /// <returns></returns>
        public static bool InsertTela(Tela costura)
        {
            bool seInserto = false;
            string consulta = "INSERT INTO Materiales (Tela, Maquina, Cliente, Cantidad, CalidadTela) VALUES(@tela, @maquina, @cliente, @cantidad, @calidadTela)";
            TelaADO.comando.CommandText = consulta;
            TelaADO.comando.Parameters.AddWithValue("@tela", costura.Tela1);
            TelaADO.comando.Parameters.AddWithValue("@maquina", costura.Maquina);
            TelaADO.comando.Parameters.AddWithValue("@cliente", costura.Cliente);
            TelaADO.comando.Parameters.AddWithValue("@cantidad", costura.Cantidad);
            TelaADO.comando.Parameters.AddWithValue("@calidadTela", costura.CalidadTela);
            try
            {
                if (TelaADO.conexion.State != ConnectionState.Open &&
                    TelaADO.conexion.State != ConnectionState.Connecting)
                {
                    TelaADO.conexion.Open();
                }
                int filasAfectadas = TelaADO.comando.ExecuteNonQuery();
                if (filasAfectadas > 0)
                {
                    seInserto = true;
                }
            }
            catch (Exception )
            {
                throw ;
            }
            finally
            {
                if (TelaADO.conexion.State != ConnectionState.Closed)
                {
                    TelaADO.conexion.Close();
                }
                TelaADO.comando.Parameters.Clear();
            }
            return seInserto;
        }
        /// <summary>
        /// Elimina de la BD el tela que corresponda con el ID pasado
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public static bool DeleteTela(int id)
        {
            bool pudeEliminar = false;
            string consulta = "DELETE FROM Materiales WHERE id= @id";
            TelaADO.comando.CommandText = consulta;
            TelaADO.comando.Parameters.AddWithValue("@id", id);

            try
            {
                if (TelaADO.conexion.State != ConnectionState.Open &&
                    TelaADO.conexion.State != ConnectionState.Connecting)
                {
                    TelaADO.conexion.Open();
                }

                int filasAfectadas = TelaADO.comando.ExecuteNonQuery();

                if (filasAfectadas > 0)
                {
                    pudeEliminar = true;
                }


            }
            catch (Exception )
            {
                pudeEliminar = false;
                throw ;

            }
            finally
            {
                if (TelaADO.conexion.State != ConnectionState.Closed)
                {
                    TelaADO.conexion.Close();
                }

                TelaADO.comando.Parameters.Clear();

            }
            return pudeEliminar;
        }
    }

}
