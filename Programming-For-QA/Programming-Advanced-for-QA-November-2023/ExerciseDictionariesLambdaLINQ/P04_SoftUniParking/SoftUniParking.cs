Dictionary<string, string> employees = new Dictionary<string, string>();
int n = int.Parse(Console.ReadLine());

for (int i = 0; i < n; i++)
{
    string input = Console.ReadLine();
    string[] inputPieces = input.Split().ToArray();

    string function = inputPieces[0];
    string employeeName = inputPieces[1];
    

    if (function == "register")
    {
        string licencePlate = inputPieces[2];
        if (!employees.ContainsKey(employeeName))
        {
            employees.Add(employeeName, licencePlate);
            Console.WriteLine($"{employeeName} registered {licencePlate} successfully");
        } else
        {
            Console.WriteLine($"ERROR: already registered with plate number {licencePlate}");
        }

    } else if (function == "unregister")
    {
        if (employees.ContainsKey(employeeName))
        {
            employees.Remove(employeeName);
            Console.WriteLine($"{employeeName} unregistered successfully");
        } else 
        {
            Console.WriteLine($"ERROR: user {employeeName} not found");
        }
    }
}

foreach (KeyValuePair<string, string> employee in employees)
{
    Console.WriteLine($"{employee.Key} => {employee.Value}");
}
