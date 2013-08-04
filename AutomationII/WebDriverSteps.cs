using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using OpenQA.Selenium;
using NBehave.Narrator.Framework;

namespace AutomationII
{
    [ActionSteps]
    public class WebDriverSteps : BaseWebDriverSteps
    {
        [Given("opened page $url")]
        public void openedPage(String url)
        {
            Console.WriteLine("url -> " + url);
            driver.Navigate().GoToUrl(url);
        }

        [Then("I can see Google tag")]
        public void IcanSeeGoogleTag() 
        {
            Console.WriteLine("I can see google tag trully");
        }

    }
}
