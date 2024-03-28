Dictionary<string, List<decimal>> products = new();

string input = Console.ReadLine();
while (input != "buy")
{
    string[] inputPieces = input.Split(" ");

    string currentProduct = inputPieces[0];
    decimal price = decimal.Parse(inputPieces[1]);
    decimal quantity = decimal.Parse(inputPieces[2]);

   

    if (!products.ContainsKey(currentProduct))
    {
        products.Add(currentProduct, new List<decimal>());
        products[currentProduct].Add(price);
        products[currentProduct].Add(quantity);

    } else
    {
        products[currentProduct][0] = price;
        products[currentProduct][1] += quantity;
        
    }

    input = Console.ReadLine();
}

foreach (KeyValuePair<string, List<decimal>> currentProduct in products)
{
    Console.WriteLine($"{currentProduct} -> {(currentProduct.Value[0] * currentProduct.Value[1]):F2}");

}