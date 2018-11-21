using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToolsQA
{
    class DriverCommands
    {
        [Test]
        public void Test()
        {
            IWebDriver driver = new ChromeDriver();

            // Launch the RoboSHop Website
            driver.Url = "https://roboshop.com.ua/create-account/";

            // Storing Title name in String variable
            String Title = driver.Title;

            // Storing Title Lenght in Int variable
            int TitleLenght = driver.Title.Length;

            // Printing Title name on Console
            Console.WriteLine("Tittle of the page is : " + Title);

            // Printing Title lenght on console
            Console.WriteLine("Lenght of the title is: " + TitleLenght);

            // Storing URL in string variable
            String PageUrl = driver.Url;

            // Storing URL lenght in int variable
            int PageLenght = driver.Url.Length;

            // Printing URL name on Console
            Console.WriteLine("URL name of the page is: " + PageUrl);

            // Printing URL lenght on Console
            Console.WriteLine("Lenght of the URL is: " + PageLenght);

            // Storing Page Source in String variable
            // String PageSource = driver.PageSource;

            // Storing Page Source length in Int variable
            int PageSourceLength = driver.PageSource.Length;

            // Printing Page Source in Console
            // Console.WriteLine("Page Source of the page is: " + PageSource);

            //Printing Page Source length in Console
            Console.WriteLine("Page Source length of the page is: " + PageSourceLength);

            //Closing Browser
            driver.Close();
                                    
        }
    }
}
