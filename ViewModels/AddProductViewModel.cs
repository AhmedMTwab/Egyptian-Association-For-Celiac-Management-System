namespace Egyptian_association_of_cieliac_patients.ViewModels
{
    public class AddProductViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Details { get; set; }
        public decimal Price { get; set; }
        public string? ImagePath { get; set; }
        public IFormFile Product_Image { get; set; }
        public int AssosiationId { get; set; }
    }
}
