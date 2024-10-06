using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Teste.MeuSite.Automacao.Page;

namespace Teste.MeuSite.Automacao.Test
{
    class AuthTest : AuthPage
    {
        [Test]
        public void CaseCadastroValido()
        {
            PreencheInputCadastroValido();
            ClicaElementoCadastro();
            ValidaCase();
        }

        //Email Incorreto
        [Test]
        public void CaseLoginInvalidoEmail()
        {
            PreencheInputCadastroValido();
            ClicaElementoCadastro();
       
            PreencheEmailLoginIncorreto();
            ClicarElementoLogin();
            ValidaCaseIncorretoLogin();

        }
        [Test]
        public void CaseLoginInvalidoSenha()
        {
            PreencheInputCadastroValido();
            ClicaElementoCadastro();

            PreencheSenhaLoginIncorreto();
            ClicarElementoLogin();
            ValidaCaseIncorretoLogin();
        }

        [Test]
        public void CaseLoginValido()
        {
            PreencheInputCadastroValido();
            ClicaElementoCadastro();

            PreencheLoginCorreto();
            ClicarElementoLogin();
            ValidaCaseCorretoLogin();
        }
    }
}
