﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch10
{
    internal class _1
    {
        static void Main1(string[] args)
        {
            // 데이터베이스 접속 정보
            string server = "127.0.0.1";
            string port = "3306";
            string username = "root";
            string password = "1234";
            string database = "userdb";

            // 데이터베이스 커넥션 생성
            string strConn = $"server={server};port={port};username={username};password={password};database={database}";
            MySqlConnection conn = new MySqlConnection(strConn);

            // 데이터베이스 접속
            try
            {
                conn.Open();
                Console.WriteLine("접속 성공!");
            }
            catch (Exception e)
            {
                Console.WriteLine("접속 실패 : " + e.Message);
            }
            finally
            {
                // 접속 종료
                conn.Close();
                Console.WriteLine("접속 종료...");
            }
        }
    }
}
