using Maison_moel.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maison_moel.Model
{
    public class ModelTable
    {
        public static List<Table> ListeTable()
        {
            return Model.MonModel.Tables.ToList();
        }
    }
}
