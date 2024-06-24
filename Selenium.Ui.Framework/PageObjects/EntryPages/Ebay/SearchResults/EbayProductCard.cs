using Selenium.Ui.Framework.PageObjects.Shared.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selenium.Ui.Framework.PageObjects.EntryPages.Ebay.PrductDetails
{
    public class EbayProductCard : PomBase
    {
        private Link TitleLink => Select<Link>(".s-item__title");
        public void Click()
        {
            TitleLink.Click();
        }
    }
}
