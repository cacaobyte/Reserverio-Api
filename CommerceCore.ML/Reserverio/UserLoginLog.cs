using System;
using System.Collections.Generic;

namespace ReserverioCore.ML.Reserverio;

public partial class UserLoginLog
{
    public int Id { get; set; }

    public int UserId { get; set; }

    public int PublicUserId { get; set; }

    public string? LoginMethod { get; set; }

    public bool? Success { get; set; }

    public string? IpAddress { get; set; }

    /// <summary>
    /// Información del navegador o dispositivo
    /// </summary>
    public string? UserAgent { get; set; }

    public DateOnly? LoggedAt { get; set; }

    public string? Location { get; set; }

    public int TenantId { get; set; }
}
