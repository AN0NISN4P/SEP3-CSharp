﻿using System.Collections.Generic;
using System.Threading.Tasks;
using Entities.Models;
using T1Contracts.ServerCommunicationInterfaces;

namespace Blazor.Data.Implementation
{
    public class OrderHandler : IOrderHandler
    {
        private IOrderDataServerComm _orderDataServerComm;

        public OrderHandler(IOrderDataServerComm orderDataServerComm)
        {
            _orderDataServerComm = orderDataServerComm;
        }

        public async Task<Order> RegisterAsync(Order order)
        {
            return await _orderDataServerComm.RegisterAsync(order);
        }

        public Task<bool> RemoveAsync(int order)
        {
            throw new System.NotImplementedException();
        }

        public Task<Order> UpdateAsync(Order order)
        {
            throw new System.NotImplementedException();
        }

        public async Task<IList<Order>> GetAllAsync()
        {
            return await _orderDataServerComm.GetAllAsync();
        }

        public Task<Order> GetAsync(int order)
        {
            throw new System.NotImplementedException();
        }

        public async Task<bool> ProcessOrder(Order order, List<Inventory> pickInventories)
        {
            return await _orderDataServerComm.ProcessOrder(order, pickInventories);
            
        }
    }
}