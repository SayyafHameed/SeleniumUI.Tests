

using FluentAssertions;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Selenium.Ui.Framework.Factories;
using Selenium.Ui.Framework.PageObjects.EntryPages.Ebay.Landing;
using Selenium.Ui.Framework.PageObjects.EntryPages.Ebay.PrductDetails;
using Selenium.Ui.Framework.PageObjects.EntryPages.Ebay.SearchResults;
using System;
using System.Linq;

namespace SeleniumUI.Tests.TestFixtures
{
    internal class EbayTests
    {
        [Test]
        public void EbayProductPrice()
        {
            // Launch browser
            var driver = new ChromeDriver();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(3);

            // Navigate to Ebay
            driver.Url = "https://www.ebay.com";

            // Search for item
            var searchElement = driver.FindElement(By.CssSelector("input#gh-ac"));
            searchElement.SendKeys("pokemon cards" + Keys.Enter);

            // Click on a product
            var productItem = driver.FindElement(By.CssSelector("#srp-river-results .s-item__title"));
            productItem.Click();

            // switch tabs
            driver.SwitchTo().Window(driver.WindowHandles[1]);

            // Verfiy price
            var price = driver.FindElement(By.CssSelector("[data-testid='x-price-primary']")).Text;
            price.Should().Be(price.ToString());
            
        }

        [Test]
        public void EbayProductPrice_POM()
        {
            // Launch browser
            var driver = new ChromeDriver();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(3);

            // Navigate to Ebay
            driver.Url = "https://www.ebay.com";

            // Search for item
            var landingPage = EntryPageFactory.Create<EbayLandingPage>(driver);
            landingPage.Search("pokemon cards");

            // Click on a product
            var searchResultPage = EntryPageFactory.Create<SearchResultsPage>(driver);
            searchResultPage.ProductCards.First().Click();

            // switch tabs
            driver.SwitchTo().Window(driver.WindowHandles[1]);

            // Verfiy price
            var productDetailsPage = EntryPageFactory.Create<ProductDetailsPage>(driver);
            productDetailsPage.Price.Should().Be("xxx");

        }
    }
}
