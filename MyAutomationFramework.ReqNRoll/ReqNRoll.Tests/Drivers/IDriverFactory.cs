using OpenQA.Selenium;

namespace ReqNRoll.Tests.Drivers;
public interface IDriverFactory
{
    IWebDriver CreateWebDriver();
}

