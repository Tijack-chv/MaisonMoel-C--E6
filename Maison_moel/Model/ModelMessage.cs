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
            return Model.MonModel.Messages.OrderBy(x => x.Date).ToList();
        }

        public static int getUnreadMessagesCount()
        {
            return Model.MonModel.Messages.Where(m => m.EstVue == false).Count();
        }

        public static List<Entities.Message> getUnreadMessages()
        {
            return Model.MonModel.Messages.OrderBy(x => x.Date).Where(m => m.EstVue == false).ToList();
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

        public static int getMessageCount()
        {
            return Model.MonModel.Messages.Count();
        }

        public static void addMessage(Entities.Message message)
        {
            try
            {
                Model.MonModel.Messages.Add(message);
                Model.MonModel.SaveChanges();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
    }
}
