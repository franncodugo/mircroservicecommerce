using MCCommerce.Services.CouponAPI.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace MCCommerce.Services.CouponAPI.Controllers;

[ApiController]
[Route("[controller]")]
public class CouponController : Controller
{
    private readonly ApplicationDbContext _context;

    public CouponController(ApplicationDbContext context)
    {
        _context = context;
    }

    [HttpGet]
    public async Task<IActionResult> GetCoupons()
    {
        var coupons = await _context.Coupons.ToListAsync();
        if (!coupons.Any())
            return NotFound();
        return Ok(coupons);
    }

    [HttpGet]
    [Route("{id:int}")]
    public async Task<IActionResult> GetCouponById(int id)
    {
        var coupon = await _context.Coupons.FirstOrDefaultAsync(c => c.CouponId == id);
        if (coupon is null)
            return NotFound();
        return Ok(coupon);
    }
}