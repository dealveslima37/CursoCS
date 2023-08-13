using Aula227.Entities;

var students = new List<Student>();

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
students.Add(new Student("Mary", 9.7));
students.Add(new Student("Kelly", 6.9));
students.Add(new Student("Teena", 8.3));
students.Add(new Student("Jessika", 8.7));

students.RemoveAll(s => s.Grade <= 7.0);
students.Sort((s1, s2) => s1.Name!.ToUpper().CompareTo(s2.Name!.ToUpper()));
students.ForEach(s => Console.WriteLine($"Nome: {s.Name} Nota: {s.Grade.ToString("F2")}"));

