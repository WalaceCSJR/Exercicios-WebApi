using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Segundodto.Services
{
    public class PessoaService
    {
        public bool VerificacaoMaioridade(int idade)
        {
            if (idade >= 18)
            {
                return true;
            }
            else
            {
                return false;
            }
            
        }
    }
}