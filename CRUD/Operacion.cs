using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Data.SQLite;

namespace CRUD
{
    public class Operacion
    {
        public string Conectar()
        {   //conectar a la base de datos
            SQLiteConnection cnx = new SQLiteConnection("Data Source=C:\\sistema\\nomina2.s3db;Version=3;");
            try //manejador de errores
            {//abrir la conexion con la base de datos
                cnx.Open();

                return "Conexión exitosa!";
            }
            catch (Exception ex)
            {//mostrara un mensaje de error si la conexion falla
                return ex.Message;
            }
            finally
            {//cerrar conexion con la base de datos
                cnx.Close();
            }
        }
        public string ConsultaSinResultado(string sql)
        {   //para ejecutar consultas sin resultado como update, delete, insert, etc...
            SQLiteConnection cnx = new SQLiteConnection("Data Source=C:\\sistema\\nomina2.s3db;Version=3;");
            try //manejador de errores
            {
                cnx.Open();
                SQLiteCommand command = new SQLiteCommand(sql, cnx);
                command.ExecuteNonQuery();
                return "";
            }
            catch (Exception ex)
            {//mostrara un mensaje en caso de error
                return ex.Message;
            }
            finally
            {//cerrar la conexion con la base de datos
                cnx.Close();
            }

        }

        public DataTable ConsultaConResultado(string sql)
        {   //para consultas con resultados como select
            SQLiteDataAdapter ad;
            System.Data.DataTable dt = new System.Data.DataTable();
            SQLiteConnection cnx = new SQLiteConnection("Data Source=C:\\sistema\\nomina2.s3db;Version=3;");

            try //manejador de errores
            {
                cnx.Open();
                SQLiteCommand cmd;
                cmd = cnx.CreateCommand();
                cmd.CommandText = sql;
                ad = new SQLiteDataAdapter(cmd);
                ad.Fill(dt);
            }
            catch (SQLiteException)
            {
                
            }
            finally
            {//cerrar la conexion con la base de datos
                cnx.Close();
            }
            return dt;

        }
    }
}
