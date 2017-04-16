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
   public class SearchProduct_:TestBase
    {
        [Test]
        public void Test2_SearchProduct()
        {
            //driver.Url = "http://www.n11.com/";
            IWebElement btnSearch = driver.FindElement(By.XPath("//*[@id='searchData']"));

            //Samsung kelimesini arama
            driver.FindElement(By.Id("searchData")).SendKeys("samsung");
            IWebElement searchBtn = driver.FindElement(By.XPath(".//*[@class='searchBtn']"));
            searchBtn.Click();
        }

        [Test]
        public void Test3_SecondPage()
        {
            //Aranan samsung kelimesinin 2.sayfadaki sonuçlarını gösterme
            IWebElement page2 = driver.FindElement(By.XPath("//*[@id='contentListing']/div/div/div[2]/div[3]/a           [2]"));
            page2.Click();

        }

    }
}
