using HrPortalV2.Data;
using HrPortalV2.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace HrPortalV2.Service
{
    public class SubscriptionService:ISubscriptionService
    {
        private readonly IRepository<Subscription> subscriptionRepository;
        public SubscriptionService(IRepository<Subscription> subscriptionRepository)
        {
            this.subscriptionRepository = subscriptionRepository;
        }
        public void Delete(string id)
        {
            var entity = subscriptionRepository.Get(id);
            subscriptionRepository.Delete(entity);
        }

        public Subscription Get(string id)
        {
            return subscriptionRepository.Get(id);
        }

        public IEnumerable<Subscription> GetAll()
        {
            return subscriptionRepository.GetAll();
        }

        public void Insert(Subscription entity)
        {
            subscriptionRepository.Insert(entity);
        }

        public void Update(Subscription entity)
        {
            subscriptionRepository.Update(entity);
        }
    }
    public interface ISubscriptionService
    {
        IEnumerable<Subscription> GetAll();
        Subscription Get(string id);
        void Insert(Subscription entity);
        void Update(Subscription entity);
        void Delete(string id);
    }
}
