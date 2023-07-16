using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MySql.Data.MySqlClient;

public class DatabaseManager : MonoBehaviour
{
    // Modify the connection string based on your database configuration
    private string connectionString = "server=127.0.0.1;port=3306;database=monsterslayer;uid=root;password=Niles2012!;";

    private MySqlConnection connection;

    private void Awake()
    {
        connection = new MySqlConnection(connectionString);
    }

    private void Start()
    {
        ConnectToDatabase();
    }

    private void ConnectToDatabase()
    {
        try
        {
            connection.Open();
            Debug.Log("Connected to the database!");
        }
        catch (MySqlException e)
        {
            Debug.LogError("Failed to connect to the database: " + e.Message);
        }
    }

    private void OnApplicationQuit()
    {
        connection.Close();
        Debug.Log("Disconnected from the database.");
    }

    public void RetrieveClassData(string selectedClass)
    {
        // Use the selectedClass variable to retrieve class data from the database
        // You can execute SQL queries here to fetch the necessary data
        // Implement the logic to handle the retrieved data as per your game's requirements
        Debug.Log("Retrieving data for class: " + selectedClass);
    }

}