using System.Data.SqlClient;

public class Study
{ 
    public static void Add(int LessonID ,int TeacherID ,int StudentID,string Date,string Time)
    {
        string studyAdd = "insert into Study (LessonId,TeacherID,StudentID,Tarih,Saat)"+
                         "values (@lessonId,@teacherId,@studentId,@date,@time)";
                        

        using (SqlCommand command = new SqlCommand(studyAdd, SqlConnect.connection))
        {
            command.Parameters.AddWithValue("@lessonId", LessonID);
            command.Parameters.AddWithValue("@teacherId",TeacherID);
            command.Parameters.AddWithValue("@studentId",StudentID);
            command.Parameters.AddWithValue("@date",Date);
            command.Parameters.AddWithValue("@time",Time) ;

            try
            {
                int rows = command.ExecuteNonQuery();
                Console.WriteLine("Etüt oluşturuldu");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Veri ekleme hatası: " + ex.Message);
            }
        }
      

    }
}