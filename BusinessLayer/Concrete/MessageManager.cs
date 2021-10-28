using BusinessLayer.Abstract;
using DateAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class MessageManager: IMessageService
    {
        IMessageDal _messageDal;

        public MessageManager(IMessageDal messagedal)
        {
            _messageDal = messagedal;
        }

        public Message GetByID(int id)
        {
            return _messageDal.Get(x => x.MessageID == id);

        }

        public List<Message> GetListInbox(string userEmail)
        {
            return _messageDal.List(x => x.ReceiverMail == "admin@gmail.com");


        }

        public List<Message> GetListSendbox(string userEmail)
        {
            return _messageDal.List(x => x.SenderMail == "admin@gmail.com");

        }

        public void MessageAdd(Message message)
        {
            _messageDal.Insert(message);
        }

        public void MessageDelete(Message message)
        {
            _messageDal.Delete(message);
        }

        public void MessageUpdate(Message message)
        {
            _messageDal.Update(message);
        }
    }
}
