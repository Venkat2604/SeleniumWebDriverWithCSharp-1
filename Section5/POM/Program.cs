using System;
using System.Threading;
using NUnit.Framework;
using OpenQA.Selenium;

namespace POM
{
    class Program
    {
        IAlert alert;
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello World!");
            Menu menu = new Menu();

            Driver.driver.Navigate().GoToUrl("http://testing.todorvachev.com");

            // Config.Credentials.Invalid.Username.FourCharacters;

            NavigateTo.LoginFormThroughMenu();

            Thread.Sleep(500);

            Driver.driver.Navigate().GoToUrl("http://testing.todorvachev.com");

            NavigateTo.LoginFormThroughThePost();

            Thread.Sleep(500);

            Driver.driver.Quit();
         }

        [SetUp]
        public void Initialize()
        {
            Actions.InitializeDriver();
        }

        [Test]
        public void ValidLogin()
        {
            NavigateTo.LoginFormThroughMenu();
            Actions.FillLoginForm(Config.Credentials.Valid.Username, Config.Credentials.Valid.Password, Config.Credentials.Valid.RepeatPassword);

            alert = Driver.driver.SwitchTo().Alert();

            Assert.AreEqual(Config.AlertMessages.SuccessfulLogin, alert.Text);

            alert.Accept();
        }


        [TearDown]
        public void Cleanup()
        {
            Driver.driver.Quit();
        }

    }
}
