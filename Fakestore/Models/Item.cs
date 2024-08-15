namespace Fakestore.Models;
public class Item
{
    public int Id { get; set; }
    public string Title { get; set; }
    public decimal Price { get; set; }
    public string Description { get; set; }
    public string Category { get; set; }
    public string Image { get; set; }
    public double Rating { get; set; }
    public int RateCount { get; set; }
}

