using AutomationExercises;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace XYZBank
{
    public class XYZBank
    {
        IWebDriver driver;
        
        public void DriverInit()
        {
            driver = new ChromeDriver();
        }

        //Task: URL: https://www.globalsqa.com/angularJs-protractor/BankingProject/#/login
        //Verify that Customers' list is the same in Customer Login page and in Bank Manager Login/Customers tab
        [Test]
        public void LoginToPage()
        {
             new LoginPg(driver).OpenURl();
            
            new Pages(driver).DoActions();
            new LoginPg(driver).ClickOnSmth();
        }

    }
}