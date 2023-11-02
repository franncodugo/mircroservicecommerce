namespace MCCommerce.Services.CouponAPI.Models;

public sealed class Coupon
{
    public int CouponId { get; set; }
    public string CouponCode { get; set; } = string.Empty;
    public double DiscountAmount { get; set; }
    public int MinAmount { get; set; }
}