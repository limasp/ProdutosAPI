using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProdutosAPI.Context;
using ProdutosAPI.Models;
using System;
using System.Collections.Generic;
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
            return Ok(new
            {
                success = true,
                data = await _appDbContext.Produtos.ToListAsync()
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

    }
}
