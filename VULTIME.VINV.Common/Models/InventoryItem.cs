﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using VULTIME.VINV.Common.Interfaces;

namespace VULTIME.VINV.Common.Models
{
    public class InventoryItem : IInventoryItem
    {
        [Key]
        public Guid Id { get; set; }

#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.

        [Required]
        public string Name { get; set; }

        public InventoryItemStatus Status { get; set; }

        public string Description { get; set; }

        public ICollection<InventoryItemImage> Images { get; set; }

        [Required]
        [ForeignKey("ItemLocation")]
        public Guid LocationId { get; set; }

        public InventoryItemLocation Location { get; set; }

        public int Quantity { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal OriginalPrice { get; set; }

        public DateTimeOffset BuyDate { get; set; }

        public DateTimeOffset CreatedAt { get; set; }

        public DateTimeOffset UpdatedAt { get; set; }

#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
    }

    public enum InventoryItemStatus
    {
        Stored,
        Sold,
        Lost,
        Stolen,
        Damaged,
        Destroyed,
        Other
    }
}