using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;

namespace AutomationExercises
{
    class LoginPg
    {
        IWebDriver driver;
        public LoginPg(IWebDriver driver)
        {
            this.driver = driver;
        }
        public void OpenURl()
        {
            driver.Navigate().GoToUrl("https://www.globalsqa.com/angularJs-protractor/BankingProject/#/login");
        }

        public void ClickOnSmth()
        {
            driver.FindElement(By.Id("userSelect"));
        }
    }
}
