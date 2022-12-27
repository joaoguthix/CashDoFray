using System.ComponentModel.DataAnnotations;

namespace CashDoFray.Model
{
    public class Picture
    {
        
        public int Id { get; set; }

        [Required]
        public byte[]? Image { get; set; }

        [Required]
        public string? Title { get; set; }

        public string? Description { get; set; }

        public FormFile? image { get; set; }

        internal IDisposable OpenReadStream()
        {
            throw new NotImplementedException();
        }
    }
}
