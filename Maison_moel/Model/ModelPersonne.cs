using Maison_moel.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maison_moel.Model
{
    public class ModelPersonne
    {
        public static List<Personne> ListeServeur()
        {
            return Model.MonModel.Personnes
            .Where(p => p.Serveur != null)
            .ToList();
        }
    }
}