using System;
using System.Collections.Generic;

namespace ReserverioCore.ML.Reserverio;

public partial class TenantBranding
{
    public int Id { get; set; }

    public int TenantId { get; set; }

    public string? LogoUrl { get; set; }

    public string? PrimaryColor { get; set; }

    public string? SecondaryColor { get; set; }

    public string? Font { get; set; }

    public string? CustomCss { get; set; }

    public DateOnly? CreatedAt { get; set; }

    public DateOnly? UpdateAt { get; set; }

    public bool? Active { get; set; }

    public bool? Enable { get; set; }
}
