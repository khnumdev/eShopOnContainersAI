﻿namespace eShopDashboard.EntityModels.Ordering
{
    public class OrderItem
    {
        public int Id { get; set; }

        public Order Order { get; set; }

        public int OrderId { get; set; }

        public int ProductId { get; set; }

        public int Units { get; set; }
    }
}