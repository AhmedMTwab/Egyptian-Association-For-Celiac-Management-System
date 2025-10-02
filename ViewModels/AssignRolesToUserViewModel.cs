using Microsoft.AspNetCore.Mvc.Rendering;

namespace Egyptian_association_of_cieliac_patients.ViewModels
{
    public class AssignRolesToUserViewModel
    {
        public string UserId { get; set; }
        public string? UserName { get; set; }
        public string[] RoleNames { get; set; }
        public List<SelectListItem> AllRoles { get; set; }=new List<SelectListItem>();
        public string? UserRole { get; set; }
    }
}
