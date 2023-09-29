namespace Sds.Inn.DoNotChange;

public class ItemProvider : IItemProvider
{
    private

    IList<Item> _items = new List<Item>
    {
        new("+5 Dexterity Vest", 10, 20),
        new("Aged Brie", 2, 0),
        new("Elixir of the Mongoose", 5, 7),
        new("Sulfuras", 0, 80),
        new("Backstage passes", 15, 20),
        new("Conjured", 3, 6)
    };
    public IEnumerable<Item> GetItems()
    {
        return _items.ToArray();
    }
}
