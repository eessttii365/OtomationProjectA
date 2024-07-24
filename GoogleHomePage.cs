using OpenQA.Selenium;
using OpenQA.Selenium.DevTools.V123.Page;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumNunitExample
{
    internal class GoogleHomePage
    {
        private IWebDriver driver;

        public GoogleHomePage(IWebDriver driver)
        {
            this.driver = driver;
        }
        private IWebElement SearchBox => driver.FindElement(by.Name("q"));
        private IWebElement SearchButton => driver.FindElement(by.Name("btnk"));


        public NavigateTo()
        {
            driver.Navigate().GoToUrl("https://www.google.com");
        }

        public void Search(String query)
        {
            SearchBox.SendKeys(query);
            SearchBox.Submit();
        }
    }
}
