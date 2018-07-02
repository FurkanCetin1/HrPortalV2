using HrPortalV2.Data;
using HrPortalV2.Models;
using System;
using System.Collections.Generic;

namespace HrPortalV2.Service
{
    public class MessageService : IMessageService
    {
        private readonly IRepository<Message> messageRepository;
        public MessageService(IRepository<Message> messageRepository)
        {
            this.messageRepository = messageRepository;
        }
        public void Delete(string id)
        {
            var entity = messageRepository.Get(id);
            messageRepository.Delete(entity);
        }

        public Message Get(string id)
        {
            return messageRepository.Get(id);
        }

        public IEnumerable<Message> GetAll()
        {
            return messageRepository.GetAll();
        }

        public void Insert(Message entity)
        {
            messageRepository.Insert(entity);
        }

        public void Update(Message entity)
        {
            messageRepository.Update(entity);
        }
    }

    public interface IMessageService
    {
        IEnumerable<Message> GetAll();
        Message Get(string id);
        void Insert(Message entity);
        void Update(Message entity);
        void Delete(string id);
    }

}
