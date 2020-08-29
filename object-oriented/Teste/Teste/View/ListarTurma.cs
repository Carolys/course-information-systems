using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Teste.DAO;
using Teste.Model;

namespace Teste.View
{
    class ListarTurma
    {
        public static void Executar()
        {
            Console.Clear();
            Turma t = new Turma();
            Console.WriteLine(" -- LISTAR TURMA -- \n");
            Console.WriteLine("Digite o nome da turma: ");
            t.Nome = Console.ReadLine();
            t = TurmaDAO.BuscarTurma(t);

            Console.ReadKey();
        }
    }
}
