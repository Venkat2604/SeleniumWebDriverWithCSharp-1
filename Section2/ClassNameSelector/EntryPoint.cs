using System;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

class EntryPoint
{
    static void Main()
    {
        string url = "http://testing.todorvachev.com/selectors/class-name";
        string id = "testClass";
        IWebDriver driver = new ChromeDriver("/Users/matthewrizzini/Desktop/Visual Studio C# Projects/SeleniumC#/SettingUpEnvironment/bin/Debug/netcoreapp2.0");
        driver.Navigate().GoToUrl(url);
        
        IWebElement element = driver.FindElement(By.ClassName(id));
        
        Console.WriteLine(element.Text);

        driver.Quit();
    }
}
