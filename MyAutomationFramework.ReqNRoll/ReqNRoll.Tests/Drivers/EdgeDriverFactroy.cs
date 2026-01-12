using OpenQA.Selenium;
using OpenQA.Selenium.Edge;
using ReqNRoll.Tests.Drivers;

namespace ReqNRollSauceDemo.Tests.Drivers;
public class EdgeDriverFactory : IDriverFactory
{
    public IWebDriver CreateWebDriver()
    {
        var options = new EdgeOptions();
        options.AddArgument("--headless=new");
        options.AddArgument("--disable-popup-blocking");
        var driver = new EdgeDriver(options);
        driver.Manage().Window.Maximize();
        return driver;
    }
}
