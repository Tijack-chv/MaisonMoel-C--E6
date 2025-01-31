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

        public static int getUnreadMessagesCount()
        {
            return Model.MonModel.Messages.Where(m => m.EstVue == false).Count();
        }

        public static List<Entities.Message> getUnreadMessages(DateTime date)
        {
            return Model.MonModel.Messages.Where(m => m.EstVue == false && m.Date >= date).ToList();
        }

        public static void updateMessageUnReadToRead()
        {
            try
            {
                List<Entities.Message> unreadMessages = Model.MonModel.Messages.Where(m => m.EstVue == false).ToList();
                foreach (Entities.Message mess in unreadMessages)
                {
                    mess.EstVue = true;
                }
                Model.MonModel.SaveChanges();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
    }
}
