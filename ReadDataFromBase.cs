using MySqlConnector;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class ReadDataFromBase : MonoBehaviour
{
    private string connectionString;
    string query;
    private MySqlConnection MS_Connection;
    private MySqlCommand MS_Command;
    private MySqlDataReader MS_Reader;

    void Start()
    {
        Read();
    }

    private void Read()
    {
        connectionString = "Server = 141.8.195.65 ; Database = a0944382_testBase ; User = a0944382 ; Password = ufgaatuhci ; Charset = utf8;";

        MS_Connection = new MySqlConnection(connectionString);

        MS_Connection.Open();





        //query = "SELECT * FROM users2";
        //connectionString = "Server = a0944382.xsph.ru ; Database = a0944382_testBase ; User = a0944382 ; Password = ufgaatuhci ; Charset = utf8;";

        //MS_Connection = new MySqlConnection(connectionString);
        //MS_Connection.Open();

        //MS_Command = new MySqlCommand(query, MS_Connection);

        //MS_Reader = MS_Command.ExecuteReader();
        //while (MS_Reader.Read())
        //{
        //    Debug.Log(MS_Reader[0]);
        //    Debug.Log(MS_Reader[1]);
        //}
        //MS_Reader.Close();

        //MySqlException: Access denied for user 'a0944382'@'188.123.231.205' (using password: YES)
        //"Server=141.8.195.65;User ID=a0944382;Password=ufgaatuhci;Database=a0944382_testBase"

        //using var connection = new MySqlConnection("Server=141.8.195.65; port= 3306; Database=a0944382_testBase; UserId=a0944382; Password=Yes;");
        //connection.Open();

        //using var command = new MySqlCommand("SELECT record FROM users2;", connection);
        //using var reader = command.ExecuteReader();
        //while (reader.Read())
        //    Debug.Log(reader.GetString(0));
    }
}
