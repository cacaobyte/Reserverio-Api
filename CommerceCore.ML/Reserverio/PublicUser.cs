using System;
using System.Collections.Generic;

namespace ReserverioCore.ML.Reserverio;

public partial class PublicUser
{
    public int Id { get; set; }

    public string? FirstName { get; set; }

    public string? LastName { get; set; }

    public decimal? PhoneCode { get; set; }

    public decimal? Phone { get; set; }

    public string? PasswordHash { get; set; }

    public bool? IsVerified { get; set; }

    public string? Email { get; set; }

    public string? AvatarUrl { get; set; }

    public string? PreferredLanguage { get; set; }

    public string? PreferredTimezone { get; set; }

    public bool? Active { get; set; }

    public DateOnly? CreatedAt { get; set; }

    public DateOnly? UpdatedAt { get; set; }

    public string? UserName { get; set; }
}
