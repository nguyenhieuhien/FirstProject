﻿using BusinessObjects.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.Repository
{
    public interface IOrderRepository
    {
        List<Order> GetAllOrders();
        void InsertOrder(Order order);
        void UpdateOrder(Order order);
        void DeleteOrder(Order order);
        int GetMaxOrderID();
    }
}
