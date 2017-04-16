using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace N11_Test
{
  public class TestBase
    {

        protected IWebDriver driver;

        [SetUp]
        public void Setup()
        {
            driver = new ChromeDriver();
            driver.Url = "http://www.n11.com/";
          //  driver.Manage().Timeouts().ImplicitlyWait(new TimeSpan(0, 0, 0, 10));
           
        }
        [TearDown]
        public void Cleanup()
        {
            driver.Quit();
        }
      
    }
}
