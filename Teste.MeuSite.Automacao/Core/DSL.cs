using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;


namespace Teste.MeuSite.Automacao.Core
{
    public class DSL : GlobalVariables
    {
        public void ClicarElemento(string xpath)
        {
            driver.FindElement(By.XPath(xpath)).Click();
        }
        public void inserirTextoElemento(string xpath, string valor)
        {

            driver.FindElement(By.XPath(xpath)).Clear();
            driver.FindElement(By.XPath(xpath)).SendKeys(valor);

        }
        public void ValidarElemento(string xpath, string contains) 
        {

            Assert.That(driver.FindElement(By.XPath(xpath)).Text, Does.Contain(contains));

        }
        public void RecebeSelect(string xpath, string value)
        {
            IWebElement dropdown = driver.FindElement(By.XPath(xpath));

            SelectElement selectElement = new SelectElement(dropdown);

            selectElement.SelectByValue(value);
        }

       
            
    }
}
