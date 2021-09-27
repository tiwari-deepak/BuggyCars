using OpenQA.Selenium;

namespace BuggyCarsRating.Driver
{
    public interface IDriverFactory
    {
        IWebDriver GetDriver();

        DriverOptions GetOptions();

        IDriverFactory SetHeadless(bool isHeadless);
    }
}
