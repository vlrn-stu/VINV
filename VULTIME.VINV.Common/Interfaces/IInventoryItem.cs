﻿using VULTIME.VINV.Common.Models;

namespace VULTIME.VINV.Common.Interfaces
{
    public interface IInventoryItem : ITimestampedEntity
    {
        Guid Id { get; set; }
        string Name { get; set; }
        InventoryItemStatus Status { get; set; }
        string Description { get; set; }
        ICollection<InventoryItemImage> Images { get; set; }
        Guid LocationId { get; set; }
        InventoryItemLocation Location { get; set; }
        int Quantity { get; set; }
        decimal OriginalPrice { get; set; }
        DateTimeOffset BuyDate { get; set; }
    }
}