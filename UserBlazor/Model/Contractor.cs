using System.ComponentModel.DataAnnotations;

namespace Apishka.Model
{
    public class Contractor
    {
        [Key]
        public int ContractorId { get; set; }
        public string Name { get; set; }
        public string ContactInfo { get; set; }

    }
}