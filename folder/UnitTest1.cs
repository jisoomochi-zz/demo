using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;
using SeleniumCSharpProject.BaseClass;

namespace SeleniumCSharpProject
{
    public class Tests:BaseTest
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
           //IWebDriver driver= new ChromeDriver();
           // driver.Url = "https://www.facebook.com";
         IWebElement emailTextField =  driver.FindElement(By.XPath(".//*[@id='email']"));
            emailTextField.SendKeys("armyblinkjisoomochi@gmail.com");
            Thread.Sleep(6000);
            //driver.Quit();

            
        }
        [Test,Category("Smoke Test")]
        public void Test2()
        {
            //IWebDriver driver= new ChromeDriver();
            // driver.Url = "https://www.facebook.com";
            IWebElement emailTextField = driver.FindElement(By.XPath(".//*[@id='email']"));
            emailTextField.SendKeys("armyblinkjisoomochi@gmail.com");
            Thread.Sleep(6000);
            //driver.Quit();


        }
        [Test,Category("Regression Test")]
        public void Test3()
        {
            //IWebDriver driver= new ChromeDriver();
            // driver.Url = "https://www.facebook.com";
            IWebElement emailTextField = driver.FindElement(By.XPath(".//*[@id='email']"));
            emailTextField.SendKeys("armyblinkjisoomochi@gmail.com");
            Thread.Sleep(6000);
            //driver.Quit();


        }
    }
}