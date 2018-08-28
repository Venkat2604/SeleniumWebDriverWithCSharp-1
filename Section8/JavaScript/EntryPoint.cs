using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Section8
{
    class EntryPoint
    {
        static void Main(string[] args)
        {
            IWebDriver driver = new ChromeDriver("/Users/matthewrizzini/Desktop/Visual Studio C# Projects/SeleniumC#/SettingUpEnvironment/bin/Debug/netcoreapp2.0");
            string url = "http://testing.todvachev.com";

            driver.Navigate().GoToUrl(url);

            // IWebElement image = driver.FindElement(By.CssSelector("#page-17 > div > p:nth-child(1) > a > img"));

            // Console.WriteLine(image.Location.X);
            // Console.WriteLine(image.Location.Y);
            // System.Console.WriteLine(image.Size);
            // System.Console.WriteLine(image.Size.Width);
            // System.Console.WriteLine(image.Size.Height);

            // IJavaScriptExecutor jsExecutor = (IJavaScriptExecutor)driver;
            // string script = "arguments[0].style[\"display\"] = \"none\"";
            // jsExecutor.ExecuteScript(script, image);


            IWebElement content = driver.FindElement(By.CssSelector("#page-17 > div"));
            // script = "arguments[0].style[\"color\"] = \"red\"";
            // jsExecutor.ExecuteScript(script, content);

            SetStyle(driver, content, "color", "green");

        }

        static void SetStyle(IWebDriver driver, IWebElement element, string style, string styleValue)
        {
            string script = String.Format("arguments[0].style[\"{0}\"] = \"{1}\"", style, styleValue);
            IJavaScriptExecutor jsExecutor = (IJavaScriptExecutor)driver;
            jsExecutor.ExecuteScript(script, element);

        }
    }
}
