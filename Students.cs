using System.Data.SqlClient;

public class Students
{ 
    public static void List()
    {
        string lessons = "select Id,Name,Surname,Class from Students";
        using (SqlCommand command = new SqlCommand(lessons, SqlConnect.connection))
        {
            // SqlDataReader ile verileri oku
            using (SqlDataReader reader = command.ExecuteReader())
            {
                // Tablodaki tüm satırları oku
                while (reader.Read())
                { 
                    // Sütun isimlerine göre verileri alın. Örneğin:
                    Console.WriteLine($"ID: {reader["Id"]}, Ad: {reader["Name"]}, Soyad: {reader["Surname"]}, Sınıf: {reader["Class"]}");
                }
            }

        }
    }
}