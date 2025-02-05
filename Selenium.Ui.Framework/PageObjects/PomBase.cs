﻿using OpenQA.Selenium;
using Selenium.UI.Framework.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selenium.Ui.Framework.PageObjects
{
    public abstract class PomBase
    {
        private IWebDriver _driver;
        private IWebElement _relatedElement;

        protected virtual IWebElement RelatedElement
        {
            get => _relatedElement ?? _driver.GetElement("body");
            set => _relatedElement = value;
        }

        public IWebDriver Driver
        {
            get => _driver ?? (_driver = ((IWrapsDriver)RelatedElement).WrappedDriver);
            set => _driver = value;
        }

        protected T Select<T>(string selector, int timeoutSeconds = 1) where T : PomBase, new()
        {
            return new T()
            {
                RelatedElement = RelatedElement.GetElement(selector),
            };
        }

        protected List<T> SelectAll<T>(string selector) where T : PomBase, new()
        {
            var elements = RelatedElement.GetElements(selector);

            return elements.Select(e => new T()
            {
                RelatedElement = e
            }).ToList();
        }

        protected string GetText(string text)
        {
            return RelatedElement.GetElement(text).Text;
        }
    }
}
