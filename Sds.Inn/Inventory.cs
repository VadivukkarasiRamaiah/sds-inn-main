using System;
using System.Collections.Generic;
using System.Linq;
using Sds.Inn.DoNotChange;

namespace Sds.Inn
{
    public class Inventory
    {
        private readonly IItemProvider _itemProvider;

        public Inventory(IItemProvider itemProvider)
        {
            _itemProvider = itemProvider;
        }

        public void UpdateQuality()
        {
            var items = _itemProvider.GetItems().ToList();

            for (var i = 0; i < items.Count; i++)
            {
                var item = items[i];

                // Check if the item is not "Sulfuras"
                if (item.Name != "Sulfuras")
                {
                    // Decrease the SellIn value for all items (except "Sulfuras")
                    item.SellIn--;

                    // Determine the rate at which quality should degrade
                    int qualityChange = 1;
                    if (item.Name == "Conjured")
                    {
                        // Conjured items degrade twice as fast
                        qualityChange = 2;
                    }

                    // Check if the item is "Aged Brie" or "Backstage passes"
                    if (item.Name == "Aged Brie" || item.Name == "Backstage passes")
                    {
                        // Increase quality for "Aged Brie" and "Backstage passes"
                        if (item.Quality < 50)
                        {
                            item.Quality++;
                            if (item.Name == "Backstage passes")
                            {
                                // Special rules for "Backstage passes"
                                if (item.SellIn < 11)
                                {
                                    if (item.Quality < 50)
                                    {
                                        item.Quality++;
                                    }
                                }
                                if (item.SellIn < 6)
                                {
                                    if (item.Quality < 50)
                                    {
                                        item.Quality++;
                                    }
                                }
                            }
                        }
                    }
                    else
                    {
                        // Decrease quality for other items (except "Sulfuras")
                        if (item.Quality > 0)
                        {
                            item.Quality -= qualityChange;
                        }
                    }

                    // If the sell-by date has passed, degrade quality twice as fast
                    if (item.SellIn < 0 && item.Name != "Aged Brie")
                    {
                        if (item.Name != "Backstage passes")
                        {
                            if (item.Quality > 0)
                            {
                                item.Quality -= qualityChange;
                            }
                        }
                        else
                        {
                            // Quality drops to 0 for "Backstage passes" after the concert
                            item.Quality = 0;
                        }
                    }
                }
            }
        }
    }
}
