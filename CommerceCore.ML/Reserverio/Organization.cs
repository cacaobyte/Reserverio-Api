using System;
using System.Collections.Generic;

namespace ReserverioCore.ML.Reserverio;

public partial class Organization
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public string? LegalName { get; set; }

    public string? LogoUrl { get; set; }

    public string? Website { get; set; }

    public string? Email { get; set; }

    public string? Phone { get; set; }

    public string? Description { get; set; }

    public int CountryId { get; set; }

    public DateOnly? CreatedAt { get; set; }

    public DateOnly? UpdatedAt { get; set; }

    public bool? IsActive { get; set; }
}
