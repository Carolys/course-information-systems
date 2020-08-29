using Biblioteca.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.DAO
{
    class LivroDAO
    {
        private static List<Livro> livros = new List<Livro>();

        
        public static bool CadastrarLivro(Livro livro)
        {
            if (BuscarLivro(livro) != null)
            {
                return false;
            }
            livros.Add(livro);
            return true;
        }

        public static bool CadastrarLivroEmprestado(Livro livro)
        {
            if (livro.Situacao.Equals("disponivel"))
            {
                livros.Add(livro);
                return true;
            }
            return false;
        }



        public static Livro BuscarLivro(Livro livro)
        {
            foreach (Livro i in livros)
            {
                if (i.Nome.Equals(livro.Nome))
                {
                    return i;
                }
            }
            return null;
        }

        public static List<Livro> RetornarLivros()
        {
            return livros;
        }

        public static bool VerificarLivro(Livro livro)
        {
            foreach (Livro i in livros)
            {
                if (i.Nome.Equals(livro.Nome))
                {
                    return true;
                }
            }
            return false;
        }
    }
}
