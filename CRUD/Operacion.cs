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
            try
            {
                cnx.Open();

                return "Conexión exitosa!";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
            finally
            {
                cnx.Close();
            }
        }
        public string ConsultaSinResultado(string sql)
        {   //para ejecutar consultas sin resultado como update, delete, insert, etc...
            SQLiteConnection cnx = new SQLiteConnection("Data Source=C:\\sistema\\nomina2.s3db;Version=3;");
            try
            {
                cnx.Open();
                SQLiteCommand command = new SQLiteCommand(sql, cnx);
                command.ExecuteNonQuery();
                return "";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
            finally
            {
                cnx.Close();
            }

        }

        public DataTable ConsultaConResultado(string sql)
        {   //para consultas con resultados como select
            SQLiteDataAdapter ad;
            System.Data.DataTable dt = new System.Data.DataTable();
            SQLiteConnection cnx = new SQLiteConnection("Data Source=C:\\sistema\\nomina2.s3db;Version=3;");

            try
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
            {
                cnx.Close();
            }
            return dt;

        }
    }
}
