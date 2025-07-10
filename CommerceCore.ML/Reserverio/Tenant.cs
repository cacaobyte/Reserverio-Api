using System;
using System.Collections.Generic;

namespace ReserverioCore.ML.Reserverio;

public partial class Tenant
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public bool? Active { get; set; }

    public string? ContactEmail { get; set; }

    public string? ContactPhone { get; set; }

    public string? CustomUrl { get; set; }

    public string? Plan { get; set; }

    public DateOnly? RegistrationDate { get; set; }

    public DateOnly? ExpirationDate { get; set; }

    public int? LogoUrl { get; set; }

    public string? Industry { get; set; }

    public DateOnly? CreatedAt { get; set; }

    public string? CreatedBy { get; set; }

    public DateOnly? UpdatedAt { get; set; }

    public string? UpdatedBy { get; set; }

    public decimal? Latitude { get; set; }

    public decimal? Longitude { get; set; }

    public string? AddressLine { get; set; }

    public string? ReferenceNote { get; set; }

    public string? Country { get; set; }

    public string? StateOrRegion { get; set; }

    public string? City { get; set; }

    public string? PostalCode { get; set; }

    public string? Timezone { get; set; }

    public string? BrandColor { get; set; }

    public int IdSetting { get; set; }

    public int CountryId { get; set; }

    public int ParentTenantId { get; set; }

    public bool? IsMainTenant { get; set; }
}
