using System;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

class EntryPoint
{        
    static IWebDriver driver = new ChromeDriver("/Users/matthewrizzini/Desktop/Visual Studio C# Projects/SeleniumC#/SettingUpEnvironment/bin/Debug/netcoreapp2.0");
    static IWebElement textBox;

    static void Main()
    {
        string url = "http://testing.todorvachev.com/special-elements/text-input-field";

        driver.Navigate().GoToUrl(url);

        textBox = driver.FindElement(By.Name("username"));

        textBox.SendKeys("Test text");

        Thread.Sleep(3000);

        // values we type in a text box are under "value"
        Console.WriteLine(textBox.GetAttribute("value"));

        Console.WriteLine(textBox.GetAttribute("maxlength"));

        textBox.Clear();

        Thread.Sleep(3000);

        driver.Quit();
    }


}
