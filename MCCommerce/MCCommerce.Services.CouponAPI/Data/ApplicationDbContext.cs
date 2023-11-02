using MCCommerce.Services.CouponAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace MCCommerce.Services.CouponAPI.Data;

public sealed class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
        
    }

    public DbSet<Coupon> Coupons { get; set; }
}