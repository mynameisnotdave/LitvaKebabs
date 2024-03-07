namespace LitvaKebabs.Models
{
    public class Role
    {
        public int RoleId { get; set; }
        public string RoleName { get; set; }

        public int UserId { get; set; }
        public virtual User? Users { get; set; }
        
    }
}
