using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EFCoreInMemoryDemo.Web.DataContext
{
public class BoardGamesDBContext : DbContext
{
    public BoardGamesDBContext(DbContextOptions<BoardGamesDBContext> options)
        : base(options)
    {
    }

    public DbSet<Models.BoardGame> BoardGames { get; set; }
}
}
