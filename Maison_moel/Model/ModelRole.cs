using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Maison_moel.Entities;

namespace Maison_moel.Model
{
    internal class ModelRole
    {   
        public static List<RoleCuisinier> ListeRole()
        {
            return Model.MonModel.RoleCuisiniers.ToList();
        }
    }
}
