using System.Data.SqlClient;

public class Teacher
{ 
    public static void List(int BranchID)
    {
        string lessons = "select t.Id,t.Name,t.Surname,l.Name BranchName from Teachers t inner join Lesson l on l.ID=t.BranchID where t.BranchID="+ BranchID;
        using (SqlCommand command = new SqlCommand(lessons, SqlConnect.connection))
        {
            // SqlDataReader ile verileri oku
            using (SqlDataReader reader = command.ExecuteReader())
            {
                // Tablodaki tüm satırları oku
                while (reader.Read())
                { 
                    // Sütun isimlerine göre verileri alın. Örneğin:
                    Console.WriteLine($"ID: {reader["Id"]}, Ad: {reader["Name"]}, Soyad: {reader["Surname"]}, Branş: {reader["BranchName"]}");
                }
            }

        }
    }
}