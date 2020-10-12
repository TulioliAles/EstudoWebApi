using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Estudo.WebApi.Models
{
    public class Clientes
    {

        public string Nome { get; set; }

        public Clientes(string nome)
        {
            this.Nome = nome;
        }

    }
}
