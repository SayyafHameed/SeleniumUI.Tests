using Selenium.Ui.Framework.PageObjects.Shared.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selenium.Ui.Framework.PageObjects.EntryPages.Ebay.PrductDetails
{
    public class ProductDetailsPage : EntryPageBase
    {
        public string Price => GetText("[data-testid='x-price-primary']");
        
    }
}
