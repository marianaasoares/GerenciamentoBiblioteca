using System;
using System.Collections.Generic;
using System.Text;

namespace Dominio
{
    public class Livro
    {
        public Livro(string nome, DateTime dataLancamento)
        {
            Nome = nome;
            DataLancamento = dataLancamento;
        }

        public string Nome { get; private set; }

        public DateTime DataLancamento { get; set; }

        public int CalcularQuantosAnosFoiLancado()
        {
            return DateTime.Now.Year - DataLancamento.Year;
        }
    }
}
