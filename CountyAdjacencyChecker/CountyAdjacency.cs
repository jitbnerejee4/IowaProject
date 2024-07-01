using MySql.Data.MySqlClient;
using System;
using System.Data;

public class CountyAdjacency
{
    private string connectionString = "Server=localhost;Database=CountyAdjacencyDB;User ID=root;Password=26121990;";

    public int GetCountyID(string countyName)
    {
        using (MySqlConnection conn = new MySqlConnection(connectionString))
        {
            conn.Open();
            using (MySqlCommand cmd = new MySqlCommand("SELECT CountyID FROM Counties WHERE CountyName = @CountyName", conn))
            {
                cmd.Parameters.AddWithValue("@CountyName", countyName);

                var result = cmd.ExecuteScalar();
                if (result != null)
                {
                    return Convert.ToInt32(result);
                }
                else
                {
                    throw new Exception("County not found");
                }
            }
        }
    }

    public bool AreCountiesAdjacent(int county1, int county2)
    {
        using (MySqlConnection conn = new MySqlConnection(connectionString))
        {
            conn.Open();
            using (MySqlCommand cmd = new MySqlCommand("AreCountiesAdjacent", conn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("County1", county1);
                cmd.Parameters.AddWithValue("County2", county2);

                MySqlParameter resultParam = new MySqlParameter("Result", MySqlDbType.Bit);
                resultParam.Direction = ParameterDirection.Output;
                cmd.Parameters.Add(resultParam);

                cmd.ExecuteNonQuery();

                return Convert.ToBoolean(resultParam.Value);
            }
        }
    }
}
