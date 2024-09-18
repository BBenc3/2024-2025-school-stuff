using Server.DataBaseManager;
using Server.Modells;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MySql.Data.MySqlClient;

namespace Server.Controllers
{
    public class JogosultsagokController : BaseDBManager
    {
        public List<Jogosultsag> SELECT()
        {
            List<Jogosultsag> list = new List<Jogosultsag>();
            MySqlCommand cmd = new MySqlCommand();
            try
            {
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandText = "SELECT * FROM jogosultsagok";
                cmd.Connection = Connection;
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Jogosultsag jogosultsag = new Jogosultsag();
                    jogosultsag.ID = int.Parse(reader["ID"].ToString());
                    jogosultsag.Szint = byte.Parse(reader["Szint"].ToString());
                    jogosultsag.Leiras = reader["Leiras"].ToString();
                    list.Add(jogosultsag);
                }
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                Connection.Close();
            }
            
            return list;
        }
    }
}