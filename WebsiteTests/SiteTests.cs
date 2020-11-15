using System;
using Xunit;
using Website.Pages;
using BleakwindBuffet.Data.Menu;
using BleakwindBuffet.Data.Drinks;
using BleakwindBuffet.Data.Sides;
using BleakwindBuffet.Data.Entrees;

namespace WebsiteTests  
{
    public class SiteTests
    {
        [Fact]
        public void FilterBySearchShouldGiveCorrectItems()
        {
            IEnumerable<IOrderItem> flavor = Menu.Search("Cherry");

        }
    }
}
