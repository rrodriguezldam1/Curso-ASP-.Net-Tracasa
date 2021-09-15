using NUnit.Framework;
using System.IO;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;

namespace _08_NUnit_Selenium
{
    public class TestsSeleniumFirefox
    {
        IWebDriver driver;

        [OneTimeSetUp]
        public void InicializarClaseTest()
        {
            //string firefoxPortable = "C:\\Users\\pmpcurso1\\AppData\\Local\\Mozilla Firefox\\firefox.exe";
            string firefoxPortable = "../../../../FirefoxPortable/App/Firefox64/firefox.exe";
            if (!File.Exists(firefoxPortable)) {
                string instalador = "../../../../FirefoxPortable_92.0_English.paf.exe";
                if (File.Exists(instalador))
                {
                    System.Diagnostics.Process.Start(instalador);
                }
            }
            if (File.Exists(firefoxPortable))
            {
                //string rutaDriverGecko = "geckodriver.exe";
                //FirefoxBinary binarioFirefox = new FirefoxBinary(firefoxPortable);
                FirefoxOptions firefoxOptions = new FirefoxOptions();
                firefoxOptions.BrowserExecutableLocation = firefoxPortable;
                driver = new FirefoxDriver(firefoxOptions);
            }
        }
        [OneTimeTearDown]
        public void FinalizarClaseTest() {
            //driver.Close();
        }

        [SetUp]
        public void Setup()
        {
            
        }

        [Test]
        public void Test1()
        {
            driver.Navigate().GoToUrl("https://duckduckgo.com/");
            IWebElement textoBusq = driver.FindElement(By.Name("q"));
            textoBusq.SendKeys("SQL Tutorials w3school");
            IWebElement botonBusq = driver.FindElement(By.Id("search_button_homepage"));
            botonBusq.Click();
            var enlaces = driver.FindElements(By.CssSelector("a[href*='https://www.w3schools.com']"));
            foreach (var enlace in enlaces)
            {
                if (enlace.Equals(enlaces[1])) {
                    enlace.Click();
                    break;
                }
            }
        }
    }
}