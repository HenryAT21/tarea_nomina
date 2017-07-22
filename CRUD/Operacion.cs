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
        {
            SQLiteConnection cnx = new SQLiteConnection("Data Source=C:\\_Sistemas\\nomina.s3db;Version=3;");
            try
            {
                cnx.Open();

                return "Conexión Exitosa!";
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
        {
            SQLiteConnection cnx = new SQLiteConnection("Data Source=C:\\_Sistemas\\nomina.s3db;Version=3;");
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
        {
            SQLiteDataAdapter ad;
            System.Data.DataTable dt = new System.Data.DataTable();
            SQLiteConnection cnx = new SQLiteConnection("Data Source=C:\\sistema\\nomina.db;Version=3;");

            try
            {
                cnx.Open();
                SQLiteCommand cmd;
                cmd = cnx.CreateCommand();
                cmd.CommandText = sql;
                ad = new SQLiteDataAdapter(cmd);
                ad.Fill(dt);
            }
            catch (SQLiteException ex)
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
