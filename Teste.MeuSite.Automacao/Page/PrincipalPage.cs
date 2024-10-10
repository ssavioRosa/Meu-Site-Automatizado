using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Teste.MeuSite.Automacao.Core;

using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;


namespace Teste.MeuSite.Automacao.Page
{
    class PrincipalPage : Begin
    {
        //Autenticação
        public void PreencheInputCadastroValido()
        {
            inserirTextoElemento("//*[@id='root']/div/div/form/input[1]", "Sávio Rosa");
            inserirTextoElemento("//*[@id='root']/div/div/form/input[2]", "saviosodre6@gmail.com");
            inserirTextoElemento("//*[@id=\'root\']/div/div/form/input[3]", "123");

        }
        public void ClicarElementoLogin()
        {
            ClicarElemento("//*[@id=\"root\"]/div/div/div/form/button[1]");
        }
        public void PreencheLoginCorreto()
        {
            inserirTextoElemento("//*[@id=\"root\"]/div/div/div/form/input[1]", "saviosodre6@gmail.com");
            inserirTextoElemento("//*[@id=\"root\"]/div/div/div/form/input[2]", "123");
        }
        public void ClicaElementoCadastro()
        {
            ClicarElemento("//*[@id=\"root\"]/div/div/form/button[1]");
        }
        public void ValidaCaseCorretoLogin()
        {
            ValidarElemento("//*[@id=\"root\"]/div[1]/h1", "Lista de Compras");
        }
        public void ValidaCase()
        {
            ValidarElemento("//*[@id=\'root\']/div/div/div/div/h1", "Login");
        }
        public void CopiaEColla()
        {
            string texto = "Copia direito porra!";


            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("var tempInput = document.createElement('input');"
                           + "tempInput.setAttribute('id', 'tempInput');"
                           + "tempInput.setAttribute('style', 'position: fixed; top: 10px; left: 10px;');" // Posiciona o input visível
                           + "document.body.appendChild(tempInput);"
                           + "tempInput.value = '" + texto + "';");

            IWebElement tempInputField = driver.FindElement(By.Id("tempInput"));

            tempInputField.Click();
            tempInputField.SendKeys(Keys.Control + "a"); // Ctrl+A para selecionar tudo
            tempInputField.SendKeys(Keys.Control + "c"); // Ctrl+C para copiar

            // Localiza o campo de entrada onde o texto será colado
            IWebElement inputField = driver.FindElement(By.XPath("//*[@id=\"root\"]/div/div/div/form/input[1]"));

            // Clica no campo de entrada para focar
            inputField.Click();
            inputField.SendKeys(Keys.Control + "v");
  ;

            //(Opcional) Remover o input temporário se não quiser manter na página
            js.ExecuteScript("document.getElementById('tempInput').remove();");
        }

        //Cases
        public void PreencheItemValido()
        {
            string[] Produtos = { "Arroz", "FeijÇão", "Carne","Macarrão","Peixe" };
            string[] Quantidade = { "112", "54", "42","523","999999" };
            string[] value = { "cm", "m", "unidade", "kg", "grama" };


            for (int i = 0; i < 5; i++)
            {
                inserirTextoElemento("//*[@id=\"root\"]/div[2]/div[1]/div/form/input[1]", Produtos[i]);
                inserirTextoElemento("//*[@id=\"root\"]/div[2]/div[1]/div/form/input[2]", Quantidade[i]);
                RecebeSelect("//*[@id=\"root\"]/div[2]/div[1]/div/form/select", value[i]);

                ClicarElemento("//*[@id=\"root\"]/div[2]/div[1]/div/form/button");

            }
        }

    }
}
