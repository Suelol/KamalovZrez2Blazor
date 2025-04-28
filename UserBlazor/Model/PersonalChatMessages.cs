using System.ComponentModel.DataAnnotations;

namespace UserBlazor.Model
{
    public class PersonalChatMessages
    {
        [Key]
        public int Id { get; set; }
        public string SenderId { get; set; }
        public string SenderName { get; set; }
        public string RecipientId { get; set; }
        public string Message { get; set; }
        public DateTime DateTime { get; set; }
    }
}
