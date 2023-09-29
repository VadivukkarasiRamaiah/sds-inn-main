# Thank you for participating in our programming challenge!

Please review the requirements, and respond as directed below.

Hi and welcome to the SDS Inn. As you know, we are a small inn with a prime location in a prominent city run by a friendly innkeeper named Allison. We also buy and sell only the finest goods.

Unfortunately, our goods are constantly degrading in quality as they approach their sell by date. We have a system in place that updates our inventory for us. It was developed by a no-nonsense guy named Bob, who has moved on to new adventures.

Your task is to add the new feature to our system so that we can begin selling a new category of items.
First an introduction to our system:
- All items have a Sell-In value which denotes the number of days we have to sell the item.
- All items have a Quality value which denotes how valuable the item is.
- At the end of each day our system adjusts both values for every item.

Pretty simple, right? Well this is where it gets interesting:
- Once the Sell-In date has passed, Quality degrades twice as fast.
- The Quality of an item is never negative.
- "Aged Brie" actually increases in Quality as it ages.
- The Quality of an item is never more than 50.
- "Sulfuras", being a legendary item, never has to be sold or decreases in Quality.
- "Backstage passes", like aged brie, increases in Quality as it's Sell-In value approaches; Quality increases by 2 when there are 10 days or less and by 3 when there are 5 days or less but Quality drops to 0 after the concert.

We have recently signed a supplier of conjured items. This requires an update to our system:
- "Conjured" items degrade in Quality twice as fast as normal items

Feel free to make any changes to the UpdateQuality method and add any new code **as long as everything still works correctly**.  The business is happy with how current items are updating, so make sure not to break anything. However, do not alter the Item class or Items property as those belong to another team that doesn’t believe in shared code ownership.

This code sample is based on The Gilded Rose found here:
https://github.com/NotMyself/GildedRose
This code is slightly different from the original.
