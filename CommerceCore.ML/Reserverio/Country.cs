using System;
using System.Collections.Generic;

namespace ReserverioCore.ML.Reserverio;

public partial class Country
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public string? IsoCode { get; set; }

    public string? PhoneCode { get; set; }

    public string? Currency { get; set; }

    public string? CurrencyCode { get; set; }

    public string? CurrencySymbol { get; set; }

    public string? FlagUrl { get; set; }

    public string? Continent { get; set; }

    public decimal? Latitude { get; set; }

    public decimal? Longitude { get; set; }

    public string? Timezone { get; set; }

    public bool? IsActive { get; set; }

    public DateOnly? CreatedAt { get; set; }

    public DateOnly? UpdatedAt { get; set; }

    public bool? Enable { get; set; }
}
