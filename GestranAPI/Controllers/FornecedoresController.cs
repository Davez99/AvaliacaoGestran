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

         [HttpDelete("RemoverFornecedor/{id}")]
        public IActionResult RemoverFornecedor(int id){
            var fornecedorRemover = _context.Fornecedores.Find(id);
            if(fornecedorRemover == null)
                return NotFound();

            _context.Fornecedores.Remove(fornecedorRemover);
            _context.SaveChanges();

            return Ok(fornecedorRemover);
        }


        [HttpGet("BuscarFornecedorUnico/{id}")]
        public IActionResult BuscarFornecedorUnico(int id){
            var fornecedor = _context.Fornecedores.Where(x => x.Id.Equals(id)).ToList();
            if(fornecedor == null)
                return NotFound();
            var endereco = _context.Enderecos.ToList();
            var query = from f in fornecedor
                        join e in endereco
                        on f.Endereco.Id equals e.Id
                        select new {
                            Fornecedor = f
                        };
            return Ok(query);
        }

        [HttpGet("BuscarFornecedor")]
        public IActionResult BuscarFornecedor(string nome, Int64? cnpj, string cidade){
            
            if(nome != null){
                var resultNome = _context.Fornecedores.Where(x => x.Nome.Contains(nome)).ToList();
                return Ok(resultNome);
            }
            if(cnpj != null){
                var resultCnpj = _context.Fornecedores.Where(x => x.CNPJ == cnpj);
                return Ok(resultCnpj);
            }
            if(cidade != null){
                var resultCidade = _context.Fornecedores.Where(x => x.Endereco.Cidade.Contains(cidade));
                return Ok(resultCidade);
            }
            
            var result = _context.Fornecedores.ToList();

            return Ok(result);
        }

        [HttpPut("{id}")]
        public IActionResult AtualizarFornecedor(int id, Fornecedor fornecedor){

            var fornecedorId = _context.Fornecedores.Find(id);

            if(fornecedorId == null)
                return NotFound();

            fornecedorId = fornecedor;
            _context.Update(fornecedorId);
            _context.SaveChanges();

            return Ok(fornecedorId);
        }

        

        [HttpPost]
        public IActionResult CadastrarFornecedor(Fornecedor fornecedor){

            _context.Add(fornecedor);
            _context.SaveChanges();

            return Ok(fornecedor);
        }

        
    }
}