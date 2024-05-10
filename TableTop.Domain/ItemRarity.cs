namespace TableTop.Domain;

/// <summary>
/// The rarity of an item is the likelihood of an item being available given someone is looking for that item. 
///
/// VeryCommon = If you ask someone they will likely have one or be able to acquire one, 99%
/// Common = Any given individual could have one, available market 90%
/// Uncommon = Most individuals could have one, available market 51%
/// Rare = 10% of people could even get one
/// VeryRare = 1% of people could even get one
/// Legendary = 0.1%
/// Artifact = Only one of this item in the world exists
/// </summary>
public class ItemRarityEnum
{
    public static ItemRarityEnum VeryCommon = new(0.99f, "Very Common", "Everyone has it or can get it, people don't even notice anymore");
    public static ItemRarityEnum Common = new(0.90f, "Common", "A large majority could but not everyone, most people wont notice but every once in a while someone will");
    public static ItemRarityEnum Uncommon = new(0.51f, "Uncommon", "Most people could get one");
    public static ItemRarityEnum Rare = new(0.10f, "Rare", "Probably not going to find one unless you look really hard");
    public static ItemRarityEnum VeryRare = new(0.01f, "Very Rare", "Seeing one is pretty cool and in small towns is an event");
    public static ItemRarityEnum Legendary = new(0.001f, "Legendary", "This is going to cause a spectacle as you aren't going to see one ever");
    /// <summary>
    /// An artifact may as well be 0% as there is only 1 that could exist for the entirety of the population
    /// </summary>
    public static ItemRarityEnum Artifact = new(0f, "Artifact", "Only one exists, people will come from all over to see it");

    public ItemRarityEnum(float rarityPercent, string name, string description)
    {
    }
}