using System.Linq.Expressions;

SqlConnect.Connect();


Console.WriteLine("Ders-Etüt Düzenleme Programına Hoşgeldiniz..");
Console.WriteLine("Bu uygulama etüt merkezlerinde , öğrencilere etüt randevu sistemidir.");

while (true)
{

#region  Ders Seçimi
Console.WriteLine();
Lesson.List();
Console.WriteLine("Öncelikle ders seçimi yapınız.İlgili dersin ID'sini giriniz..");
int lessonSelect = int.Parse(Console.ReadLine());
#endregion

#region Öğretmen Seçimi
Console.WriteLine();
Teacher.List(lessonSelect);
Console.WriteLine("Listelenen öğretmenlerden istediğiniz öğrenmen ID'sini giriniz...");
int teacherSelect = int.Parse(Console.ReadLine());
#endregion

#region  Tarih Seçimi 
Console.WriteLine();
Console.WriteLine("Ders için tarih giriniz: (GG.AA.YYYY) ");
string date = Console.ReadLine();
#endregion

#region  Saat Seçimi
Console.WriteLine();
Console.WriteLine("Ders için saat giriniz: SS:DD");
string time = Console.ReadLine();
#endregion

#region Öğrenci Seçimi
Console.WriteLine();
Students.List();
Console.WriteLine("Öğrenci listesinden öğrenci ID'si giriniz:");
int studentSelect = int.Parse(Console.ReadLine());
#endregion

Console.WriteLine("Seçtiğiniz ders:{0}, Öğretmen :{1} , Tarih - Saat :{2} - {3}. Öğrenci : {4}",lessonSelect,teacherSelect,date,time,studentSelect);


#region Seçimi Kaydedin - Uygulamadan Çıkın
Console.WriteLine();
Console.WriteLine("Seçiminizi kaydetmek için 1'e basınız, iptal etmek için 0'a basınız");
int value = int.Parse(Console.ReadLine());
if (value ==1)
{
    Study.Add(lessonSelect,teacherSelect,studentSelect,date,time);
}
if (value==0)
{
    Console.WriteLine("Seçimleriniz iptal edilmiştir.");
}

Console.WriteLine("Uygulamadan çıkmak için 5'e basınız, Menüyü Tekrar görmek için '1'e basınız");
char exit = char.Parse(Console.ReadLine());
if (exit=='5')
{
    break;
}
#endregion

}
Console.WriteLine("Uygulamadan Çıktınız");