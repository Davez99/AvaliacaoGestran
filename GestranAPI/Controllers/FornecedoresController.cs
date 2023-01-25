using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using GestranAPI.Context;
using GestranAPI.Entities;

namespace GestranAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class FornecedoresController : ControllerBase
    {
        private readonly ContextGestran _context;
        public FornecedoresController(ContextGestran context)
        {
            _context = context;
        }

        [HttpPost]
        public IActionResult Cadastrar(Fornecedor fornecedor){

            _context.Add(fornecedor);
            _context.SaveChanges();

            return Ok(fornecedor);
        }
    }
}