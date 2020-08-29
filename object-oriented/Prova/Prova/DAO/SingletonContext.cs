using Prova.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prova.DAO
{
    class SingletonContext
    {
        private static Context context;

        private SingletonContext() { }

        public static Context GetInstanceContext()
        {
            if (context == null)
            {
                context = new Context();
            }
            return context;
        }
    }
}
