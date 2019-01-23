using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;

namespace KeytorcTest.PageModels
{
    public static class CurrentDriver
    {
        public static IWebDriver driver;

        public static void SelectDriver(string driverName)
        {
            switch (driverName)
            {
                case "Chrome":
                    driver = new ChromeDriver();
                    break;
                case "Firefox":
                    driver = new FirefoxDriver();
                    break;
                case "IE":
                    driver = new InternetExplorerDriver();
                    break;
                default:
                    driver = new ChromeDriver();
                    break;
            }
            driver.Manage().Window.Maximize();
        }

        public static void OpenWebSite(string driverName)
        {
            driver.Navigate().GoToUrl(driverName);
        }

        public static void QuitDriver()
        {
            driver.Quit();
        }
    }
}
