using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Teste.MeuSite.Automacao.Page;

namespace Teste.MeuSite.Automacao.Test
{
    class PrincipalTest : PrincipalPage
    {
        [SetUp]
        public void Entra()
        {


            PreencheInputCadastroValido();
            ClicaElementoCadastro();

            PreencheLoginCorreto();
            ClicarElementoLogin();
            ValidaCaseCorretoLogin();


        }

        [Test]
        public void InsereElementoCorreto()
        {
           
            PreencheItemValido();

        }
        [Test]
        public void CopyPast()
        {
            CopiaEColla();

        }

    }
}
