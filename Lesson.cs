using System.Data.SqlClient;

public class Lesson
{
public static void List()
    {
        string lessons = "select * from Lesson";
        using (SqlCommand command = new SqlCommand(lessons, SqlConnect.connection))
        {
            // SqlDataReader ile verileri oku
            using (SqlDataReader reader = command.ExecuteReader())
            {
                // Tablodaki tüm satırları oku
                while (reader.Read())
                {
                    // Sütun isimlerine göre verileri alın. Örneğin:
                    Console.WriteLine($"ID: {reader["Id"]}, Ders: {reader["Name"]}");
                }
            }

        }
    }
}