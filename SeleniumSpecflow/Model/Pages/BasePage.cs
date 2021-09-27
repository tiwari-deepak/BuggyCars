using OpenQA.Selenium;
using BuggyCarsRating.Model.Helpers;

namespace BuggyCarsRating.Model.Pages
{
    public abstract class BasePage
    {
        protected IWebDriver driver;
        public WaitHelperTools waitHelper;

        public IWebElement BuggyRatingLink => driver.FindElement(By.XPath("//a[@class='navbar-brand'][text()='Buggy Rating']"));

        protected BasePage(IWebDriver driver)
        {
            this.driver = driver;
            waitHelper = new WaitHelperTools(driver);
        }
    }
}
