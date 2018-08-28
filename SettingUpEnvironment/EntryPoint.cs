using System;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

class EntryPoint
{
    static void Main()
    {
        IWebDriver driver = new ChromeDriver("/Users/matthewrizzini/Desktop/Visual Studio C# Projects/SeleniumC#/SettingUpEnvironment/bin/Debug/netcoreapp2.0");
        driver.Navigate().GoToUrl("http://testing.todorvachev.com/selectors/name");
        
        IWebElement element = driver.FindElement(By.Name("myName"));
        
        if (element.Displayed)
        {
            GreenMessage("Yes I can see the element, it's right there!!");
        }
        else
        {
            RedMessage("Well, something went wrong, I couldn't see the element");
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
