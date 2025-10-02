using System.ComponentModel.DataAnnotations;

namespace Egyptian_association_of_cieliac_patients.ViewModels
{
    public class EditRawMaterialViewModel
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public string? Details { get; set; }
        [Required]
        public decimal Price { get; set; }
     
        public int AssosiationId { get; set; }
    }
}
