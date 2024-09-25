using Server.DataBaseManager;
using Server.Modells;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MySql.Data.MySqlClient;

namespace Server.Controllers
{
    public class JogosultsagokController : BaseDBManager, ISQL
    {
        public List<Record> SELECT()
        {
            List<Record> list = new List<Record>();
            MySqlCommand cmd = new MySqlCommand();
            try
            {
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandText = "SELECT * FROM jogosultsagok";
                cmd.Connection = Connection;
                cmd.Connection.Open();
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Jogosultsag jogosultsag = new Jogosultsag();
                    jogosultsag.ID = int.Parse(reader["ID"].ToString());
                    jogosultsag.Szint = byte.Parse(reader["Szint"].ToString());
                    jogosultsag.Nev = reader["Nev"].ToString();
                    jogosultsag.Leiras = reader["Leiras"].ToString();
                    list.Add(jogosultsag);
                }
            }
            catch (Exception e)
            {
                Jogosultsag jogosultsag = new Jogosultsag();
                jogosultsag.ID = -1;
                jogosultsag.Nev = "Error";
                list.Add(jogosultsag);
                return list;
                throw;
            }
            finally
            {
                Connection.Close();
            }
            
            return list;
        }

        public string UPDATE(Record record)
        {
            MySqlCommand cmd = new MySqlCommand();
            

            try
            {
                if (record != null)
                {
                    Jogosultsag jogosultsag = (Jogosultsag)record;
                    cmd.Connection = Connection;
                    cmd.Connection.Open();
                    cmd.CommandText = $"UPDATE jogosultsagok SET Nev = \"{jogosultsag.Nev}\", Szint = {jogosultsag.Szint}, Leiras = \"{jogosultsag.Leiras}\" WHERE ID = {jogosultsag.ID}";
                    cmd.ExecuteNonQuery();
                    return "Sikreres Frissítés!";
                }
                else
                {
                    return "Null érték!";
                }
                
            }
            catch(Exception e) { return e.Message; throw; }
            finally { Connection.Close(); }
        }

        public string INSERT(Record record) 
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand();
                if (record != null)
                {
                    Jogosultsag jogosultsag = (Jogosultsag)record;
                    cmd.Connection = Connection;
                    cmd.Connection.Open();
                    cmd.CommandText = $"INSERT INTO jogosultsagok (Nev, Szint, Leiras) VALUES (\"{jogosultsag.Nev}\", {jogosultsag.Szint}, \"{jogosultsag.Leiras}\")";
                    cmd.ExecuteNonQuery();
                    return "Sikeres Felvtel";
                }
                else
                {
                    return "Null érték!";
                }
            }
            catch (Exception e)
            {
                return e.Message;
                throw;
            }
            finally { Connection.Close(); }
            
            
        }
        public string DELETE(int ID)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand();
                if (ID != null)
                {
                    cmd.Connection = Connection;
                    cmd.Connection.Open();
                    try
                    {
                        cmd.CommandText = $"DELETE FROM jogosultsagok WHERE ID = {ID}";
                        cmd.ExecuteNonQuery();
                    }
                    catch  (Exception e) { return e.Message; }

                   
                    return "Sikeres Törlés";
                }
                else
                {
                    return "Null érték!";
                }
            }
            catch (Exception e)
            {
                return e.Message;
                throw;
            }
            finally { Connection.Close(); }
        }



    }
}