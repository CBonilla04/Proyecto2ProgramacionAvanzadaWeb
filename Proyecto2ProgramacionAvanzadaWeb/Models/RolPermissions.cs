using System.ComponentModel.DataAnnotations;

namespace Proyecto2ProgramacionAvanzadaWeb.Models
{
    public class RolPermissions
    {
        [Key]
        public int RolPermissionId { get; set; }
        public Roles Rol { get; set; }
        public Permissions Permission { get; set; }
    }
}
