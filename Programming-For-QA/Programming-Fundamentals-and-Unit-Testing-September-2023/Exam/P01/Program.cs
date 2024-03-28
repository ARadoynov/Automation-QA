int countStudents = int.Parse(Console.ReadLine());
double sumGrades = 0.0;

for (int i = 1; i <= countStudents; i++)
{
    double currentGrade = double.Parse(Console.ReadLine());
    sumGrades += currentGrade;
}
double averageGrade = sumGrades / countStudents;
Console.WriteLine($"{averageGrade:F2}");


