Dictionary<string, List<double>> students = new Dictionary<string, List<double>>();

int studentsCount = int.Parse(Console.ReadLine());

for (int i = 0; i < studentsCount; i++)
{

    string studentName = Console.ReadLine();
    double grade = double.Parse(Console.ReadLine());

    if (!students.ContainsKey(studentName))
    {
        students.Add(studentName, new List<double>());
        
    }
    students[studentName].Add(grade);

}
var excellent = students.Where(grade => grade.Value.Average() >= 4.50);

foreach (var student in excellent)
{
    Console.WriteLine($"{student.Key} -> {student.Value.Average():f2}");
}
