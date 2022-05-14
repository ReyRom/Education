using PractWork15.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PractWork15
{
    public static class Core
    {
        private static MarketEntities context;
        public static MarketEntities Context { get => context ?? (context = new MarketEntities()); }
    }
}
