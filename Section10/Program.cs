using System;
using System.Collections.Generic;
using System.IO;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Section8
{
    class EntryPoint4
    {
        static void Main(string[] args)
        {

            List<string> extractedLinks = new List<string>();
            List<string> extractedTitle = new List<string>();
            List<string> extractedContent = new List<string>();
            
            ChromeOptions options = new ChromeOptions();
            options.AddArgument("--headless");
            IWebDriver driver = new ChromeDriver("/Users/matthewrizzini/Desktop/Visual Studio C# Projects/SeleniumC#/SettingUpEnvironment/bin/Debug/netcoreapp2.0", options);
            IWebElement titleElement;
            IWebElement contentElement;

            string sitemapURL = "http://testing.todvachev.com/sitemap-posttype-post.xml";
            string[] pageSource;

            string titleSelector = "#main-content > article > header > h1";
            string contentSelector = "#main-content > article > div";
            string path = "";

            int startIndex = 0;
            int linkLength = 0;

            driver.Navigate().GoToUrl(sitemapURL);

            pageSource = driver.PageSource.Split(' ');

            foreach (var item in pageSource)
            {
                if (item.Contains("testing"))
                {
                    startIndex = item.IndexOf("testing") - 7;
                    linkLength = item.IndexOf("\">") - startIndex;
                    extractedLinks.Add(item.Substring(startIndex, linkLength));
                    System.Console.WriteLine(item.Substring(startIndex, linkLength));
                }
            }

            foreach (var item in extractedLinks)
            {
                if (item != "http://testing.todvachev.com/special-elements/alert-box/")
                {

                driver.Navigate().GoToUrl(item);

                titleElement = driver.FindElement(By.CssSelector(titleSelector));
                contentElement = driver.FindElement(By.CssSelector(contentSelector));

                extractedTitle.Add(titleElement.Text);
                System.Console.WriteLine(titleElement.Text);
                extractedContent.Add(contentElement.Text);
                }
            }

            Directory.CreateDirectory(Directory.GetCurrentDirectory() + @"\ExtractedContent");

            for (int i = 0; i < extractedTitle.Count; i++)
            {
                path = String.Format(Directory.GetCurrentDirectory() + @"\ExtractedContent\0{0} {1}.txt", i, extractedTitle[i]);
                using (StreamWriter sw = File.CreateText(path))
                {
                    sw.WriteLine("TITLE: {0}", extractedTitle[i]);
                    sw.WriteLine("CONTENT:");
                    sw.Write(extractedContent[i]);
                }
            }
        }
    }
}