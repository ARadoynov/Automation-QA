Dictionary<string, int> resources = new();

string currentResource = "";
string input = Console.ReadLine();
while(input != "stop")
{
    currentResource = input;
    int quantity = int.Parse(Console.ReadLine());

    if (!resources.ContainsKey(currentResource))
    {
        resources.Add(currentResource, quantity);
    } else
    {
        resources[currentResource] += quantity;
    }
    

   input = Console.ReadLine();
}
foreach (var resource in resources)
{
    Console.WriteLine($"{resource.Key} -> {resource.Value}");
}