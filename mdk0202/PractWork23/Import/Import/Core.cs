using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Import
{
    public static class Core
    {
        private static ImportEntities context;

        public static ImportEntities Context { get => context ?? (context = new ImportEntities()); }
    }
}
