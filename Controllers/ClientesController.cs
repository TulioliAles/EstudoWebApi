using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Estudo.WebApi.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Estudo.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientesController : ControllerBase
    {
        private static List<Clientes> clientes = new List<Clientes>();

        public List<Clientes> Get()
        {
            return clientes;
        }

        public void Post(string nome)
        {
            if (!string.IsNullOrEmpty(nome))
                clientes.Add(new Clientes(nome));
        }

    }
}
