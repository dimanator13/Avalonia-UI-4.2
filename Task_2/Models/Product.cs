namespace Task_2.Models;

public class Product
{
    public string Name { get; set; }
    public string Articular { get; set; }
    public string Cost { get; set; }
    public string Quantity { get; set; }
    public string Description { get; set; }

    public Product(string? name, string? articular, string? cost, string? quantity, string? description)
    {
        Name = name ?? "";
        Articular = articular ?? "";
        Cost = cost ?? "";
        Quantity = quantity ?? "";
        Description = description ?? "";
    }
}