using OpenQA.Selenium;

namespace Teste.MeuSite.Automacao.Core
{
    public class GlobalVariables
    {
        public IWebDriver? driver; //Define driver como variavel para os WebElements 
        public bool driverQuit = true; //Definie deixar aberto ou fechar o navegador apos rodar o teste
        public bool headlessTest = false; //Habilita"True" ou desabilita"False" modo headless
    }
}
