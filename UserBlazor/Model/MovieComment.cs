using System.ComponentModel.DataAnnotations;

namespace UserBlazor.Model
{
    public class MovieComment
    {
        [Key]
        public int Id { get; set; }
        public string UserId { get; set; }
        public string UserName { get; set; }
        public string MovieId { get; set; }
        public string? Message { get; set; }
		public DateTime DateTime { get; set; } = DateTime.Now;

	}
}
