using OpenQA.Selenium;


namespace Teste.MeuSite.Automacao.Core
{
    public class DSL : GlobalVariables
    {
        public void clicarElemento(string xpath)
        {
            driver.FindElement(By.XPath(xpath)).Click();
        }
        public void inserirTextoElemento(string xpath, string valor)
        {

            driver.FindElement(By.XPath(xpath)).SendKeys(valor);

        }
        public void validarElemento(string xpath, string contains) 
        {

            Assert.That(driver.FindElement(By.XPath(xpath)).Text, Does.Contain(contains));

        }

    }
}
