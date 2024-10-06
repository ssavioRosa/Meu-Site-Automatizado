using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Teste.MeuSite.Automacao.Core
{
    public abstract class Begin : DSL
    {


        [SetUp]
        public void Setup()
        {

            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://ssaviorosa.github.io/ListaDeCompras-react/");
            driver.Manage().Window.Maximize();

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            driverQuit = true; //true = fecha o navegador | else = não fecha



        }

        [TearDown]
        public void TearDown()
        {

            if (driverQuit) driver.Quit();
          }


    }
}