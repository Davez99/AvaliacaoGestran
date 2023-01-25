using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using GestranAPI.Entities;

namespace GestranAPI.Context
{
    public class ContextGestran : DbContext
    {
        public ContextGestran(DbContextOptions<ContextGestran>options) :base(options)
        {
            
        }

        public DbSet<Fornecedor> Fornecedores { get; set; }
        public DbSet<Endereco> Enderecos { get; set; }
    }
}