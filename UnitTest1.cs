using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SeleniumNunitExample
{
    [TestFixture]
    public class GoogleSearchTest
    {
        private IWebDriver driver;
        private GoogleHomePage googleHomePage;
        private GoogleResultsPage googleResultsPage;

        
        [SetUp]
        public void Setup()
        {
            string path = "C:\\Users\\user1\\Desktop\\לימודים שנה ב\\אוטומוציה\\SeleniumNunitExample\\SeleniumNunitExample\\chromedriver - win64";
            driver = new ChromeDriver(path);
            googleHomePage = new GoogleHomePage(driver);
           googleResultsPage = new GoogleResultsPage(driver);
        }

        [Test]
        public void Test1()
        {
            googleHomePage.NavigateTo();
            Assert.AreEqual("Google", driver.Title);
            googleHomePage.search("Selenium webDriver");
            Assert.IsTrue(googleResultsPage.ResultsDisplayed());
            string firstResultTitle =
                googleResultsPage.GetFirstResultTitle();
            googleResultsPage.ClickFirstResult();

            Assert.IsTrue(driver.Title.Contains(firstResultTitle));

            driver.Navigate().Back();
            Assert.AreEqual("Selenium webdriver", driver.FindElement(By.Name("q")).GetAttribute("value"));
        }
        [TearDown]
        public void TearDown()
        {
            driver.Dispose();
        }
    }
}