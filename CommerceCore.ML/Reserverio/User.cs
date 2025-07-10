using System;
using System.Collections.Generic;

namespace ReserverioCore.ML.Reserverio;

public partial class User
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string? Email { get; set; }

    public string? Password { get; set; }

    public DateOnly? CreateDate { get; set; }

    public string? CreateBy { get; set; }

    public DateOnly? UpdateDate { get; set; }

    public string? UpdateBy { get; set; }

    public bool Active { get; set; }

    public int? IdRol { get; set; }

    public string? PhotoUrl { get; set; }

    public string? PhoneNumber { get; set; }

    public int TenantId { get; set; }

    public bool? IsVerified { get; set; }

    public bool? FirstSession { get; set; }

    public DateOnly? FirstSessionDate { get; set; }

    public string? Country { get; set; }

    public string? Note { get; set; }

    public string? Observation { get; set; }

    public string UserName { get; set; } = null!;
}
