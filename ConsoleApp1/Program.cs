namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)


        {
            Student student = new Student();
            student.Name = "maha salem";
            student.Major = "Computer engineering";
            student.GPA = 3.4;
            student.PrintSummary();

        }

        public class Student
        {
            public string Name { get; set; }
            public string Major { get; set; }
            public double GPA { get; set; }

            public void PrintSummary()
            {
                Console.WriteLine($"Name: {Name}");
                Console.WriteLine($"Major: {Major}");
                Console.WriteLine($"GPA: {GPA:F2}");
            }
        }
    }
}