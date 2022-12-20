using System.ComponentModel.DataAnnotations;

namespace CashDoFray.Model
{
    public class Message
    {
        
        public int? Id { get; set; }

        [Required]
        public string? Name { get; set; }

        [Required]
        public string? Title { get; set; }

        [Required]
        public string? Body { get; set; }

    }
}
