using Microsoft.EntityFrameworkCore;
using MovieLibrary.API.Entities;
using System.Reflection;

namespace MovieLibrary.API.Data
{
	public class MovieLibraryDbContext : DbContext
	{
		public MovieLibraryDbContext(DbContextOptions<MovieLibraryDbContext> options) : base(options)
		{

		}

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			base.OnModelCreating(modelBuilder);

			modelBuilder.Entity<Movie>().HasData(new Movie
			{
				Id = 1,
				Title = "Indiana Jones and the Last Crusade",
				Description = "Indiana Jones and the Last Crusade is a 1989 American action-adventure film directed by Steven Spielberg, from a story co-written by executive producer George Lucas. It is the third installment in the Indiana Jones franchise and a sequel to Raiders of the Lost Ark (1981). Harrison Ford returned in the title role, while his father is portrayed by Sean Connery. Other cast members featured include Alison Doody, Denholm Elliott, Julian Glover, River Phoenix, and John Rhys-Davies. In the film, set largely in 1938, Indiana searches for his father, a Holy Grail scholar, who has been kidnapped and held hostage by the Nazis while on a journey to find the Holy Grail.",
				Rating = "PG-13",
				Genre = "Action",
				ReleaseDate = new DateTime(5/24/1989),
				Length = 127
			});
		}

		public DbSet<Movie> Movie { get; set; }
	}
}
