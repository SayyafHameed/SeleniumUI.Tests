using Selenium.Ui.Framework.PageObjects.EntryPages.Ebay.PrductDetails;
using Selenium.Ui.Framework.PageObjects.Shared.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selenium.Ui.Framework.PageObjects.EntryPages.Ebay.SearchResults
{
    public class SearchResultsPage : EntryPageBase
    {
        public List<EbayProductCard> ProductCards => SelectAll<EbayProductCard>("#srp-river-results .s-item__");
    }
}
