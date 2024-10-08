using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Teste.MeuSite.Automacao.Core
{
    public abstract class Begin : DSL
    {
        #region Configuração do navegador
        private void ConfigNavegador()
        {
            var headlessMode = new ChromeOptions();
            headlessMode.AddArgument("window-size=1366x768");
            headlessMode.AddArgument("disk-cache-size=0");
            headlessMode.AddArgument("headless");

            var devmode = new ChromeOptions();
            devmode.AddArgument("disk-cache-size=0");
            devmode.AddArgument("start-maximazed");

            if (headlessTest) { driver = new ChromeDriver(headlessMode); }
            else { driver = new ChromeDriver(devmode); driverQuit = false; }
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
        }
        #endregion

        [SetUp]
        public void Setup()
        {
            ConfigNavegador();
            driver.Navigate().GoToUrl("https://ssaviorosa.github.io/ListaDeCompras-react/");
        }

        [TearDown]
        public void TearDown()
        {

            if (driverQuit) driver.Quit();
          }


    }
}