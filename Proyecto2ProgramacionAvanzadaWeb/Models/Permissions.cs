using System.ComponentModel.DataAnnotations;

namespace Proyecto2ProgramacionAvanzadaWeb.Models
{
    public class Permissions
    {
        [Key]
        public int PermissionId { get; set; }

        [Required]
        [StringLength(50)]
        public string PermissionName { get; set; }

        [Required]
        [StringLength(500)]
        public string PermissionDescription { get; set; }

        public ICollection<RolPermissions>? RolPermissions { get; set; }

    }
}
