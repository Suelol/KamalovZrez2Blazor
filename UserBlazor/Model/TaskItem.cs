using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UserBlazor.Model
{
    public class TaskItem
    {
        [Key]
        public int TaskItemId { get; set; }

        [Required(ErrorMessage = "Название обязательно")]
        [StringLength(100, ErrorMessage = "Максимальная длина названия - 100 символов")]
        public string Title { get; set; }

        [Required(ErrorMessage = "Описание обязательно")]
        [StringLength(500, ErrorMessage = "Максимальная длина описания - 500 символов")]
        public string Description { get; set; }

        [Required(ErrorMessage = "Укажите срок выполнения")]
        public DateTime Deadline { get; set; }

        [ForeignKey("ContractorId")]
        public int? ContractorId { get; set; }
    }
}