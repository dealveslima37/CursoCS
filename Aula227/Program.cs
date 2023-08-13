using Aula227.Entities;

List<Student> students = new();

students.Add(new Student("Elfie", 7.0));
students.Add(new Student("Liya", 9.5));
students.Add(new Student("Jia", 7.0));
students.Add(new Student("Stefany", 9.0));
students.Add(new Student("Sasha", 7.5));
students.Add(new Student("Sofa", 6.8));
students.Add(new Student("Stacy", 6.5));
students.Add(new Student("Amalia", 6.0));
students.Add(new Student("Angel", 9.0));
students.Add(new Student("Sofi", 7.7));
students.Add(new Student("Mary", 9.9));
students.Add(new Student("Kelly", 6.9));
students.Add(new Student("Teena", 8.3));
students.Add(new Student("Jessika", 8.7));

students.Sort((p1, p2) => p1.Name!.ToUpper().CompareTo(p2.Name?.ToUpper()));

Console.WriteLine("Ordenado por nome");
students.ForEach(x => Console.WriteLine($"{x.Name} - {x.Grade.ToString("F2")}"));

Console.WriteLine();

students.Sort((p1, p2) => p2.Grade.CompareTo(p1.Grade));    
Console.WriteLine("Ordenado por nota");
students.ForEach(x => Console.WriteLine($"{x.Name} - {x.Grade.ToString("F2")}"));