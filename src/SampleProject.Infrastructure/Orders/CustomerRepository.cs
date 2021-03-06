﻿using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SampleProject.Domain.Customers;
using SampleProject.Domain.Customers.Orders;
using SampleProject.Domain.SeedWork;

namespace SampleProject.Infrastructure.Orders
{
    public class CustomerRepository : ICustomerRepository
    {
        private readonly OrdersContext _context;
        public CustomerRepository(OrdersContext context)
        {
            this._context = context ?? throw new ArgumentNullException(nameof(context));
        }

        public IUnitOfWork UnitOfWork => _context;

        public async Task<Customer> GetByIdAsync(Guid id)
        {
            return await this._context.Customers
                .SingleAsync(x => x.Id == id);
        }
    }
}