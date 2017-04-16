using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;

namespace N11_Test
{
     [TestFixture]
   public class FavoritePage_:TestBase
    {

        [Test]
        public void Test5_FavoritePage()
        {
            //Hesabım linkinden favorilerime girme
            IWebElement favoritePage = driver.FindElement(By.XPath(".//*[@id='header']/div/div/div[2]/div[2]/div[1]/div[2]/div/a[2]"));
            favoritePage.Click();
        }
       
    }
}
