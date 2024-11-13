using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace TocaMusica
{
    public class AutomationWeb
    {
        public IWebDriver driver;

        public AutomationWeb()
        {
            driver = new ChromeDriver();
        }

        public async void TestWeb()
        {
            driver.Navigate().GoToUrl("https://www.youtube.com/");

            driver.FindElement(By.Name("search_query")).SendKeys("The Black Eyed Peas - Pump It (Official Music Video)");
            driver.FindElement(By.XPath("//*[@id=\"search-icon-legacy\"]/yt-icon/span/div")).Click();
            Thread.Sleep(3000);
            driver.FindElement(By.XPath("/html/body/ytd-app/div[1]/ytd-page-manager/ytd-search/div[1]/ytd-two-column-search-results-renderer/div/ytd-section-list-renderer/div[2]/ytd-item-section-renderer/div[3]/ytd-video-renderer[5]/div[1]/div/div[1]/div/h3/a")).Click();
        }
    }
}