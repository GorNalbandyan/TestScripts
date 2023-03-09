using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;

namespace AutomationExercises
{

    class BrowserHelper
    {
        public IWebDriver Browser()
        {
            var driver = new ChromeDriver();
            return driver;
        }
        
  
    }
}
