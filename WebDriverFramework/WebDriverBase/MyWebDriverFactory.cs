using System;
using System.Collections.Generic;
using System.Text;

namespace WebDriverFramework.WebDriverBase
{
    public class MyWebDriverFactory
    {
        private MyWebDriver _myWebDriver;
        public void InitializeBrowser()
        {
            _myWebDriver = new MyWebDriver();
        }

    }
}
