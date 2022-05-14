using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PractWork22
{
    public static class Core
    {
        private static MarketEntities context;
        public static MarketEntities Context { get => context ?? (context = new MarketEntities()); }
    }
}
