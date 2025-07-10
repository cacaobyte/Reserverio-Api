using System;
using System.Collections.Generic;

namespace ReserverioCore.ML.Reserverio;

public partial class ReservationService
{
    public int Id { get; set; }

    public int TenantId { get; set; }

    public string? Name { get; set; }

    public string? Description { get; set; }

    public string? Duration { get; set; }

    public string? Price { get; set; }

    public bool? Active { get; set; }

    public DateOnly? CreateAt { get; set; }

    public DateOnly? UpdateAt { get; set; }

    public string? CreateBy { get; set; }

    public string? UpdateBy { get; set; }
}
