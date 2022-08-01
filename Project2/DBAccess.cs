using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project2
{
    internal class DBAccess
    {
        List<User> userList = new List<User>();

        // DB 정보
        string server = "127.0.01";
        string port = "3306";
        string username = "root";
        string password = "1234";
        string database = "userdb";
        string table = "user3";

        // 싱글톤
        private static DBAccess insatance = new DBAccess();
        public static DBAccess Instance { get { return insatance; }}
        private DBAccess() { }
        
        private MySqlConnection Connect()
        {
            string strConn = $"server ={server};port={port};username={username};password={password};database={database};";
            MySqlConnection conn = new MySqlConnection(strConn);
            return conn;
        }

        public void InsertUser(string uid, string name, string hp, string age)
        {
            MySqlConnection conn = Connect();

            try
            {
                //DB 접속
                conn.Open();
                //SQL 실행
                MySqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = $"INSERT INTO {table} VALUES ('{uid}','{name}','{hp}','{age}')";
                cmd.ExecuteNonQuery();
            }
            catch (Exception except)
            {
                Console.WriteLine(except.Message);
            }
            finally
            {
                conn.Close();
            }
        }
        public void SelectUser()
        {

        }
        public List<User> SelectUsers()
        {
            // 그리드뷰 데이터 공급을 위한 리스트 선언
            List<User> userList = new List<User>();

            MySqlConnection conn = Connect();

            try
            {
                //DB 접속
                conn.Open();
                //SQL 실행
                MySqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = $"SELECT * FROM {table}";
                MySqlDataReader reader = cmd.ExecuteReader();
                //결과처리
                while (reader.Read())
                {
                    User user = new User();
                    user.Uid = reader[0].ToString();
                    user.Name = reader[1].ToString();
                    user.Hp = reader[2].ToString();
                    user.Age = int.Parse(reader[3].ToString());

                    userList.Add(user);
                }
            }
            catch (Exception except)
            {
                Console.WriteLine(except.Message);
            }
            finally
            {
                conn.Close();
            }

            return userList;
        }
        public void UpdateUser(string uid, string name, string hp, string age)
        {
            MySqlConnection conn = Connect();

            try
            {
                //DB 접속
                conn.Open();
                //SQL 실행
                MySqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = $"UPDATE {table} SET `name`='{name}', `hp`= '{hp}', `age`= '{age}' WHERE `uid` = '{uid}'";
                cmd.ExecuteNonQuery();
            }
            catch (Exception except)
            {
                Console.WriteLine(except.Message);
            }
            finally
            {
                conn.Close();
            }
        }
        public void DeleteUser(string uid)
        {
            MySqlConnection conn = Connect();

            try
            {
                //DB 접속
                conn.Open();
                //SQL 실행
                MySqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = $"DELETE FROM {table} WHERE `uid`='{uid}'";
                cmd.ExecuteNonQuery();
            }
            catch (Exception except)
            {
                Console.WriteLine(except.Message);
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
