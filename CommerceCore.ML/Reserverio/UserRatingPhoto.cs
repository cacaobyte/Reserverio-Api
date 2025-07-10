using System;
using System.Collections.Generic;

namespace ReserverioCore.ML.Reserverio;

public partial class UserRatingPhoto
{
    public int Id { get; set; }

    public int UserRatingId { get; set; }

    public string? ImageUrl { get; set; }

    public string? AltText { get; set; }

    public string? CreatedAt { get; set; }

    public string? UploadedBy { get; set; }

    public bool? Visible { get; set; }
}
