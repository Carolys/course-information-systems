using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Teste.Model;

namespace Teste.DAO
{
    class SingletonContext
    {
        private static Context context;

        private SingletonContext() { }

        public static Context GetInstance()
        {
            if (context == null)
            {
                context = new Context();
            }
            return context;
        }
    }
}
