using System;
using System.Collections.Generic;

namespace ReserverioCore.ML.Reserverio;

public partial class ServiceImage
{
    public int Id { get; set; }

    public int TenantId { get; set; }

    public int ServiceId { get; set; }

    public string ImageUrl { get; set; } = null!;

    public string? AltText { get; set; }

    public bool? IsMain { get; set; }

    public int? OrderIndex { get; set; }

    public DateOnly? CreatedAt { get; set; }

    public DateOnly? UploadedBy { get; set; }

    public string? CreateBy { get; set; }

    public string? UpdateBy { get; set; }
}
