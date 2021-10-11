using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BEComentarios.Models;
using Microsoft.EntityFrameworkCore;

namespace BEComentarios
{
    public class AplicationDbContext :DbContext
    {
        public DbSet<Comentario> Comentario { get; set; }

        public AplicationDbContext(DbContextOptions<AplicationDbContext> options): base(options)
        {

        }
    }
}
