using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;

namespace Egyptian_association_of_cieliac_patients.ViewModels
{
    public class AddProductViewModel
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public string? Details { get; set; }
        [Required]
        public decimal Price { get; set; }
        public string? ImagePath { get; set; }
        public IFormFile Product_Image { get; set; }
        public int AssosiationId { get; set; }
    }
}
