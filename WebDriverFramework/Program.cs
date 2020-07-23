using System;
using WebDriverFramework.WebDriverBase;

namespace WebDriverFramework
{
    class Program
    {
        static void Main(string[] args)
        {
            MyWebDriverFactory driverFact = new MyWebDriverFactory();
            driverFact.LoadChromeOptions();
            var myDriver =  driverFact.InitializeBrowser();
            myDriver.NavigateToURL();
        }
    }
}
