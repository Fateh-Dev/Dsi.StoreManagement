using System;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.NetworkInformation;
using System.Threading.Tasks;
using Dsi.StoreManagement.Documents;
using Dsi.StoreManagement.EntityFrameworkCore;
using Dsi.StoreManagement.Operations;
using Dsi.StoreManagement.Products;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json.Linq;
using Volo.Abp.AspNetCore.Mvc;

namespace Dsi.StoreManagement.Controllers;

[Route("api/1.0/product")]
[ApiExplorerSettings(GroupName = "RestController")]
public class MyController : AbpControllerBase
{
    private readonly StoreManagementDbContext _context;

    public MyController(StoreManagementDbContext dbcontext)
    {
        _context = dbcontext;
    }
    [HttpGet("getProductById")]
    public async Task<ActionResult<Product>> getProduct(Guid Id)
    {
        var ev = await _context.Products
                .Include(e => e.Category)
                .Include(e => e.Color)
                .Include(e => e.Marque)
                .Include(e => e.Model)
                .Include(e => e.Unit)
                .Where(s => s.Id == Id)
                .FirstOrDefaultAsync();
        if (ev == null)
        {
            return NotFound();
        }
        return Ok(ev);
    }
    [HttpGet("getDocumentById")]
    public async Task<ActionResult<Document>> getDocumentItem(Guid Id)
    {
        var ev = await _context.Documents
                .Include(e => e.ProductList)
                .Where(s => s.Id == Id)
                .FirstOrDefaultAsync();
        if (ev == null)
        {
            return NotFound();
        }
        return Ok(ev);
    }
}

