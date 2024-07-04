using System.ComponentModel.DataAnnotations;

namespace Egyptian_association_of_cieliac_patients.ViewModels
{
    public class AddRawMaterialViewModel
    {
        public int Id { get; set; }
        [Required]
        public string? Name { get; set; }
        public string Details { get; set; }
        [Required]
        public decimal Price { get; set; }
       // public string ImagePath { get; set; }
        public IFormFile Material_Image { get; set; }
        public int AssosiationId { get; set; }
    }
}
