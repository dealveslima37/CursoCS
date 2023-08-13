namespace Aula227.Entities
{
    internal class Student
    {

        public string? Name { get; set; }
        public double Grade { get; set; }

        public Student(string? name, double grade)
        {
            Name = name;
            Grade = grade;
        }
    }
}
