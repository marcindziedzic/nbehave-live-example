using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using NBehave.Narrator.Framework.Hooks;

namespace AutomationII
{
    [Hooks]
    public class GlobalHooks
    {
        private static string ImaginaryWebDriver;

        [BeforeRun]
        public void BeforeRun()
        {
            BaseWebDriverSteps.Init();
            ImaginaryWebDriver = "ImaginaryWebDriver_" + new Random().Next(10000);
        }

        [AfterRun]
        public void AfterRun()
        {
            BaseWebDriverSteps.TearDown();
            print("AfterRun, closing web driver -> " + ImaginaryWebDriver);
        }

        [BeforeFeature]
        public void BeforeFeature()
        {
            print("BeforeFeature");
            NBehave.Narrator.Framework.FeatureContext.Current["webdriver"] = ImaginaryWebDriver;
        }

        [AfterFeature]
        public void AfterFeature()
        {
            print("AfterFeature");
        }

        [BeforeScenario]
        public void BeforeScenario()
        {
            print("BeforeScenario");
        }

        [AfterScenario]
        public void AfterScenario()
        {
            print("AfterScenario");
        }

        [BeforeStep]
        public void BeforeStep()
        {
            print("BeforeStep");
        }

        [AfterStep]
        public void AfterStep()
        {
            print("AfterStep");
        }

        private void print(string msg)
        {
            Console.WriteLine("[Hook] " + msg);
        }
    }
}
