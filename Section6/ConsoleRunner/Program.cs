﻿using System;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Chrome;
using System.IO;

class EntryPoint
{        
    static IWebDriver driver = new ChromeDriver("/Users/matthewrizzini/Desktop/Visual Studio C# Projects/SeleniumC#/SettingUpEnvironment/bin/Debug/netcoreapp2.0");

    static void Main()
    {
        string url = "http://google.com";


        driver.Navigate().GoToUrl(url);





        driver.Quit();
    }


}
