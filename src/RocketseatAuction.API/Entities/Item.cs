﻿using System.ComponentModel.DataAnnotations.Schema;

namespace RocketseatAuction.API.Entities;

[Table("Items")]
public class Item
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Brand { get; set; } = string.Empty;
    public string Condition { get; set; } = string.Empty;
    public decimal BasePrice { get; set; }
    public int AuctionId { get; set; }
}
