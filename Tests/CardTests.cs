using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Tests;

public class CardTests
{

IWebDriver driver;

    [SetUp]
    public void BeforeEach()
    {
        driver= new ChromeDriver();
        driver.Navigate().GoToUrl("https://statsroyale.com/");
        driver.Manage().Window.Maximize();    
    }

    [Test]
    public void KnightIsOnCardsPage()
    {
        driver.FindElement(By.CssSelector(@"a[href='/cards']")).Click();
        var card=driver.FindElement(By.CssSelector("a[href='https://statsroyale.com/card/Knight']"));
        Assert.IsTrue(card.Displayed);
    }
    [TearDown]
    public void AfterEach(){
        driver.Close();
    }
}