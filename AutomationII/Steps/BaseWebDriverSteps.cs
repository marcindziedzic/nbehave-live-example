using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;

namespace AutomationII
{
    public class BaseWebDriverSteps
    {
        public static IWebDriver driver;

        public static void Init()
        {
            driver = new FirefoxDriver();
        }

        public static void TearDown()
        {
            driver.Close();
        }
    }
}
