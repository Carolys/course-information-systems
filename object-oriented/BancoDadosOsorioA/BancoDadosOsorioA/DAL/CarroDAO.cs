using BancoDadosOsorioA.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoDadosOsorioA.DAL
{
    class CarroDAO
    {
        private static Context ctx = new Context();

        public static void CadastrarCarro(Carro c)
        {
            ctx.Carros.Add(c);
            ctx.SaveChanges();
        }

        public static List<Carro> ListarCarros()
        {
            return ctx.Carros.ToList();
        }

        public static Carro BuscarCarroPorModelo(Carro c)
        {
            //FIRSTORDEFAULT utilizado para buscar um objeto por algum atributo
            return ctx.Carros.FirstOrDefault(x => x.Modelo.Equals(c.Modelo));
        }
        public static Carro BuscarCarroPorModeloSingle(Carro c)
        {
            //SINGLEORDEFAULT buscar um elemento único, quando existe mais de um
            //elemento, o EF mostra uma exceção
            try
            {
                return ctx.Carros.SingleOrDefault(x => x.Modelo.Equals(c.Modelo));
            }
            catch (InvalidOperationException)
            {
                Console.WriteLine("Existe mais de uma ocorrência na busca!");
                throw;
            }
        }

        public static List<Carro> BuscarCarrosPorParteModelo(Carro c)
        {
            //WHERE utilizado para retornar uma lista de objetos
            return ctx.Carros.Where(x => x.Modelo.Contains(c.Modelo)).ToList();
        }

        public static void RemoverCarro (Carro c)
        {
            ctx.Carros.Remove(c);
            ctx.SaveChanges();
        }

        public static Carro BuscarPorChavePrimaria(Carro c)
        {
            //FIND utilizado para buscar um objeto pela chave primária
            return ctx.Carros.Find(c.IdPessoa);
        }

        public static void AlterarCarro(Carro c)
        {
            ctx.Entry(c).State = System.Data.Entity.EntityState.Modified;
            ctx.SaveChanges();
        }

    }
}
