namespace MovieLibrary.API.Entities
{
	public class Movie
	{
		public int Id { get; set; }
		public string Title { get; set; } = String.Empty;
		public string Description { get; set; } = String.Empty;
		public string Rating { get; set; } = String.Empty;
		public string Genre { get; set; } = String.Empty;
		public DateTime ReleaseDate { get; set; }
		public int Length { get; set; }

	}
}
