using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Espeiceneitor
{
    public class Astronauta
    {
        private static int _Index = 1;

        public int Id { get; private set; }
        public string Nome { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Origem { get; set; }

        public Astronauta(string nome, DateTime dataNascimento, string origem)
        {
            Id = _Index;
            Nome = nome;
            DataNascimento = dataNascimento;
            Origem = origem;

            _Index++;
        }
    }
}