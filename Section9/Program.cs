using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Interactions;

namespace Section8
{
    class EntryPoint3
    {
        static void Main(string[] args)
        {
            // Size size = new Size();
            // size.Width = 600;
            // size.Height = 600;

            // Point position = new Point();
            // position.X = 0;
            // position.Y = 0;

            List<string> handles = new List<string>();

            IWebDriver driver = new ChromeDriver("/Users/matthewrizzini/Desktop/Visual Studio C# Projects/SeleniumC#/SettingUpEnvironment/bin/Debug/netcoreapp2.0");
            IWebElement newTab;
            IWebElement newWindow;

            // driver.Navigate().GoToUrl("http://testing.todvachev.com/");
            // driver.Manage().Window.Size = size;
            // driver.Manage().Window.Position = position;

            string url = "http://testing.todvachev.com/tabs-and-windows/new-tab";
            string newTabSelector = "#post-182 > div > p:nth-child(1) > a:nth-child(1)";
            string newWindowSelector = "#post-182 > div > p:nth-child(1) > a:nth-child(3)";

            driver.Navigate().GoToUrl(url);

            newTab = driver.FindElement(By.CssSelector(newTabSelector));
            newWindow = driver.FindElement(By.CssSelector(newWindowSelector));

            newTab.Click();

            handles = driver.WindowHandles.ToList();

            for (int i = 0; i < handles.Count; i++)
            {
                System.Console.WriteLine(handles[i]);
            }

            IWebElement usernameBox = driver.FindElement(By.Name("username"));

            usernameBox.SendKeys("SELENIUM");

            System.Console.WriteLine(driver.CurrentWindowHandle);
            driver.SwitchTo().Window(handles[1]);

            IWebElement searchBox = driver.FindElement(By.Name("q"));

            searchBox.SendKeys("Selenium"); 

            // Actions actions = new Actions(driver);

            // actions.SendKeys(Keys.Control + "t").Build().Perform();     

            ((IJavaScriptExecutor)driver).ExecuteScript("window.open();");

            List<string> handles2 = driver.WindowHandles.ToList();

            driver.SwitchTo().Window(handles2[2]);
            driver.Navigate().GoToUrl("http://gmail.com");

            for (var i = 0; i < handles.Count; i++)
            {
                if (i != 2)
                {
                    driver.SwitchTo().Window(handles[i]);
                    driver.Close();
                }
            }
        }
    }
}
