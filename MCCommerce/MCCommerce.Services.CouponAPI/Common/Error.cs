namespace MCCommerce.Services.CouponAPI.Common;

/// <summary>
/// Represents Application errors.
/// </summary>
/// <param name="Code"></param>
/// <param name="Description"></param>
public record Error(string Code, string Description)
{
    public static readonly Error None = new(string.Empty, String.Empty);
}