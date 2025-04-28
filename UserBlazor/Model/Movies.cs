namespace UserBlazor.Model
{
    public class Movies
    {
        public int MovieID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Genre { get; set; }
        public DateTime ReleaseDate { get; set; }
        public decimal Rating { get; set; }
        public string PhotoPath { get; set; }
    }
}
