using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ToolsQA
{
    class Subscribe
    {
        IWebDriver driver = new ChromeDriver();

    /*    [Test]
        public void TestSubscribe()
        {

            // Launche WebSite Roboshop
            driver.Url = "https://roboshop.com.ua/create-account/";

            // driver.FindElement(By.Id("newsletter")).Click();
            driver.FindElement(By.Id("newsletter")).SendKeys("29artur29@yopmail.com");
            driver.FindElement(By.Id("static-subscribe-button-footer")).Click();
            driver.Close();
        }
    */

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
           SelectElement cSelect = new SelectElement(driver.FindElement(By.Id("input-country")));

           cSelect.SelectByValue("67");

            Thread.Sleep(2000);

            SelectElement rSelect = new SelectElement(driver.FindElement(By.Id("input-zone")));
            rSelect.SelectByValue("1054");

            // Create  Password
            driver.FindElement(By.Id("input-password")).SendKeys("123456789");
            driver.FindElement(By.Id("input-confirm")).SendKeys("123456789");

            // Press the Button 
            driver.FindElement(By.XPath("/html/body[@class='account-register']/div[@id='oct-bluring-box']/div[@class='container']/div[@class='col-sm-12 content-row']/div[@id='content']/form[@class='form-horizontal']/div[@class='buttons']/div[@class='pull-right']/input[@class='oct-button']")).Click();


        }


        


    
    }
}
