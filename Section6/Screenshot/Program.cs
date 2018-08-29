using System;
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
            string screenshotsDirectory = Directory.GetCurrentDirectory() + @"\screenshots";


            driver.Navigate().GoToUrl("https://www.google.com");

            Screenshot googleScreenShot = ((ITakesScreenshot)driver).GetScreenshot();

            if (!Directory.Exists(screenshotsDirectory))
            {
                Directory.CreateDirectory(Directory.GetCurrentDirectory() + @"\screenshots\");
            }

            googleScreenShot.SaveAsFile(Directory.GetCurrentDirectory() + @"\screenshots\googlescreenshot.png", ScreenshotImageFormat.Png);

            driver.Quit();
        }


}
