namespace Ecommerce.Models
{
    public class Role
    {
        public int RoleId { get; set; }
        public String RoleName { get; set; }=string.Empty;

        public ICollection<UserRole> ? UserRoles { get; set; }
    }
}
