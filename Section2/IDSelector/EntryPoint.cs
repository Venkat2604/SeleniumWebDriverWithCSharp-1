using System;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

class EntryPoint
{
    static void Main()
    {
        string url = "http://testing.todorvachev.com/selectors/id";
        string id = "testImage";
        IWebDriver driver = new ChromeDriver("/Users/matthewrizzini/Desktop/Visual Studio C# Projects/SeleniumC#/SettingUpEnvironment/bin/Debug/netcoreapp2.0");
        driver.Navigate().GoToUrl(url);
        
        IWebElement element = driver.FindElement(By.Id(id));
        
        if (element.Displayed)
        {
            GreenMessage("Yes I can see it!");
        }
        else
        {
            RedMessage("Nope it's not there");
        }

        driver.Quit();
    }

    private static void RedMessage(string message)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        System.Console.WriteLine(message);
        Console.ForegroundColor = ConsoleColor.White;        
    }

    private static void GreenMessage(string message)
    {
        Console.ForegroundColor = ConsoleColor.Green;
        System.Console.WriteLine(message);
        Console.ForegroundColor = ConsoleColor.White;     
    }
}
