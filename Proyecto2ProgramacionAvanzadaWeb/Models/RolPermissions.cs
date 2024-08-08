using System.ComponentModel.DataAnnotations;

namespace Proyecto2ProgramacionAvanzadaWeb.Models
{
    public class RolPermissions
    {
        [Key]
        public int RolPermissionId { get; set; }
        public required Roles Rol { get; set; }
        public required Permissions Permission { get; set; }
    }
}
