using System.Net.Http.Headers;
using System.Text.Json;

namespace TaskSerialization
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Student student = new Student();
            student.Id = 1;
            student.Name = "Mehemmed";
            student.Surname = "Huseyinli";


            string json = StudentToJSON(student);



            Student deserializedStudent = JSONToStudent(json);

            Console.WriteLine("JSON deserialized :");
            Console.WriteLine($"Id: {deserializedStudent.Id}");
            Console.WriteLine($"Name: {deserializedStudent.Name}");
            Console.WriteLine($"SurName: {deserializedStudent.Surname}");
        


        }

        static string StudentToJSON(Student student)
        {
            return JsonSerializer.Serialize(student);
        }

        static Student JSONToStudent(string json)
        {
            return JsonSerializer.Deserialize<Student>(json);
        }
    }

}
}
