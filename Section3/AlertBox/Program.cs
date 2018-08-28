using System;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

class EntryPoint
{        
    static IWebDriver driver = new ChromeDriver("/Users/matthewrizzini/Desktop/Visual Studio C# Projects/SeleniumC#/SettingUpEnvironment/bin/Debug/netcoreapp2.0");

    static IAlert alert;
    static IWebElement image;


    static void Main()
    {
        string url = "http://testing.todvachev.com/special-elements/alert-box/";


        driver.Navigate().GoToUrl(url);

        alert = driver.SwitchTo().Alert();

        System.Console.WriteLine(alert.Text);

        alert.Accept();

        image = driver.FindElement(By.CssSelector("#post-119 > div > figure > img"));

        try
        {
            if (image.Displayed)
            {
                System.Console.WriteLine("Alert was successfully accepeted and i can see image");
            } 
        }
        catch (NoSuchElementException)
        {
            System.Console.WriteLine("Something went wrong");            
        }

        Thread.Sleep(3000);


        driver.Quit();
    }


}
