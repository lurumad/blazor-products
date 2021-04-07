using BlazorProducts.Api.Data;
using BlazorProducts.Api.Pagination;
using BlazorProducts.Shared.Models;
using BlazorProducts.Shared.RequestFeatures;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;

namespace BlazorProducts.Api.Controllers
{
    [ApiController]
    [Route("api/products")]
    public class ProductsController : ControllerBase
    {
        private readonly ProductsDbContext _dbContext;
        private readonly ILogger<ProductsController> _logger;

        public ProductsController(
            ProductsDbContext dbContext,
            ILogger<ProductsController> logger)
        {
            _dbContext = dbContext;
            _logger = logger;
        }

        [HttpGet]
        [Route("{id:guid}")]
        [ProducesResponseType(typeof(IEnumerable<Shared.Models.Product>), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ProblemDetails), StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<IEnumerable<Shared.Models.Product>>> Get(Guid id)
        {
            var product = await _dbContext.Products.SingleOrDefaultAsync(p => p.Id == id);

            if (product is null)
            {
                return NotFound();
            }

            return Ok(product);
        }

        [HttpGet]
        [ProducesResponseType(typeof(PagedList<Shared.Models.Product>), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ProblemDetails), StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<IEnumerable<Shared.Models.Product>>> Get([FromQuery] ProductParameters productParameters)
        {
            var products = await _dbContext.Products
                .Search(productParameters.SearchTerm)
                .Sort(productParameters.OrderBy)
                .Select(p => new Shared.Models.Product
                {
                    Id = p.Id,
                    Name = p.Name,
                    Description = p.Description,
                    ImageUrl = p.ImageUrl,
                    Price = p.Price,
                    Supplier = p.Supplier
                })
                .ToListAsync();

            var pagedList = PagedList<Shared.Models.Product>.ToPagedList(
                    products,
                    productParameters.PageNumber,
                    productParameters.PageSize);

            Response.Headers.Add("X-Pagination", JsonSerializer.Serialize(pagedList.MetaData));

            return Ok(pagedList);
        }

        [HttpPost]
        public async Task<IActionResult> Create(Product product)
        {
            if (product is null)
            {
                return BadRequest();
            }

            //model validation

            var newProduct = new Model.Product
            {
                Name = product.Name,
                Description = product.Description,
                ImageUrl = product.ImageUrl,
                Price = product.Price,
                Supplier = product.Supplier
            };

            _dbContext.Add(newProduct);
            await _dbContext.SaveChangesAsync();
            product.Id = newProduct.Id;

            return CreatedAtAction(nameof(Get), new { id = newProduct.Id }, product);
        }

        [HttpPut]
        [Route("{id:guid}")]
        [ProducesResponseType(typeof(void), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ProblemDetails), StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult> Update(Guid id, [FromBody] Product product)
        {
            var existingProduct = await _dbContext.Products.FindAsync(id);

            if (existingProduct is null)
            {
                return NotFound();
            }

            existingProduct.Name = product.Name;
            existingProduct.Description = product.Description;
            existingProduct.Supplier = product.Supplier;
            existingProduct.Price = product.Price;
            existingProduct.ImageUrl = product.ImageUrl;

            await _dbContext.SaveChangesAsync();

            return NoContent();
        }

        [HttpDelete]
        [Route("{id:guid}")]
        [ProducesResponseType(typeof(void), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ProblemDetails), StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult> Delete(Guid id)
        {
            var existingProduct = await _dbContext.Products.FindAsync(id);

            if (existingProduct is null)
            {
                return NotFound();
            }

            _dbContext.Remove(existingProduct);
            await _dbContext.SaveChangesAsync();

            return NoContent();
        }
    }
}
