using System;
using System.Collections.Generic;

namespace ReserverioCore.ML.Reserverio;

public partial class UserFavorite
{
    public int Id { get; set; }

    public int PublicUserId { get; set; }

    public int TenantId { get; set; }

    public DateOnly? AddedAt { get; set; }

    public string? Note { get; set; }

    public decimal? Qualification { get; set; }

    public bool? IsNotified { get; set; }

    public DateOnly? LastInteractionAt { get; set; }

    public string? AliasName { get; set; }

    public string? Tags { get; set; }

    public bool? IsArchived { get; set; }
}
