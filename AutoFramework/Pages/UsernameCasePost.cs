namespace AutoFramework.Pages
{
    using OpenQA.Selenium;
    using SeleniumExtras.PageObjects;


    public class UsernameCasePost
    {
        public UsernameCasePost(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.CssSelector, Using = "#post-74 > div > p > a")]
        public IWebElement LoginFormLink { get; set; }

    }
}