using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Teste.MeuSite.Automacao.Core;

namespace Teste.MeuSite.Automacao.Page
{
     class AuthPage : Begin
    {
        //Case Validos Cadastro
        public void PreencheInputCadastroValido()
        {
            inserirTextoElemento("//*[@id='root']/div/div/form/input[1]", "Sávio Rosa");
            inserirTextoElemento("//*[@id='root']/div/div/form/input[2]", "saviosodre6@gmail.com");
            inserirTextoElemento("//*[@id=\'root\']/div/div/form/input[3]", "123");

        }
        public void ClicaElementoCadastro()
        {
            clicarElemento("//*[@id=\"root\"]/div/div/form/button[1]");
        }

        public void ValidaCase()
        {
            validarElemento("//*[@id=\'root\']/div/div/div/div/h1", "Login");
        }

        //Caso invalidoLogin 
        public void PreencheEmailLoginIncorreto()
        {
            inserirTextoElemento("//*[@id=\"root\"]/div/div/div/form/input[1]", "saviosodre@gmail.com");
            inserirTextoElemento("//*[@id=\"root\"]/div/div/div/form/input[2]", "123");
        }

        public void PreencheSenhaLoginIncorreto()
        {
            inserirTextoElemento("//*[@id=\"root\"]/div/div/div/form/input[1]", "saviosodre6@gmail.com");
            inserirTextoElemento("//*[@id=\"root\"]/div/div/div/form/input[2]", "1233");
        }
        public void ClicarElementoLogin()
        {
            clicarElemento("//*[@id=\"root\"]/div/div/div/form/button[1]");
        }
        public void ValidaCaseIncorretoLogin()
        {
            validarElemento("//*[@id=\"root\"]/div/div/div/form/p", "Login incorreto !");
        }
        //Caso LoginValido
        public void PreencheLoginCorreto()
        {
            inserirTextoElemento("//*[@id=\"root\"]/div/div/div/form/input[1]", "saviosodre6@gmail.com");
            inserirTextoElemento("//*[@id=\"root\"]/div/div/div/form/input[2]", "123");
        }
        public void ValidaCaseCorretoLogin()
        {
            validarElemento("//*[@id=\"root\"]/div[1]/h1", "Lista de Compras");
        }




    }
}
