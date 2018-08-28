using System.Threading;
using POM.UIElements;

namespace POM
{
    public static class NavigateTo
    {
        public static void LoginFormThroughMenu()
        {
            Menu menu = new Menu();
            TestScenariosPage tsPage = new TestScenariosPage();

            menu.TestScenarios.Click();
            Thread.Sleep(500);
            tsPage.LoginForm.Click();
            Thread.Sleep(500);
        }


        // public static void LoginFormThroughThePost()
        // {
        //     Menu menu = new Menu();
        //     TestCasesPage tcPage = new TestCasesPage();
        //     UserNameFieldPost ufPost = new UserNameFieldPost();

        //     menu.TestCases.Click();
        //     Thread.Sleep(500);
        //     tcPage.UserNameField.Click();
        //     Thread.Sleep(500);
        //     ufPost.LoginFormLink.Click();
        //     Thread.Sleep(500);
        // }
    }
}