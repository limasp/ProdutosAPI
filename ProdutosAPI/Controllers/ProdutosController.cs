using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProdutosAPI.Context;
using ProdutosAPI.Models;
using System.Linq;
using System.Threading.Tasks;

namespace ProdutosAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProdutosController : ControllerBase
    {
        private readonly AppDbContext _appDbContext;

        public ProdutosController(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        [HttpGet]
        public async Task<IActionResult> GetProdutos()
        {
            var result = await _appDbContext.Produtos.Include(x => x.Categorias)
                                                     .Include(x => x.Midias)
                                                     .Include(x => x.Tags)
                                                     .ToListAsync();
            return Ok(new
            {
                success = true,
                data = result
            });
        }
        [Route("Id/{id}")]
        [HttpGet]
        public async Task<IActionResult> GetProdutoPorId(int id)
        {
            var result = (await _appDbContext.Produtos.Include(x => x.Categorias)
                                                      .Include(x => x.Midias)
                                                      .Include(x => x.Tags)
                                                      .ToListAsync()).FirstOrDefault(x => x.Id == id);
            return Ok(new
            {
                success = true,
                data = result
            });
        }

        [HttpPost]
        public async Task<IActionResult> CreateProdutos(Produto produto)
        {
            _appDbContext.Produtos.Add(produto);
            await _appDbContext.SaveChangesAsync();

            return Ok(new
            {
                success = true,
                data = produto
            });
        }
        
        [HttpPut]
        public async Task<IActionResult> UpdateProdutos(Produto produto)
        {
            _appDbContext.Produtos.Update(produto);
            await _appDbContext.SaveChangesAsync();

            return Ok(new
            {
                success = true,
                data = produto
            });
        }

        [Route("Id/{id}")]
        [HttpDelete]
        public async Task<IActionResult> DeleteProdutos(int id)
        {
            Produto produto = (await _appDbContext.Produtos.Include(x => x.Categorias)
                                                       .Include(x => x.Midias)
                                                       .Include(x => x.Tags)
                                                       .ToListAsync()).FirstOrDefault(x => x.Id == id);


            foreach (var item in produto.Categorias)
            {
                _appDbContext.Categorias.Remove(item);
            }
            foreach (var item in produto.Midias)
            {
                _appDbContext.Midias.Remove(item);
            }
            foreach (var item in produto.Tags)
            {
                _appDbContext.Tags.Remove(item);
            }
            _appDbContext.Produtos.Remove(produto);
            await _appDbContext.SaveChangesAsync();

            return Ok(new
            {
                success = true,
                data = produto
            });
        }

    }
}
