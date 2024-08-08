using System.ComponentModel.DataAnnotations;

namespace Proyecto2ProgramacionAvanzadaWeb.Models
{
    public class RolPermissions
    {
        [Key]
        public int RolPermissionId { get; set; }
<<<<<<< HEAD
        public required Roles Rol { get; set; }
        public required Permissions Permission { get; set; }
=======
        public Roles Rol { get; set; }
        public Permissions Permission { get; set; }
>>>>>>> 7e619a760a9991348b64feaa1be766d081e6e088
    }
}
