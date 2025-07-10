using System;
using System.Collections.Generic;

namespace ReserverioCore.ML.Reserverio;

public partial class TenantNotification
{
    public int Id { get; set; }

    public int TenantId { get; set; }

    public string? NotificationType { get; set; }

    public string? Channel { get; set; }

    public string? Template { get; set; }

    public bool? Enabled { get; set; }

    public DateOnly? CreatedAt { get; set; }

    public DateOnly? UpdateAt { get; set; }

    public string? CreateBy { get; set; }

    public string? UpdateBy { get; set; }

    public string? Transmitter { get; set; }
}
