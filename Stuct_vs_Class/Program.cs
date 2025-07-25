using System;

struct LaptopStruct
{
    public string Name { get; set; }
    public float Price { get; set; }
}

class LaptopClass(string name, float price)
{
    public string Name { get; set; } = name;
    public float Price { get; set; } = price;

    static void Purchase()
    {

    }
}


class Program
{
    static void Main(string[] args)
    {
        
        var asusStruct = new LaptopStruct()
        {
            Name = "ASUS Zenbook",
            Price = 1199.99f
        };
        var asusStruct2 = asusStruct;
        asusStruct2.Price = 1099.99f;
        Console.WriteLine($"Asus Struct 1's Price: {asusStruct.Price}");
        Console.WriteLine($"Asus Struct 2's Price: {asusStruct2.Price}");
        
        
        
        var asusClass = new LaptopClass("ASUS Zenbook", 1199.99f);
        var asusClass2 = asusClass;
        asusClass2.Price = 1099.99f;
        Console.WriteLine($"Asus Class 1's Price: {asusClass.Price}");
        Console.WriteLine($"Asus Class 2's Price: {asusClass2.Price}");
        
    }
}
