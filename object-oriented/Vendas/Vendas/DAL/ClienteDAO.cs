using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vendas.Model;

namespace Vendas.DAL
{
    class ClienteDAO
    {

        List<Cliente> clientes = new List<Cliente>();

        public void CadastrarCliente(Cliente c)
        {
            clientes.Add(c);
        }

    }
}
