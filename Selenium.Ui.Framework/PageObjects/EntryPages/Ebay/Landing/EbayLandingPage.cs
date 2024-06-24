using OpenQA.Selenium;
using Selenium.Ui.Framework.PageObjects.Shared.Fields;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selenium.Ui.Framework.PageObjects.EntryPages.Ebay.Landing
{
    public class EbayLandingPage : EntryPageBase
    {
        private TextField searchBar => Select<TextField>("input#gh-ac");
        public void Search(string text)
        {
            searchBar.SetValue(text + Keys.Enter);
        }
    }
}
