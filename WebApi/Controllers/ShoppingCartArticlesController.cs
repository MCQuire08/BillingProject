using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApi.Entity;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ShoppingCartArticlesController : ControllerBase
    {
        private readonly DataContext _context;

        public ShoppingCartArticlesController(DataContext context)
        {
            _context = context;
        }

        [HttpPost("addArticle")]
        public async Task<ActionResult> AddArticleToShoppingCart(ShoppingCartArticle shoppingCartArticle)
        {
            var existingRecord = await _context.ShoppingCartArticles
                .FirstOrDefaultAsync(sca => sca.CartId == shoppingCartArticle.CartId && sca.ArticleId == shoppingCartArticle.ArticleId);

            if (existingRecord != null)
            {
                existingRecord.Amount = shoppingCartArticle.Amount;

                try
                {
                    _context.ShoppingCartArticles.Update(existingRecord);
                    await _context.SaveChangesAsync();
                    return Ok("La cantidad del artículo en el carrito de compras se actualizó correctamente.");
                }
                catch (Exception ex)
                {
                    return BadRequest($"Error al actualizar la cantidad del artículo en el carrito de compras: {ex.Message}");
                }
            }
            else
            {
                try
                {
                    _context.ShoppingCartArticles.Add(shoppingCartArticle);
                    await _context.SaveChangesAsync();
                    return Ok("El artículo se agregó al carrito de compras correctamente.");
                }
                catch (Exception ex)
                {
                    return BadRequest($"Error al agregar el artículo al carrito de compras: {ex.Message}");
                }
            }
        }



    }
}
