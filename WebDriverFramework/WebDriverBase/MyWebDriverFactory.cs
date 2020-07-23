using Nancy.Json;
using Newtonsoft.Json;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Text;

namespace WebDriverFramework.WebDriverBase
{
    public class MyWebDriverFactory
    {
        public static string ChromeOptionsJsonPath = AppDomain.CurrentDomain.BaseDirectory + "chromeOptions.json";
        private MyWebDriver _myWebDriver;

        public ChromeOptions LoadChromeOptions(string path = "")
        {
            var chromeOptions = new ChromeOptions();

            var chromeOptionsDict = LoadChromeOptionsFromJSON(path);
            foreach(var key in chromeOptionsDict)
            {
                chromeOptions.AddUserProfilePreference(key.Key, key.Value);
            }
            return chromeOptions;
        }

        public MyWebDriver InitializeBrowser()
        {
            _myWebDriver = new MyWebDriver();
            return _myWebDriver;
        }

        private Dictionary<string,string> LoadChromeOptionsFromJSON(string path = "")
        {
            var jsonString = path.Equals("") ? File.ReadAllText(ChromeOptionsJsonPath) : File.ReadAllText(path);
            return JsonConvert.DeserializeObject<Dictionary<string, string>>(jsonString);
        }


    }
}
