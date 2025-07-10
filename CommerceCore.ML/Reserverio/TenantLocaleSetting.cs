using System;
using System.Collections.Generic;

namespace ReserverioCore.ML.Reserverio;

public partial class TenantLocaleSetting
{
    public int Id { get; set; }

    public int TenantId { get; set; }

    public string? LanguageCode { get; set; }

    public string? CurrencyCode { get; set; }

    public string? DateFormat { get; set; }

    public string? TimeFormat { get; set; }

    public string? Timezone { get; set; }

    public DateOnly? CreatedAt { get; set; }

    public DateOnly? UpdateAt { get; set; }
}
