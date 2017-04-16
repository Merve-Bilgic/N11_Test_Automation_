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
    public class RemoteFavorite_:TestBase
    {
        [Test]
        public void Test6_RemoveFavorite()
        {
            //Ürünün favoriler kısmından kaldırılması
            IWebElement removeFavorite = driver.FindElement(By.XPath(".//*[@id='watchList']/tbody/tr/td[1]/a"));
            removeFavorite.Click();
        }
    }
}
