using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VendasOsorioA.Model;

namespace VendasOsorioA.DAL
{
    class ClienteDAO
    {
        private static List<Cliente> clientes = new List<Cliente>();

        public static bool CadastrarCliente(Cliente c)
        {
            if (BuscarClientePorCpf(c) != null)
            {
                return false;
            }
            clientes.Add(c);
            return true;
        }

        public static Cliente BuscarClientePorCpf(Cliente cliente)
        {
            foreach (Cliente clienteCadastrado in clientes)
            {
                if (clienteCadastrado.Cpf.Equals(cliente.Cpf))
                {
                    return clienteCadastrado;
                }
            }
            return null;
        }

        public static List<Cliente> RetornarClientes()
        {
            return clientes;
        }
    }
}
