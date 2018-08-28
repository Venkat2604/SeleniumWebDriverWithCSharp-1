﻿using System;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

class EntryPoint
{
    static void Main()
    {
        string url = "http://testing.todorvachev.com/selectors/css-path";
        string cssPath = "#post-108 > div > img";
        string xPath = "//*[@id=\"post-108\"]/div/figure/img";
        IWebDriver driver = new ChromeDriver("/Users/matthewrizzini/Desktop/Visual Studio C# Projects/SeleniumC#/SettingUpEnvironment/bin/Debug/netcoreapp2.0");
        driver.Navigate().GoToUrl(url);
        
        IWebElement cssPathElement;
        IWebElement xPathElement = driver.FindElement(By.XPath(xPath));

        try
        {
            cssPathElement = driver.FindElement(By.CssSelector(cssPath));
            if (cssPathElement.Displayed)
            {
                GreenMessage("I can see the CSS Path Element");
            }
        }
        catch (NoSuchElementException)
        {
            RedMessage("I can't see the CSS Path Element");            
        }

        if (xPathElement.Displayed)
        {
            GreenMessage("I can see the X Path Element");
        }
        else
        {
            RedMessage("I can't see the X Path Element");
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
