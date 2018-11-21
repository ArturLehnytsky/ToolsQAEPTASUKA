using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToolsQA
{
    class NUnitTest
    {

        IWebDriver driver;
        

        [SetUp]
        public void Initialize()
        {
            driver = new ChromeDriver();
        }


        [Test]    
        public void OpenAppTest()
        {
            driver.Url = "https://roboshop.com.ua/create-account/";

        }

        [TearDown]
        public void EndTest()
        {
            driver.Close();
        }

        
    }
}
