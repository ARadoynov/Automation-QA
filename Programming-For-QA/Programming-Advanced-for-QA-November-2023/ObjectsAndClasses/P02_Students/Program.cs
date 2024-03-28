public class Program
{
    static void Main(string[] args)
    {
        string input = Console.ReadLine();
        List<Student> students = new List<Student>();
        while (input != "end")
        {
            string[] studentDataParts = input.Split(" ");
            string firstName = studentDataParts[0];
            string lastName = studentDataParts[1];
            int age = int.Parse(studentDataParts[2]);
            string town = studentDataParts[3];

            Student currentStudent = new Student()
            {
                FirstName = firstName,
                LastName = lastName,
                Age = age,
                Town = town,
            };

            students.Add(currentStudent);

            input = Console.ReadLine();
        }

        string typeCommand = Console.ReadLine();

        students = students.Where(x => x.Town == typeCommand).ToList();

        foreach (Student student in students)
        {
            Console.WriteLine($"{student.FirstName} {student.LastName} is {student.Age} years old.");
        }

    }
}

public class Student
{
    public string FirstName { get; set; }

    public string LastName { get; set; }

    public int Age { get; set; }

    public string Town { get; set; }
}