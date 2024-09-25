using MySql.Data.MySqlClient;
using Server.DataBaseManager;
using Server.Modells;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Server.Controllers
{
    public class FelhasznaloController : BaseDBManager, ISQL
    {
        public List<Record> SELECT ()
        {
            List<Record> list = new List<Record>();
            MySqlCommand cmd = new MySqlCommand ();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = "SELECT * FROM felhasznalo";

            try
            {
                MySqlConnection connection = BaseDBManager.Connection;
                
                    connection.Open();
                    cmd.Connection = connection;
                    MySqlDataReader reader = cmd.ExecuteReader ();
                    while (reader.Read())
                    {
                        Felhasznalo felhasznalo = new Felhasznalo ();
                        felhasznalo.ID = int.Parse(reader["ID"].ToString());
                        felhasznalo.LoginName = reader["LoginName"].ToString();
                        felhasznalo.HASH = reader["HASH"].ToString ();
                        felhasznalo.SALT = reader["SALT"].ToString() ;
                        felhasznalo.Name = reader["Name"].ToString();
                        felhasznalo.JogID = byte.Parse(reader["JogID"].ToString () );
                        felhasznalo.AktivE = bool.Parse(reader["AktívE"].ToString());
                        felhasznalo.Email = reader["Email"].ToString();
                        felhasznalo.PorfileKep = reader["ProfileKep"].ToString();
                        list.Add ( felhasznalo );
                    }
            }
            catch (MySqlException ex)
            {
                Felhasznalo felhasznalo = new Felhasznalo();
                felhasznalo.ID = -1;
                felhasznalo.HASH = ex.Message;
                list.Add( felhasznalo );
 

                throw;
            }
            finally
            {
                Connection.Close();
            }
            
            return list;
        }

        public string INSERT(Record record)
        {
            Felhasznalo felhasznalo = new Felhasznalo();
            felhasznalo = (Felhasznalo)record;
            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandType = System.Data.CommandType.Text;
            MySqlConnection connection = BaseDBManager.Connection;
            try
            {
                connection.Open();
                cmd.Connection = connection;
                if (record != null)
                {

                    cmd.CommandText = $"INSERT INTO Felhasznalo (LoginName, HASH, SALT, Name, JogID, AktívE, Email, ProfileKep) VALUES ('{felhasznalo.LoginName}', '{felhasznalo.HASH}', '{felhasznalo.SALT}', '{felhasznalo.Name}', {felhasznalo.JogID}, {felhasznalo.AktivE}, '{felhasznalo.Email}', '{felhasznalo.PorfileKep}')";

                    cmd.ExecuteNonQuery();

                    return "Sikeres!";
                }
                else
                {
                    return "Sikertelen!";
                }
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
            finally
            {
                Connection.Close();
            }
            
            
        }
        public string UPDATE(Record record)
        {
            try
            {
                Felhasznalo felhasznalo = (Felhasznalo)record;
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = BaseDBManager.Connection;
                if (record != null)
                {
                    
                    cmd.Connection.Open();
                    cmd.CommandText = $"UPDATE felhasznalo SET LoginName = \"{felhasznalo.LoginName}\", HASH = \"{felhasznalo.HASH}\", SALT = \"{felhasznalo.HASH}\", Name = \"{felhasznalo.Name}\", JogID = {felhasznalo.JogID}, AktívE = {felhasznalo.AktivE}, Email = \"{felhasznalo.Email}\", ProfileKep = \"{felhasznalo.PorfileKep}\" WHERE ID = {felhasznalo.ID}";
                    cmd.ExecuteNonQuery();

                    return "Sikeres frissítés";
                }
                else
                {
                    return "Sikertelen frissítés";
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
                cmd.Connection = BaseDBManager.Connection;
                if (ID != null)
                {

                    cmd.Connection.Open();
                    cmd.CommandText = $"DELETE FROM felhasznalo WHERE ID = {ID}";
                    cmd.ExecuteNonQuery();

                    return "Sikeres Törlés";
                }
                else
                {
                    return "Sikertelen Törlés!";
                }
            }
            catch (Exception e)
            {
                return e.Message;
                throw;
            }
            finally
            {
                Connection.Close();
            }
        }
    }
}