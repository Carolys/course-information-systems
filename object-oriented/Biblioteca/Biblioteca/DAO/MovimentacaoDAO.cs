using Biblioteca.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.DAO
{
    class MovimentacaoDAO
    {
        private static List<Movimentacao> Movimentacao = new List<Movimentacao>();

        public static bool CadastrarMovi(Movimentacao movi)
        {
            Movimentacao.Add(movi);
            return true;
        }

        public static List<Movimentacao> RetornarMovi()
        {
            return Movimentacao;
        }

    }
}
