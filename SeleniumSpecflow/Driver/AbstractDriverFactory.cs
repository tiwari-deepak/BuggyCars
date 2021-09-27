using OpenQA.Selenium;
using OpenQA.Selenium.Support.Events;
using System;

namespace BuggyCarsRating.Driver
{
    public abstract class AbstractDriverFactory : IDriverFactory
    {
        public IWebDriver GetDriver()
        {
            var driver = new EventFiringWebDriver(BuildDriver());

            //log to console -- registering events 
            driver.ElementClicked += new EventHandler<WebElementEventArgs>((object sender, WebElementEventArgs e) =>
            {
                try { Console.WriteLine("Clicked element " + e.Element.TagName); } catch { }
            });
            driver.FindElementCompleted += new EventHandler<FindElementEventArgs>((object sender, FindElementEventArgs e) =>
            {
                try { Console.WriteLine("Found element " + e.FindMethod); } catch { }
            });
            return driver;
        }

        public abstract DriverOptions GetOptions();
        public abstract IDriverFactory SetHeadless(bool isHeadless);
        protected abstract IWebDriver BuildDriver();
    }
}
