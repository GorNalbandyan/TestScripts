using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;

namespace AutomationExercises
{
    class Pages
    {
        IWebDriver driver;
        public Pages(IWebDriver driver)
        {
            this.driver = driver;
        }
        public void DoActions()
        {
            driver.FindElement(By.CssSelector("body > div > div > div.ng-scope > div > div.borderM.box.padT20 > div:nth-child(1) > button")).Click();
        }
    }
}
