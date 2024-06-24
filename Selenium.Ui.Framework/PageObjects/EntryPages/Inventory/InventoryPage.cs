using Selenium.UI.Framework.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selenium.Ui.Framework.PageObjects.EntryPages.Inventory
{
    public class InventoryPage : EntryPageBase
    {
        public override void Initialize()
        {
        }
        public List<ProductCard> Cards => SelectAll<ProductCard>(".inventory_item_name");
    }
}
