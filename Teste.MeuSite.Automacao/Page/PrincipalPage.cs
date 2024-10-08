using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Teste.MeuSite.Automacao.Core;

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
