using Maison_moel.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Maison_moel.Model
{
    public class ModelMessage
    {
        public static List<Entities.Message> getMessages()
        {
            return Model.MonModel.Messages.ToList();
        }

        public static int getUnreadMessages()
        {
            return Model.MonModel.Messages.Where(m => m.EstVue == false).Count();
        }
    }
}
