using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto3Camadas.CODE.DTO
{
    class PacotesDTO
    {
        private int _id;
        private string _nome;
        private string _descrição;
        private string _valor;

        public int Id { get => _id; set => _id = value; }
        public string Descrição { get => _descrição; set => _descrição = value; }
        public string Valor { get => _valor; set => _valor = value; }
        public string Nome { get => _nome; set => _nome = value; }
    }
}
