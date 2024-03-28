
public class Program
{
    static void Main(string[] args)
    {
        
        List<Box> boxes = new List<Box>();

        string input = Console.ReadLine();
        while (input != "end")
        {
            string[] dataParts = input.Split(" ");
            string serialNumber = dataParts[0];
            string itemName = dataParts[1];
            int itemQuantity = int.Parse(dataParts[2]);
            double itemPrice = double.Parse(dataParts[3]);

            Item currentItem = new Item()
            {
                Name = itemName,
                Price = itemPrice,
            };

            Box currentBox = new Box()
            {
                SerialNumber = serialNumber,
                Item = currentItem,
                ItemQuantity = itemQuantity,
                BoxPrice = itemQuantity * currentItem.Price,
            };

            boxes.Add(currentBox);

            input = Console.ReadLine();
        }

        boxes = boxes.OrderByDescending(box => box.BoxPrice).ToList();

        foreach (Box box in boxes)
        {
            Console.WriteLine($"{box.SerialNumber}");
            Console.WriteLine($"-- {box.Item.Name} - ${box.Item.Price:F2}: {box.ItemQuantity}");
            Console.WriteLine($"-- ${box.BoxPrice:F2}");
        }
    }
}


public class Item
{
    public string Name { get; set; }

    public double Price { get; set; }
}

public class Box
{
    public string SerialNumber { get; set; }

    public Item Item { get; set; }

    public int ItemQuantity { get; set; }

    public double BoxPrice { get; set; }

}

