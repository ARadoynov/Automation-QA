Dictionary<string, List<string>> companies = new Dictionary<string, List<string>>();

string input = Console.ReadLine();
while (input != "End")
{
    string[] inputParts = input.Split("->");
    string companyName = inputParts[0];
    string employeeId = inputParts[1];

    if (!companies.ContainsKey(companyName))
    {
        companies.Add(companyName, new List<string>());
    }

    if(!companies[companyName].Contains(employeeId)) 
    {
        companies[companyName].Add(employeeId);
    }

    
    input = Console.ReadLine();
}

foreach (KeyValuePair<string, List<string>> company in companies)
{
    Console.WriteLine(company.Key);

    foreach(string employee in company.Value)
    {
        Console.WriteLine($"--{employee}");
    }
}
