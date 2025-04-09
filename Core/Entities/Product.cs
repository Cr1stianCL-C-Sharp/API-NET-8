namespace Core.Entities;

public partial class Product
{
    public uint Id { get; set; }

    public string ProductCode { get; set; } = null!;

    public string Name { get; set; } = null!;

    public uint Quantity { get; set; }

    public decimal Price { get; set; }
}
