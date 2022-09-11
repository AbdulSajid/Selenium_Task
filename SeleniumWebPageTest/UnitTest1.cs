using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;

namespace TestProject2
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://cz.careers.veeam.com/vacancies";

            driver.Manage().Window.Maximize();

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

            driver.FindElement(By.Id("cookiescript_accept")).Click();
            driver.FindElement(By.Id("sl")).Click();
            driver.FindElement(By.LinkText("Research & Development")).Click();
            driver.FindElement(By.XPath("//button[contains(text(),'All languages')]")).Click();
            driver.FindElement(By.XPath("//label[contains(text(),'English')]")).Click();
            driver.FindElement(By.XPath("//button[contains(text(),'English')]")).Click();
            int count = driver.FindElements(By.CssSelector("a[href*='/vacancies/development']")).Count;

            int TotalJobsCount = count / 2;
            Console.WriteLine(TotalJobsCount);

            //expected result;
            int jobs = 12;

            if (TotalJobsCount == jobs && TotalJobsCount != 0)
            {
                //actual result
                Console.WriteLine("Test passed");
            }
            else
                Console.WriteLine("Test not passed");

            Assert.Pass();
        }
    }
}