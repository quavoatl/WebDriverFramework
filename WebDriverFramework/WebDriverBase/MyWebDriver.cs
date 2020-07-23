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
        public ChromeDriver Driver { get => _chromeDriver; set => _chromeDriver = value; }

        public MyWebDriver(ChromeOptions chromeOptions = null)
        {
            if (chromeOptions == null)
            {
                try
                {
                    throw new InvalidOperationException();
                }
                catch (InvalidOperationException ex)
                {
                    Console.WriteLine("Forgot to Load chrome Options from the JSON");
                    Console.ReadLine();
                }
            }

            _chromeDriver = new ChromeDriver(_chromeOptions);
            _chromeDriver.Manage().Window.Maximize();
            _chromeDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
        }

        public void NavigateToURL(string URL = "https://playtech.ro/stiri/wp-content/uploads/2020/01/romeo-fantastik-manea-despre-coronavirus-1-840x500.jpg")
        {
            Driver.Navigate().GoToUrl(URL);
        }


    }
}
