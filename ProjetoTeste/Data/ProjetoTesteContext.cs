using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ProjetoTeste.Models;

namespace ProjetoTeste.Data
{
    public class ProjetoTesteContext : DbContext
    {
        public ProjetoTesteContext (DbContextOptions<ProjetoTesteContext> options)
            : base(options)
        {
        }

        public DbSet<ProjetoTeste.Models.UserModel> UserModel { get; set; }
    }
}
