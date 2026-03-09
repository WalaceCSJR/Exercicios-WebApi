using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Terceirodto.Dtos;

namespace Terceirodto.Services
{
    public class PessoaService
    {
        public string VerificarDados(PessoaDto dto)
        {
            if (string.IsNullOrWhiteSpace(dto.Nome)) return "Nome vazio";
            if (string.IsNullOrWhiteSpace(dto.Sobrenome)) return "Sobrenome vazio";

            var hoje = DateTime.Today;
            var idade = hoje.Year - dto.DataNascimento.Year;

            if (dto.DataNascimento.Date > hoje.AddYears(-idade)) idade--;

            if (idade < 18) 
            {
                return "Não é possível dar seguimento. " + dto.Nome + " é de menor.";
            }
            if (dto.DataNascimento.Day == hoje.Day && dto.DataNascimento.Month == hoje.Month)
            {
                return "Feliz aniversário!";
            }

            return "";
        }
    }
}