using Maison_moel.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maison_moel.Model
{
    public class ModelEtat
    {
        public static List<Etat> ListeEtat()
        {
            return Model.MonModel.Etats.ToList();
        }
    }
}
