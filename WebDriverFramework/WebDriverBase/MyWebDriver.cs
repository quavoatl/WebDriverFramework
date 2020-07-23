using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;

namespace WebDriverFramework.WebDriverBase
{
    public class MyWebDriver
    {
        private ChromeOptions _chromeOptions;
        private ChromeDriver _chromeDriver;

        public ChromeOptions ChromeOptions { get => _chromeOptions; set => _chromeOptions = value; }

        public MyWebDriver()
        {
            _chromeDriver = new ChromeDriver(_chromeOptions);
            _chromeDriver.Manage().Window.Maximize();
            _chromeDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
        }

        public void SetChromeDriverOptions(ChromeOptions chromeOptions)
        {
            _chromeOptions = chromeOptions;
        }



    }
}
