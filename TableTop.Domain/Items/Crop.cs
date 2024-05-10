namespace TableTop.Domain.Items;

public class Crop : IItem
{
    public string Name { get; set; }
    public float Weight { get; set; }
    public float DimensionalWeight { get; set; }
}