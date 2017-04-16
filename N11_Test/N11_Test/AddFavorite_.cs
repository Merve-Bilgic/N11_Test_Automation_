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
    class AddFavorite_:TestBase
    {
        [Test]
        public void Test4_AddFavorite()
        {
            //Açılan sayfada 3.ürünün favorilere eklenmesi

            IWebElement addFavorite = driver.FindElement(By.XPath(".//*[@id='p-163451171']/div[2]/span[2]"));
            addFavorite.Click();
        }
    }
}
