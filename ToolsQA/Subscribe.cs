using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToolsQA
{
    class Subscribe
    {
        IWebDriver driver = new ChromeDriver();

        [Test]
        public void TestSubscribe()
        {

            // Launche WebSite Roboshop
            driver.Url = "https://roboshop.com.ua/create-account/";

            // driver.FindElement(By.Id("newsletter")).Click();
            driver.FindElement(By.Id("newsletter")).SendKeys("29artur29@yopmail.com");
            driver.FindElement(By.Id("static-subscribe-button-footer")).Click();
            driver.Close();
        }

        [Test]
        public void Registration()
        {

            // Launch the registration page
            driver.Url = "https://roboshop.com.ua/create-account/";

            // Enter data in fields
            driver.FindElement(By.Id("input-firstname")).SendKeys("Test1");
            driver.FindElement(By.Id("input-lastname")).SendKeys("lastname");
            driver.FindElement(By.Id("input-email")).SendKeys("29artur29@yopmail.com");
            driver.FindElement(By.Id("input-telephone")).SendKeys("0001112233");
            driver.FindElement(By.Id("input-address-1")).SendKeys("Kiev");
            driver.FindElement(By.Id("input-city")).SendKeys("kiev");






           // DropDown Box Country/Region
           // SelectElement oSelection = new SelectElement(driver.FindElement(By.Id("input-country")));

           // oSelection.SelectByValue("67");

        }


        


    
    }
}
