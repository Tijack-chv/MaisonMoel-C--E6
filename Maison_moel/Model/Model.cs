using Maison_moel.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maison_moel.Model
{
    public static class Model
    {
        private static BddMaisonMoelContext monModel;

        public static BddMaisonMoelContext MonModel { get => monModel; set => monModel = value; }

        public static void init()
        {
            monModel = new BddMaisonMoelContext();
        }
    }
}