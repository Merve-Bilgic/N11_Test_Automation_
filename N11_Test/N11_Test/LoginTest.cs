using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace N11_Test
{
    [TestFixture]
   public  class LoginTest:TestBase
    {

        [Test]
        public void Test1_Login()
        {
            
            IWebElement btnLoginPage = driver.FindElement(By.XPath(".//*[@class='btnSignIn']"));
            btnLoginPage.Click();

            //email ve password otamatik girilmesi
            driver.FindElement(By.Id("email")).SendKeys("merve.blgc@hotmail.com");
            driver.FindElement(By.Id("password")).SendKeys("Merve123/*-" + Keys.Enter);
          //  driver.Manage().Timeouts().ImplicitlyWait(new TimeSpan(0, 0, 0, 10));

            
            

        }

    }
}
