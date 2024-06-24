using OpenQA.Selenium;
using Selenium.Ui.Framework.Factories.Interface;
using Selenium.Ui.Framework.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selenium.Ui.Framework.Factories
{
    public static class EntryPageFactory
    {
        // Creates an entry page.
        public static TPage Create<TPage>(IWebDriver driver) where TPage : PomBase, IEntryPage, new()
        {
            var page = new TPage()
            {
                Driver = driver
            };
            page.Initialize();

            return page;
        }
    }
}
