class Student
{
    
    private string firstName;
    public string FirstName
    {
        get { return firstName; }
        set { firstName = value; }
    }


    private string lastName;
    public string LastName
    {
        get { return lastName; }
        set { lastName = value; }
    }


    private double grade;
    public double Grade
    {
        get { return grade; }
        set { grade = value; }
    }

    public Student(string firstName, string lastName, double grade)
    {
        FirstName = firstName;
        LastName = lastName;
        Grade = grade;
    }

}
