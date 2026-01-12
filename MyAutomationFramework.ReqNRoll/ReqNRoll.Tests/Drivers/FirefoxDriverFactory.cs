using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using ReqNRoll.Tests.Drivers;

namespace ReqNRollSauceDemo.Tests.Drivers;
public class FirefoxDriverFactory : IDriverFactory
{
    public IWebDriver CreateWebDriver()
    {
        var options = new FirefoxOptions();
        options.AddArgument("--headless=new");
        options.AddArgument("--disable-popup-blocking");
        var driver = new FirefoxDriver(options);
        driver.Manage().Window.Maximize();
        return driver;

    }
}
