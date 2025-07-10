using System;
using System.Collections.Generic;

namespace ReserverioCore.ML.Reserverio;

public partial class UserRating
{
    public int Id { get; set; }

    public int PublicUserId { get; set; }

    public int TenantId { get; set; }

    public decimal? Rating { get; set; }

    public string? Comment { get; set; }

    public DateOnly? CreatedAt { get; set; }

    public DateOnly? UpdatedAt { get; set; }

    public bool? Visible { get; set; }

    public int? ReportedCount { get; set; }

    /// <summary>
    /// Tipo de calificación: &quot;general&quot;, &quot;servicio&quot;, &quot;instalaciones&quot;, &quot;tiempo&quot;, etc. Sirve si quieres tener múltiples criterios.
    /// </summary>
    public string? RatingType { get; set; }
}
