using FluentAssertions;
using NUnit.Framework;
using NUnit.Framework.Legacy;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Linq;
using Selenium.UI.Framework.Extensions;
using Selenium.Ui.Framework.Factories;
using Selenium.Ui.Framework.PageObjects.EntryPages.Login;
using Selenium.Ui.Framework.PageObjects.EntryPages.Inventory;

namespace SeleniumUI.Tests.TestFixtures
{
    internal class SeleniumTests
    {
        //[Test]
        public void SuaceLabDemo() 
        {
            // Launch browser
            var driver = new ChromeDriver();

            // Navigate to Suace lab
            driver.Url = "https://saucedemo.com";

            // Login
            var userNameFaild = driver.GetElement("#user-name");
            userNameFaild.SendKeys("standard_user");

            var passwordFaild = driver.GetElement("#password");
            passwordFaild.SendKeys("secret_sauce");

            var loginButton = driver.GetElement("#login-button");
            loginButton.Click();

            // Get product names
            var titleElements = driver.GetElements(".inventory_item_name");
            var titles = titleElements.Select(x => x.Text).ToList();

            // Verfiy backpack is persent
            ClassicAssert.Contains("Suace Labs Backpack",  titles);
        }

        [Test]
        public void SuaceLabDemo_POM()
        {
            // Launch browser
            var driver = new ChromeDriver();

            // Navigate to Suace lab
            driver.Url = "https://saucedemo.com";

            // Login
            var loginPage = EntryPageFactory.Create<LoginPage>(driver);
            loginPage.UserName.SetValue("standard_user");
            loginPage.Password.SetValue("secret_sauce");
            loginPage.LoginButton.Click();
            
            // Get product names
            var inventoryPage = EntryPageFactory.Create<InventoryPage>(driver);
            var productName = inventoryPage.Cards.Select(x => x.Title).ToList();;

            // Verfiy backpack is persent
            productName.Should().Contain("Suace Labs Backpack");
        }
    }
}
