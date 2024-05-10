namespace TableTop.Domain;

public interface IItem
{
    public string Name { get; set; }
    public float Weight { get; set; }
    /// <summary>
    /// Also known as Volumetric Weight
    /// </summary>
    public float DimensionalWeight { get; set; }
}