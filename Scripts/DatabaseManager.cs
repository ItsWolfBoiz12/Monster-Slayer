using UnityEngine;
using System.Data;
using System.Data.SqlClient;

public class DatabaseManager : MonoBehaviour
{
    private string connectionString = "Server=DESKTOP-12VE4CU;Database=Monster;Integrated Security=true;";

    public void RetrieveClassData(string selectedClass)
    {
        SqlConnection connection = new SqlConnection(connectionString);

        try
        {
            connection.Open();
            Debug.Log("Connection successful!");

            // Execute a SQL query to retrieve class-specific data
            string query = "SELECT * FROM " + selectedClass;
            SqlCommand command = new SqlCommand(query, connection);
            SqlDataReader reader = command.ExecuteReader();

            // Process the retrieved data
            while (reader.Read())
            {
                // Access the data fields
                int player_id = reader.GetInt32(0);
                string player_name = reader.GetString(1);
                int player_attack = reader.GetInt32(2);
                int player_def = reader.GetInt32(3);
                int player_spec = reader.GetInt32(4);
                int player_hp = reader.GetInt32(5);
                int weapon_id = reader.GetInt32(6);
                int armor_id = reader.GetInt32(7);
                // Retrieve other class-specific fields as needed

                // Process the retrieved data here
                Debug.Log("ID: " + player_id + ", Name: " + player_name + ", Attack: " + player_attack + ", Defense: " + player_def + ", Special: " + player_spec + ", Health: " + player_hp + ", Weapon: " + weapon_id + ", Armor: " + armor_id);
            }

            reader.Close();
        }
        catch (SqlException ex)
        {
            Debug.Log("Error connecting to the database: " + ex.Message);
        }
        finally
        {
            connection.Close();
        }
    }
}
