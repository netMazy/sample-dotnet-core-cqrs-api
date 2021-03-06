﻿using System.Collections.Generic;
using System.Threading.Tasks;
using SampleProject.Domain.SeedWork;
using SampleProject.Infrastructure.Orders;

namespace SampleProject.Infrastructure
{
    public interface IDomainEventsDispatcher
    {
        Task<List<IDomainEventNotification<IDomainEvent>>> DispatchEventsAsync(OrdersContext context);
    }
}