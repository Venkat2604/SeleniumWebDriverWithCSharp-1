using System;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

class EntryPoint
{        
    static IWebDriver driver = new ChromeDriver("/Users/matthewrizzini/Desktop/Visual Studio C# Projects/SeleniumC#/SettingUpEnvironment/bin/Debug/netcoreapp2.0");
    static IWebElement checkBox;

    static void Main()
    {
        string url = "http://testing.todorvachev.com/special-elements/check-button-test-3";
        string option = "1";

        driver.Navigate().GoToUrl(url);

        checkBox = driver.FindElement(By.CssSelector("#post-33 > div > p:nth-child(8) > input[type=\"checkbox\"]:nth-child(" + option + ")"));

        if (checkBox.GetAttribute("checked") == "true")
        {
            Console.WriteLine("Checkbox is checked");
        }
        else
        {
            System.Console.WriteLine("Checkbox is not checked");
        }

        System.Console.WriteLine(checkBox.GetAttribute("value"));

        checkBox.Click();

        Thread.Sleep(3000);

        driver.Quit();
    }


}
